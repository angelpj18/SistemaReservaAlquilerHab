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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            actualizarListaCliente();
            txtCi.Focus();
        }

       private void actualizarListaCliente()
        {
            lstCliente.DataSource = null;
            lstCliente.DataSource = Cliente.ObtenerClientes();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Cliente c = ObtenerClienteFormulario();

            Cliente.AgregarCliente(c);

            actualizarListaCliente();
            LimpiarFormulario();
        }
        private Cliente ObtenerClienteFormulario()
        {
            Cliente c = new Cliente();
            c.ciCliente = txtNombre.Text;
            c.nombre = txtCi.Text;
            c.direccion = txtDireccion.Text;
            c.telefono = txtTelefono.Text;
            c.email = txtEmail.Text;

            return c;
        }
        private void LimpiarFormulario()
        {
            txtNombre.Text = "";
            txtCi.Text = "";
            txtDireccion.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var c = ObtenerClienteFormulario();

            if (this.lstCliente.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Favor seleccione una fila");
                }

                else
                {
                    int indice = lstCliente.SelectedIndex;
                    Cliente.EditarCliente(c, indice);
                    actualizarListaCliente();
                }
            }
        

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstCliente.SelectedItems.Count > 0)
            {

                Cliente cli = (Cliente)lstCliente.SelectedItem;
                Cliente.listaClientes.Remove(cli);
                actualizarListaCliente();
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Para eliminar debe seleccionar una fila");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void lstCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente c = (Cliente)lstCliente.SelectedItem;
            if (c != null)
            {
                txtCi.Text = c.nombre;
                txtNombre.Text = c.ciCliente;
                txtDireccion.Text = c.direccion;
                txtTelefono.Text = c.telefono;
                txtEmail.Text = c.email;
                
            }
        }
    }
}
