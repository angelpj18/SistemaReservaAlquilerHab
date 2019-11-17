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
    public partial class frmReserva : Form
    {
        string boton;
        public frmReserva()
        {
            InitializeComponent();
        }

      

        private void LimpiarFormulario()
        {
            nudReserva.Value = 0;
            txtDetalle.Text = "";
            txtEstado.Text = "";
            cboCliente.SelectedItem = null;
            dtpFechaReserva.Value = DateTime.Now;
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now;
            txtSuc.Text = "";
            txtTipoReserva.Text = "";
        }
    

        private Reserva ObtenerFormularioReserva()
        {

            Reserva reserva = new Reserva();
            reserva.codReserva = (int)nudReserva.Value;
            reserva.detalle = txtDetalle.Text;
            reserva.sucursal = txtDetalle.Text;
            reserva.tipoReserva = txtTipoReserva.Text;
            reserva.fechaReserva = dtpFechaReserva.Value.Date;
            reserva.fechaInicio = dtpFechaInicio.Value.Date;
            reserva.fechaFin = dtpFechaFin.Value.Date;
            reserva.cliente = (SistemaReservaAlquilerHabi.Cliente)cboCliente.SelectedItem;

            return reserva;
        }
      

      

        private void frmReserva_Load(object sender, EventArgs e)
        {
            ActualizarReservas();

            cboCliente.DataSource = SistemaReservaAlquilerHabi.Cliente.ObtenerCliente();

            cboCliente.SelectedItem = null;

        }

        private void ActualizarReservas()
        {
            lstReserva.DataSource = null;
            lstReserva.DataSource = Reserva.ObtenerReserva();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Reserva re = ObtenerFormularioReserva();

            Reserva.AgregarReserva(re);
            ActualizarReservas();
            LimpiarFormulario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstReserva.SelectedItems.Count > 0)
            {
                Reserva re = (Reserva)lstReserva.SelectedItem;
                Reserva.listaReservas.Remove(re);
                ActualizarReservas();
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Favor seleccionar de la lista para eliminar");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Reserva re = (Reserva)lstReserva.SelectedItem;
            if (re != null)
            {
                int index = lstReserva.SelectedIndex;
                Reserva.listaReservas[index] = ObtenerFormularioReserva();
                ActualizarReservas();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            LimpiarFormulario();
        }
    }
}
