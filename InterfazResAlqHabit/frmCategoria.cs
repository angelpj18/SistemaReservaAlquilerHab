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

namespace InterfazResAlqHabit
{
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }



        private void LimpiarFormulario()
        {
            nudCodigo.Value = 0;
            txtDescripcion.Text = ""; ;
        }

        private void ActualizarListaCategoria()
        {
            lstCategoria.DataSource = null;
            lstCategoria.DataSource = Categoria.ObtenerCatgoria();
        }

        private Categoria ObtenerCategoriaFormulario()
        {
            Categoria c = new Categoria();
            c.descripcion = txtDescripcion.Text;
            c.codigo = Convert.ToInt32(nudCodigo.Value);


            return c;
        }


 

        private void lstCategoria_Click(object sender, EventArgs e)
        {
            Categoria categ = (Categoria)lstCategoria.SelectedItem;
            if (categ != null)
            {
                nudCodigo.Value = categ.codigo;
                txtDescripcion.Text = categ.descripcion;
                cmbCategoria.SelectedItem = categ.categoria;

            }
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            ActualizarListaCategoria();
            cmbCategoria.DataSource = Enum.GetValues(typeof(CategoriaHabi));

            cmbCategoria.SelectedItem = null;
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            Categoria cate = ObtenerCategoriaFormulario();

            Categoria.AgregarCategoria(cate);
            ActualizarListaCategoria();
            LimpiarFormulario();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (lstCategoria.SelectedItems.Count > 0)
            {

                Categoria categ = (Categoria)lstCategoria.SelectedItem;
                Categoria.listaCategorias.Remove(categ);
                ActualizarListaCategoria();
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Para eliminar debe seleccionar una fila");
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            Categoria categ = (Categoria)lstCategoria.SelectedItem;
            if (categ != null)
            {
                int index = lstCategoria.SelectedIndex;
                Categoria.listaCategorias[index] = ObtenerCategoriaFormulario();
                ActualizarListaCategoria();
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    }
}
