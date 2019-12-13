
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

        Alquiler alquiler;
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


            if (ValidarCampos())
            {
                alquiler.Id = Convert.ToInt32(txtCodigo.Text);
             
                alquiler.FechaAlquilerDesde = dtpFechaDesde.Value.Date;
                alquiler.FechaAlquilerHasta = dtpFechaDesde.Value.Date;
                alquiler.TipoAlquiler = (TipoAlquiler)cboTipoAlquiler.SelectedItem;
                alquiler.reserva_id = (Reserva)cboReserva.SelectedItem;
   
                Alquiler.AgregarAlquiler(alquiler);
                MessageBox.Show("El Alquiler ha sido guardado con éxito");
                LimpiarFormulario();

                dtgDetalleAlquiler.DataSource = null;
                dtpFechaDesde.Value = System.DateTime.Now;
                dtpFechaHasta.Value = System.DateTime.Now;
             

                cboTipoAlquiler.SelectedItem = null;
                cboReserva.SelectedItem = null;
      
             
                alquiler = new Alquiler();
            }


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AlquilerDetalle ad = new AlquilerDetalle();
            ad.Id = Convert.ToInt32(txtCodigo.Text);
            ad.precioCategoria = txtPrecioCat.Text;
            ad.precioTipoHabitacion = txtPrecioTipo.Text;
            alquiler.detalle_alquiler.Add(ad);
            ActualizarDataGrid();

            LimpiarFormulario();
        }


        private void ActualizarDataGrid()
        {
            dtgDetalleAlquiler.DataSource = null;
            dtgDetalleAlquiler.DataSource = alquiler.detalle_alquiler;

        }


        private Alquiler ObtenerFormularioAlquiler()
        {

            Alquiler alquiler = new Alquiler();
   
            alquiler.Id = Convert.ToInt32(txtCodigo.Text);
            alquiler.FechaAlquilerDesde= dtpFechaDesde.Value.Date;
            alquiler.FechaAlquilerHasta = dtpFechaHasta.Value.Date;
            alquiler.TipoAlquiler = (TipoAlquiler)cboTipoAlquiler.SelectedItem;
           
            alquiler.reserva_id = (Reserva)cboReserva.SelectedItem;

            return alquiler;
        }

        private void frmAlquiler_Load(object sender, EventArgs e)
        {
            dtgDetalleAlquiler.AutoGenerateColumns = true;

            cboReserva.DataSource = Reserva.ObtenerReservas();
          
            cboReserva.SelectedItem = null;
       
            alquiler = new Alquiler();
        }



        private bool ValidarCampos()
        {
            if (String.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("El codigo debe escribirse", "Error");
                txtCodigo.Focus();
                return false;
            }


            var fechaIncorrecta = new DateTime(2100, 1, 1);

            if (dtpFechaDesde.Value < DateTime.Now || dtpFechaHasta.Value > DateTime.Parse("01/01/2100") || dtpFechaHasta.Value > fechaIncorrecta)
            {
                MessageBox.Show("Por favor ingrese una fecha correcta", "Error");
                dtpFechaHasta.Focus();
                return false;
            }

            var fechaIncorrectaDos = new DateTime(2100, 1, 1);

            if (dtpFechaDesde.Value < DateTime.Now || dtpFechaDesde.Value > DateTime.Parse("01/01/2100") || dtpFechaDesde.Value > fechaIncorrectaDos)
            {
                MessageBox.Show("Por favor ingrese una Fecha de Inicio correcta", "Error");
                dtpFechaDesde.Focus();
                return false;
            }

            var fechaIncorrectaTres = new DateTime(2100, 1, 1);

            if (dtpFechaHasta.Value < DateTime.Now || dtpFechaHasta.Value > DateTime.Parse("01/01/2100") || dtpFechaHasta.Value > fechaIncorrectaTres)
            {
                MessageBox.Show("Por favor ingrese una Fecha de Fin correcta", "Error");
                dtpFechaHasta.Focus();
                return false;
            }

            if (cboReserva.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione un codigo", "Error");
                cboReserva.Focus();
                return false;
            }


            return true;
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //cierra
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    }
}

