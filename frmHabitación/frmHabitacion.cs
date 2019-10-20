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

namespace frmHabitación
{
    public partial class frmHabitacion : Form
    {
        public frmHabitacion()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Habitacion habitacion = ObtenerHabitacionFormulario();

            Habitacion.AgregarHabitacion(habitacion);
            ActualizarListaHabitacion();
            LimpiarFormulario();
        }


        private void LimpiarFormulario()
        {
            txtDetalle.Text = "";
            cmbCategoria.SelectedItem = null;
            cmbPiso.SelectedItem = null;
            txtDescripcion.Text = "";
            rdbSi.Checked = false;
            rdbNo.Checked = false;
        }



        private void ActualizarListaHabitacion()
        {
            lstHabitacion.DataSource = null;
            lstHabitacion.DataSource = Habitacion.ObtenerHabitacion();
        }



        private Habitacion ObtenerHabitacionFormulario()
        {
            Habitacion h = new Habitacion();
            h.detalle = txtDetalle.Text;

            if (rdbSi.Checked)
            {
                h.habilitado = EstadoHab.Si;
            }
            else if (rdbNo.Checked)
            {
                h.habilitado = EstadoHab.No;
            }

            h.categoria = (Categoria)cmbCategoria.SelectedItem;
            h.piso = (Piso)cmbPiso.SelectedItem;
            h.descripcion = txtDescripcion.Text;

            return h;
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstHabitacion.SelectedItems.Count > 0)
            {

                Habitacion habi = (Habitacion)lstHabitacion.SelectedItem;
                Habitacion.listaHabitaciones.Remove(habi);
                ActualizarListaHabitacion();
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Para eliminar debe seleccionar una fila");
            }
        }



        private void btnEditar_Click(object sender, EventArgs e)
        {
            Habitacion habi = (Habitacion)lstHabitacion.SelectedItem;
            if (habi != null)
            {
                int index = lstHabitacion.SelectedIndex;
                Habitacion.listaHabitaciones[index] = ObtenerHabitacionFormulario();
                ActualizarListaHabitacion();
            }
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
                txtDetalle.Text = habi.detalle;
                cmbCategoria.SelectedItem = habi.categoria;
                cmbPiso.SelectedItem = habi.piso;
                txtDescripcion.Text = habi.descripcion;

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
            ActualizarListaHabitacion();
            cmbCategoria.DataSource = Enum.GetValues(typeof(CategoriaHabi));
            cmbPiso.DataSource = Enum.GetValues(typeof(Piso));
 
            cmbCategoria.SelectedItem = null;
            cmbPiso.SelectedItem = null;
        }
    }
}
