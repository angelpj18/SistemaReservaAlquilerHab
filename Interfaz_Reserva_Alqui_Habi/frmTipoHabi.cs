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
    public partial class frmTipoHabi : Form
    {
        public frmTipoHabi()
        {
            InitializeComponent();
        }

        private void LimpiarFormulario()
        {
            txtId.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            
        }

        private void ActualizarListaTipoHab()
        {
            lstTipoHabitacion.DataSource = null;
            lstTipoHabitacion.DataSource = tipoHabitacion.ObtenerTipos();
        }

        private tipoHabitacion ObtenerTipHabFormulario()
        {
            tipoHabitacion  t = new tipoHabitacion();
            t.Id = Convert.ToInt32(txtId.Text);
            t.Descripcion = txtDescripcion.Text;
            t.precioTipoHab = txtPrecio.Text;

            return t;
        }

        private void frmTipoHabi_Load(object sender, EventArgs e)
        {
            Personalizacion.BorderRedondoButton(btnAgregar);
            Personalizacion.BorderRedondoButton(btnEliminar);
            Personalizacion.BorderRedondoButton(btnEditar);
            Personalizacion.BorderRedondoButton(btnLimpiar);

            ActualizarListaTipoHab();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                tipoHabitacion tip = new tipoHabitacion();
                tip.Id = Convert.ToInt32(txtId.Text);
                tip.precioTipoHab = txtPrecio.Text;
                tip.Descripcion = txtDescripcion.Text;



                tipoHabitacion.AgregarTipoHab(tip);
                LimpiarFormulario();
                ActualizarListaTipoHab();

            }

        }

        private bool ValidarCampos()
        {
            if (String.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("El precio no puede estar vacío", "Error");
                txtPrecio.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("La descripción no puede estar vacía", "Error");
                txtDescripcion.Focus();
                return false;
            }
            return true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lstTipoHabitacion.SelectedItems.Count == 0)
            {
                MessageBox.Show("Para eliminar debe seleccionar un Tipo Habitacion");
            }
            else
            {
                tipoHabitacion  tipHab = (tipoHabitacion)lstTipoHabitacion.SelectedItem;
                tipoHabitacion.EliminarTipoHabitacion(tipHab);
                ActualizarListaTipoHab();
                LimpiarFormulario();
            }


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int index = lstTipoHabitacion.SelectedIndex;
            tipoHabitacion t = ObtenerTipHabFormulario();
            tipoHabitacion.EditarTipoHab(index, t);


            LimpiarFormulario();
            ActualizarListaTipoHab();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();

        }

        private void lstTipoHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoHabitacion t = (tipoHabitacion)lstTipoHabitacion.SelectedItem;

            if (t != null)
            {
                txtId.Text = Convert.ToString(t.Id);
                txtDescripcion.Text = t.Descripcion;
                txtPrecio.Text = t.precioTipoHab;

            }

        }
    }
    }

