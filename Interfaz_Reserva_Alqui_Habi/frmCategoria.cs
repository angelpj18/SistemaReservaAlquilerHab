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
        string accion;
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Categoria categ = ObtenerCatgoriaFormulario();

            Categoria.AgregarCategoria(categ);
            ActualizarListaCategoria();
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            cmbCategoria.SelectedItem = null;
        }

        private void ActualizarListaCategoria()
        {
            lstCategoria.DataSource = null;
            lstCategoria.DataSource = Categoria.ObtenerCatgoria();
        }

        private Categoria ObtenerCatgoriaFormulario()
        {
            Categoria c = new Categoria();
            c.codigo = txtDescripcion.Text;
            c.descripcion = txtDescripcion.Text;
            c.categoria = (Categoria)cmbCategoria.SelectedItem;

            return c;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lstCategoria.SelectedItems.Count == 0)
            {
                MessageBox.Show("Para eliminar debe seleccionar una fila");
            }
            else
            {
                Categoria categ = (Categoria)lstCategoria.SelectedItem;
                Categoria.EliminarCategoria(categ);
                ActualizarListaCategoria();
                LimpiarFormulario();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.lstCategoria.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleecionar una fila para modificar");
            }
            else
            {
                accion = "EDITAR";
                txtCodigo.Focus();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            ActualizarListaCategoria();
            cmbCategoria.DataSource = Enum.GetValues(typeof(CategoriaHabi));

            cmbCategoria.SelectedItem = null;

        }
    }
}
