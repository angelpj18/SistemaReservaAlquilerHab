
using SistemaReservaAlquilerHabi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Interfaz_Reserva_Alqui_Habi
{
    public partial class frmAlquiler : Form
    {
       public string accion;

        public frmAlquiler()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            accion = "I";
            LimpiarFormulario();
            DesbloquearFormulario();
        }
        private void LimpiarFormulario()
        {

            txtCodigo.Text = "";
            dtpFechaDesde.Value = System.DateTime.Now;
            dtpFechaHasta.Value = System.DateTime.Now;
            cboTipoAlquiler.SelectedItem = null;
            
        }

        private void DesbloquearFormulario()
        {
            dtpFechaDesde.Enabled = true;
            dtpFechaHasta.Enabled = true;
            cboTipoAlquiler.Enabled = true;

        }

        private void frmAlquiler_Load(object sender, EventArgs e)
        {

            ActualizarListaAlquileres();

            cboTipoAlquiler.DataSource = Enum.GetValues(typeof(TipoAlquiler));

            cboTipoAlquiler.SelectedItem = null;


            BloquearFormulario();

        }

        private void BloquearFormulario()
        {

            dtpFechaDesde.Enabled = false;
            dtpFechaHasta.Enabled = false;
            cboTipoAlquiler.Enabled = false;

        }
        private void ActualizarListaAlquileres()
        {
            lstAlquileres.DataSource = null;
            lstAlquileres.DataSource = Alquiler.ObtenerAlquileres();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (accion == "I")
            {
                Alquiler alquiler = ObtenerDatosFormulario();
                Alquiler.AgregarAlquiler(alquiler);
            }
            else if (accion == "E")
            {
                int index = lstAlquileres.SelectedIndex;
                Alquiler alquiler = ObtenerDatosFormulario();
                Alquiler.EditarAlquiler(index, alquiler);

            }
            ActualizarListaAlquileres();
            LimpiarFormulario();
            BloquearFormulario();
        }

        private Alquiler ObtenerDatosFormulario()
            {
            Alquiler alqui = new Alquiler();
            {
                alqui.Id = Convert.ToInt32(txtCodigo.Text);
            }
            alqui.FechaAlquilerDesde = dtpFechaDesde.Value.Date;
            alqui.FechaAlquilerHasta = dtpFechaHasta.Value.Date;
            alqui.TipoAlquiler = (TipoAlquiler)cboTipoAlquiler.SelectedItem;
            return alqui;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            accion = "EDITAR";
            DesbloquearFormulario();
            txtCodigo.Focus();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstAlquileres.SelectedItems.Count > 0)
            {
                Alquiler alqui = (Alquiler)lstAlquileres.SelectedItem;
                Alquiler.listaAlquileres.Remove(alqui);
                ActualizarListaAlquileres();
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Selecione una lista para eliminar");
            }
        }

        private void lstAlquileres_Click(object sender, EventArgs e)
        {
            Alquiler alqui = (Alquiler)lstAlquileres.SelectedItem;
            txtCodigo.Text = Convert.ToString(alqui.Id);
            dtpFechaDesde.Value = alqui.FechaAlquilerDesde;
            dtpFechaHasta.Value = alqui.FechaAlquilerHasta;
        }
    }
    }

