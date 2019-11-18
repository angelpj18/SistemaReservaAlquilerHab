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
        Reserva reserva;
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

            //Para el detalle
            cmbHabitacion.SelectedItem = null;
            txtCantidad.Text = "";
            txtCantPersonas.Text = "";
            txtPrecio.Text = "";

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
            dtgDetalleReserva.AutoGenerateColumns = true;

            cboCliente.DataSource = Cliente.ObtenerCliente();
            cmbHabitacion.DataSource = Habitacion.ObtenerHabitacion();

            cboCliente.SelectedItem = null;
            cmbHabitacion.SelectedItem = null;
            reserva = new Reserva();

        }

        private void ActualizarDataGrid()
        {
            dtgDetalleReserva.DataSource = null;
            dtgDetalleReserva.DataSource = reserva.detalle_reserva;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ReservaDetalle rd = new ReservaDetalle();
            rd.Cantidad = Convert.ToDouble(txtCantidad.Text);
            rd.cantPersonas = Convert.ToDouble(txtCantPersonas.Text);
            rd.precioTotal = Convert.ToDouble(txtCantidad.Text);
            rd.habitacion = (Habitacion)cmbHabitacion.SelectedItem;
            reserva.detalle_reserva.Add(rd);
            ActualizarDataGrid();

            LimpiarFormulario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ReservaDetalle rd = (ReservaDetalle)dtgDetalleReserva.CurrentRow.DataBoundItem;
            reserva.detalle_reserva.Remove(rd);
            ActualizarDataGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            reserva.detalle = txtDetalle.Text;
            reserva.estado = txtEstado.Text;
            reserva.cliente = (Cliente)cboCliente.SelectedItem;
            reserva.fechaFin = dtpFechaFin.Value.Date;
            reserva.fechaInicio = dtpFechaFin.Value.Date;
            reserva.fechaReserva = dtpFechaFin.Value.Date;
            reserva.sucursal= txtSuc.Text;
            reserva.tipoReserva = txtTipoReserva.Text;


            Reserva.AgregarReserva(reserva);
            MessageBox.Show("El pedido ha sido guardado con éxito");
            LimpiarFormulario();
            dtgDetalleReserva.DataSource = null;
            dtpFechaReserva.Value = System.DateTime.Now;
            dtpFechaInicio.Value = System.DateTime.Now;
            dtpFechaFin.Value = System.DateTime.Now;
            cboCliente.SelectedItem = null;
            cmbHabitacion.SelectedItem = null;
            reserva = new Reserva();
        }
    }
}
