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
            txtNroPiso.Text = ""; ;
            txtDescripcion.Text = ""; ;
        }

        private void ActualizarListaPiso()
        {
            lstPiso.DataSource = null;
            lstPiso.DataSource = Piso.ObtenerPiso();
        }

        private Piso ObtenerPisoFormulario()
        {
            Piso p = new Piso();
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
            Piso piso = ObtenerPisoFormulario();

            Piso.AgregarPiso(piso);
            ActualizarListaPiso();
            LimpiarFormulario();
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
            if (this.lstPiso.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleecionar una fila para modificar");
            }
            else
            {
                com = "EDITAR";
                txtNroPiso.Focus();
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    }
}
