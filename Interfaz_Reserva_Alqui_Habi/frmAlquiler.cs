
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

        public frmAlquiler()
        {
            InitializeComponent();
        }
      
        private void LimpiarFormulario()
        {
         txtCodigo.Text = "";
         cboTipoAlquiler.SelectedItem = null;
         dtpFechaDesde.Value = System.DateTime.Now;
         dtpFechaHasta.Value = System.DateTime.Now;

            //Para el detalle
         cmbHabitacion.SelectedItem = null;
            txtPrecioCat.Text = "";
            txtPrecioTipo.Text = "";

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void frmAlquiler_Load(object sender, EventArgs e)
        {

        }
    }
}

