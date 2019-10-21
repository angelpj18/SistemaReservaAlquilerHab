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
            Cliente cli = ObtenerClienteFormulario();

            Cliente.AgregarCliente(cli);
            actualizarListaCliente();
            LimpiarFormulario();
        }
        private Cliente ObtenerClienteFormulario()
        {
            Cliente c = new Cliente();
            c.ciCliente = txtCi.Text;
            c.nombre = txtNombre.Text;
            c.direccion = txtDireccion.Text;
            c.telefono = txtTelefono.Text;

            return c;
        }
        private void LimpiarFormulario()
        {
            txtCi.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cliente cli = (Cliente)lstCliente.SelectedItem;
            if (cli != null)
            {
                int index = lstCliente.SelectedIndex;
                Cliente.listaClientes[index] = ObtenerClienteFormulario();
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
            Cliente cli = (Cliente)lstCliente.SelectedItem;
            if (cli != null)
            {
                txtCi.Text = cli.ciCliente;
                txtNombre.Text = cli.nombre;
                txtDireccion.Text = cli.direccion;
                txtTelefono.Text = cli.telefono;
                txtEmail.Text = cli.email;
                
            }
        }
    }
}
