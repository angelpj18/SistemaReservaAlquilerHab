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
    
    public partial class frmPiso : Form
    {
        string com;
        public frmPiso()
        {
            InitializeComponent();
        }

        private void LimpiarFormulario()
        {
            txtId.Text = "";
            txtNroPiso.Text = ""; ;
            txtDescripcion.Text = ""; 
        }

        private void ActualizarListaPiso()
        {
            lstPiso.DataSource = null;
           lstPiso.DataSource = Piso.ObtenerPisos();
        }

        private Piso ObtenerPisoFormulario()
        {
            Piso p = new Piso();
            p.Id = Convert.ToInt16(txtId.Text);
            p.NroPiso = txtNroPiso.Text;
            p.Descripcion = txtDescripcion.Text;

            return p;
        }

        private void frmPiso_Load(object sender, EventArgs e)
        {
            ActualizarListaPiso();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Piso pis = new Piso();
                pis.NroPiso = txtNroPiso.Text;
                pis.Descripcion = txtDescripcion.Text;



                Piso.AgregarPiso(pis);
                LimpiarFormulario();
                ActualizarListaPiso();

            }
        }

        private bool ValidarCampos()
        {
            if (String.IsNullOrWhiteSpace(txtNroPiso.Text))
            {
                MessageBox.Show("El número de Piso no puede estar vacío", "Error");
                txtNroPiso.Focus();
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
            if (this.lstPiso.SelectedItems.Count == 0)
            {
                MessageBox.Show("Para eliminar debe seleccionar un piso");
            }
            else
            {
                Piso piso = (Piso)lstPiso.SelectedItem;
                Piso.EliminaPiso(piso);
                ActualizarListaPiso();
                LimpiarFormulario();
            }


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int index = lstPiso.SelectedIndex;
            Piso p = ObtenerPisoFormulario();
            Piso.EditarPiso(index, p);


            LimpiarFormulario();
            ActualizarListaPiso();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void lstPiso_SelectedIndexChanged(object sender, EventArgs e)
        {
            Piso p = (Piso)lstPiso.SelectedItem;

            if (p != null)
            {
                txtId.Text = Convert.ToString(p.Id);
                txtNroPiso.Text = p.NroPiso;
                txtDescripcion.Text = p.Descripcion;
               
            }

        }
    }
}
