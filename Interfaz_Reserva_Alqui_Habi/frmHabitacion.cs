using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaReservaAlquilerHabi;

namespace Interfaz_Reserva_Alqui_Habi
{
    public partial class frmHabitacion : Form
    {
     
        public frmHabitacion()
        {
            InitializeComponent();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //empty implementation
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            /*Habitacion habi = ObtenerHabitacionFormulario();
            Habitacion.AgregarHabitacion(habi);
            ActualizarListaHabitacion();
            LimpiarFormulario();*/


            /*if (modo == "I")
            {
                Habitacion habi = ObtenerHabitacionFormulario();
                Habitacion.AgregarHabitacion(habi);
            }
            else if (modo == "E")
            {
                int index = lstHabitacion.SelectedIndex;
                Habitacion habi = ObtenerHabitacionFormulario();
                Habitacion.EditarHabitacion(index, habi);
            }
            ActualizarListaHabitacion();
            LimpiarFormulario();*/

            if (ValidarCampos())
            {
                Habitacion habi = new Habitacion();
                habi.descripcion = txtDescripcion.Text;
                habi.categoria = (CategoriaH)cmbCategoria.SelectedItem;
                habi.piso = (Piso)cmbPiso.SelectedItem;
                habi.habilitado = (EstadoHab)cmbCategoria.SelectedItem;


                Habitacion.AgregarHabitacion(habi);
                LimpiarFormulario();
                ActualizarListaHabitacion();

            }

            

        }

        private bool ValidarCampos()
        {
            if (cmbCategoria.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione una Categoria", "Error");
                cmbCategoria.Focus();
                return false;
            }

            if (cmbPiso.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione un Piso", "Error");
                cmbPiso.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("La descripcion no puede estar vacía", "Error");
                txtDescripcion.Focus();
                return false;
            }


            return true;
        }

        private void LimpiarFormulario()
        {
            txtNroHabi.Text = "";
            cmbCategoria.SelectedItem = null;
            cmbPiso.SelectedItem = null;
            txtDescripcion.Text = "";
        }

        private void ActualizarListaHabitacion()
        {
            lstHabitacion.DataSource = null;
            lstHabitacion.DataSource = Habitacion.ObtenerHabitacion();
        }

        private Habitacion ObtenerHabitacionFormulario()
        {
            Habitacion h = new Habitacion();
            if (!string.IsNullOrEmpty(txtNroHabi.Text))
            {
                h.id = Convert.ToInt32(txtNroHabi.Text);
            }
            h.descripcion = txtDescripcion.Text;
            h.categoria = (CategoriaH)cmbCategoria.SelectedItem;
            h.piso = (Piso)cmbPiso.SelectedItem;
            

            if (rdbSi.Checked)
            {
                h.habilitado = EstadoHab.Si;
            }
            else if (rdbNo.Checked)
            {
                h.habilitado = EstadoHab.No;
            }

            return h;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        //{
        //    if (lstHabitacion.SelectedItems.Count > 0)
        //    {

        //        Habitacion habi = (Habitacion)lstHabitacion.SelectedItem;
        //        Habitacion.listaHabitaciones.Remove(habi);
        //        ActualizarListaHabitacion();
        //        LimpiarFormulario();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Para eliminar debe seleccionar una fila");
        //    }

        //}

        {
            if (this.lstHabitacion.SelectedItems.Count == 0)
            {
                MessageBox.Show("Favor seleccione una fila");
            }
            else
            {
                Habitacion habi = (Habitacion)lstHabitacion.SelectedItem;
                Habitacion.EliminaHabitacion(habi);
                ActualizarListaHabitacion();
                LimpiarFormulario();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Habitacion habi = (Habitacion)lstHabitacion.SelectedItem;
            //if (habi != null)
            //{
            //    int index = lstHabitacion.SelectedIndex;
            //    Habitacion.listaHabitaciones[index] = ObtenerHabitacionFormulario();
            //    ActualizarListaHabitacion();
            //}

            int index = lstHabitacion.SelectedIndex;
            Habitacion habi = ObtenerHabitacionFormulario();
            Habitacion.EditarHabitacion(index, habi);


            LimpiarFormulario();
            ActualizarListaHabitacion();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void lstHabitacion_Click(object sender, EventArgs e)
        {
            Habitacion habi = (Habitacion)lstHabitacion.SelectedItem;
            if (habi != null)
            {
                txtDescripcion.Text = habi.descripcion;
                cmbCategoria.SelectedItem = habi.categoria;
                cmbPiso.SelectedItem = habi.piso;              

                if (habi.habilitado == EstadoHab.Si)
                {
                    rdbSi.Checked = true;
                }
                else if (habi.habilitado == EstadoHab.No)
                {
                    rdbNo.Checked = true;
                }

            }
        }

        private void frmHabitacion_Load(object sender, EventArgs e)
        {
            Personalizacion.BorderRedondoButton(btnAgregar);
            Personalizacion.BorderRedondoButton(btnEliminar);
            Personalizacion.BorderRedondoButton(btnEditar);
            Personalizacion.BorderRedondoButton(btnLimpiar);
            Personalizacion.BorderRedondoButton(btnSalir);



            ActualizarListaHabitacion();
            cmbCategoria.DataSource = Enum.GetValues(typeof(CategoriaH));
           cmbPiso.DataSource = Piso.ObtenerPisos();

            cmbCategoria.SelectedItem = null;
            cmbPiso.SelectedItem = null;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //cierra
            this.Close();
        }

        private void lstHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Habitacion habi = (Habitacion)lstHabitacion.SelectedItem;

            if (habi != null)
            {
                txtNroHabi.Text = Convert.ToString(habi.id);
                txtDescripcion.Text = habi.descripcion;
                //REVISAR
                cmbCategoria.SelectedItem = habi.categoria;
                cmbPiso.SelectedItem = habi.piso;

                if (habi.habilitado == EstadoHab.Si)
                {
                    rdbSi.Checked = true;
                }
                else if (habi.habilitado == EstadoHab.No)
                {
                    rdbNo.Checked = true;
                }
            }

        }
    }
}
