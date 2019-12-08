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
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Categoria cat = new Categoria();
                cat.descripcion = txtDescripcion.Text;
                cat.precioCategoria= txtPrecioC.Text;



                Categoria.AgregarCategoria(cat);
                LimpiarFormulario();
                ActualizarListaCategoria();

            }
        }

        private void LimpiarFormulario()
        {
            txtId.Text = " ";
           
            txtDescripcion.Text = " "; 
            txtPrecioC.Text = " "; 
        }

        private bool ValidarCampos()
        {
            if (String.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("La descripcion no puede estar vacía", "Error");
                txtDescripcion.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtPrecioC.Text))
            {
                MessageBox.Show("Debe escribir un precio", "Error");
                txtPrecioC.Focus();
                return false;
            }
            return true;
        }



        private void frmCategoria_Load(object sender, EventArgs e)
        {
            ActualizarListaCategoria();
        }

        private void ActualizarListaCategoria()
        {
            lstCategoria.DataSource = null;
            lstCategoria.DataSource = Categoria.ObtenerCategorias();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lstCategoria.SelectedItems.Count == 0)
            {
                MessageBox.Show("Para eliminar debe seleccionar una categoria");
            }
            else
            {
                Categoria categoria = (Categoria)lstCategoria.SelectedItem;
                Categoria.EliminarCategoria(categoria);
                ActualizarListaCategoria();
                LimpiarFormulario();
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int index = lstCategoria.SelectedIndex;
            Categoria c = ObtenerCatFormulario();
            Categoria.EditarCategoria(index, c);


            LimpiarFormulario();
            ActualizarListaCategoria();
        }


        private Categoria ObtenerCatFormulario()
        {
            Categoria c = new Categoria();
            c.Id = Convert.ToInt16(txtId.Text);
         
            c.descripcion = txtDescripcion.Text;
            c.precioCategoria = txtPrecioC.Text;

            return c;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void lstCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            Categoria c = (Categoria)lstCategoria.SelectedItem;

            if (c != null)
            {
                txtId.Text = Convert.ToString(c.Id);
                txtPrecioC.Text = c.precioCategoria;
                txtDescripcion.Text = c.descripcion;

            }
        }
    }
}
