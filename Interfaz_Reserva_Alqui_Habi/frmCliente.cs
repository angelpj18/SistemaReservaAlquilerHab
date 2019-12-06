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
        string modo;

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
            lstCliente.DataSource = Cliente.ObtenerCliente();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ValidarCampos();

            Cliente c = new Cliente();
            c.ciCliente = txtCi.Text;
            c.nombre = txtNombre.Text;
            c.direccion = txtDireccion.Text;
            c.telefono = txtTelefono.Text;
            c.email = txtEmail.Text;


            Cliente.AgregarCliente(c);
            LimpiarFormulario();
            ActualizarListaCliente();
            //Cliente c = ObtenerClienteFormulario();

            //Cliente.AgregarCliente(c);

            //actualizarListaCliente();
            //LimpiarFormulario();
        }

        private bool ValidarCampos()
        {
            if (String.IsNullOrWhiteSpace(txtCi.Text))
            {
                MessageBox.Show("El número de CI no puede estar vacío", "Error");
                txtCi.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío", "Error");
                txtNombre.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("La Direccion no puede estar vacía", "Error");
                txtDireccion.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("El número de telefono no puede estar vacío", "Error");
                txtTelefono.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("El email no puede estar vacío", "Error");
                txtEmail.Focus();
                return false;
            }

            return true;
        }
        private void ActualizarListaCliente()
        {
            lstCliente.DataSource = null;
            lstCliente.DataSource = Cliente.ObtenerCliente();
        }

        private Cliente ObtenerClienteFormulario()
        {
            Cliente c = new Cliente();
            c.Id = Convert.ToInt16(txtId.Text);
            c.ciCliente = txtNombre.Text;
            c.nombre = txtCi.Text;
            c.direccion = txtDireccion.Text;
            c.telefono = txtTelefono.Text;
            c.email = txtEmail.Text;

            return c;
        }
        private void LimpiarFormulario()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtCi.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int index = lstCliente.SelectedIndex;
            Cliente c = ObtenerClienteFormulario();
            Cliente.EditarCliente(index, c);
            
            LimpiarFormulario();
            actualizarListaCliente();
        }
        

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lstCliente.SelectedItems.Count == 0)
            {
                MessageBox.Show("Favor seleccione una fila");
            }
            else
            {
                Cliente cli = (Cliente)lstCliente.SelectedItem;
                Cliente.EliminarCliente(cli);
                actualizarListaCliente();
                LimpiarFormulario();
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
                txtId.Text = Convert.ToString(cli.Id);
                txtCi.Text = cli.ciCliente;
                txtNombre.Text = cli.nombre;
                txtDireccion.Text = cli.direccion;
                txtTelefono.Text = cli.telefono;
                txtEmail.Text = cli.email;
                
            }
        }
    }
}
