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

        public frmReserva()
        {
            InitializeComponent();
        }
        
        private void LimpiarFormulario()
        {
          //  nudReserva.Value = 0;
            txtDescripcion.Text = "";
            txtEstado.Text = "";
            cboCliente.SelectedItem = null;
            dtpFechaReserva.Value = DateTime.Now;
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now;
            cboSucursal.SelectedItem = null;
            txtTipoReserva.Text = "";

            //Para el detalle
            cmbHabitacion.SelectedItem = null;
            txtCantidad.Text = "";
            txtCantPersonas.Text = "";
           

        }
    

        private Reserva ObtenerFormularioReserva()
        {

            Reserva reserva = new Reserva();
     //       reserva.codReserva = (int)nudReserva.Value;
            reserva.descripcion = txtDescripcion.Text;
            reserva.tipoReserva = txtTipoReserva.Text;
            reserva.fechaReserva = dtpFechaReserva.Value.Date;
            reserva.fechaInicio = dtpFechaInicio.Value.Date;
            reserva.fechaFin = dtpFechaFin.Value.Date;
            reserva.cliente = (SistemaReservaAlquilerHabi.Cliente)cboCliente.SelectedItem;
            reserva.sucursal = (Sucursal)cboSucursal.SelectedItem;

            return reserva;
        }
      
        private void ActualizarDataGrid()
        {
            dtgDetalleReserva.DataSource = null;
            dtgDetalleReserva.DataSource = reserva.detalle_reserva;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ReservaDetalle rd = new ReservaDetalle();
            //rd.Cantidad = Convert.ToDouble(txtCantidad.Text);
            rd.Cantidad = txtCantidad.Text;
           //rd.Cantidad = Convert.ToDouble(txtCantidad.Text);

            rd.cantPersonas = Convert.ToDouble(txtCantPersonas.Text);
         
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
            if (ValidarCampos())
            {
                reserva.descripcion = txtDescripcion.Text;
                reserva.estado = txtEstado.Text;
                reserva.cliente = (Cliente)cboCliente.SelectedItem;
                reserva.fechaInicio = dtpFechaFin.Value.Date;
                reserva.fechaReserva = dtpFechaFin.Value.Date;
                reserva.fechaFin = dtpFechaFin.Value.Date;

                reserva.sucursal = (Sucursal)cboSucursal.SelectedItem;
                reserva.tipoReserva = txtTipoReserva.Text;


                Reserva.AgregarReserva(reserva);
                MessageBox.Show("La Reserva ha sido guardado con éxito");
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


        private bool ValidarCampos()
        {
            if (String.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("La descripción no puede estar vacía", "Error");
                txtDescripcion.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtEstado.Text))
            {
                MessageBox.Show("El estado no puede estar vacía", "Error");
                txtEstado.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtTipoReserva.Text))
            {
                MessageBox.Show("Debe describir el Tipo de Reseva", "Error");
                txtTipoReserva.Focus();
                return false;
            }


            var fechaIncorrecta = new DateTime(2100, 1, 1);

            if (dtpFechaReserva.Value < DateTime.Now || dtpFechaReserva.Value > DateTime.Parse("01/01/2100") || dtpFechaReserva.Value > fechaIncorrecta)
            {
                MessageBox.Show("Por favor ingrese una fecha correcta", "Error");
                dtpFechaReserva.Focus();
                return false;
            }

            var fechaIncorrectaDos = new DateTime(2100, 1, 1);

            if (dtpFechaInicio.Value < DateTime.Now || dtpFechaInicio.Value > DateTime.Parse("01/01/2100") || dtpFechaInicio.Value > fechaIncorrectaDos)
            {
                MessageBox.Show("Por favor ingrese una Fecha de Inicio correcta", "Error");
                dtpFechaInicio.Focus();
                return false;
            }

            var fechaIncorrectaTres = new DateTime(2100, 1, 1);

            if (dtpFechaFin.Value < DateTime.Now || dtpFechaFin.Value > DateTime.Parse("01/01/2100") || dtpFechaFin.Value > fechaIncorrectaTres)
            {
                MessageBox.Show("Por favor ingrese una Fecha de Fin correcta", "Error");
                dtpFechaFin.Focus();
                return false;
            }

            if (cboCliente.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione un Cliente", "Error");
                cboCliente.Focus();
                return false;
            }


            if (cboSucursal.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione una Sucursal", "Error");
                cboCliente.Focus();
                return false;
            }

            if (cmbHabitacion.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione una Habitación", "Error");
                cmbHabitacion.Focus();
                return false;
            }


            if (String.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("La Cantidad no puede estar vacía", "Error");
                txtCantidad.Focus();
                return false;
            }


            if (String.IsNullOrWhiteSpace(txtCantPersonas.Text))
            {
                MessageBox.Show("La Cantidad de Personas no puede estar vacía", "Error");
                txtCantPersonas.Focus();
                return false;
            }

          

            return true;
        }


        private void frmReserva_Load_1(object sender, EventArgs e)
        {
            dtgDetalleReserva.AutoGenerateColumns = true;

            cboCliente.DataSource = Cliente.ObtenerCliente();
            cmbHabitacion.DataSource = Habitacion.ObtenerHabitacion();
            cboSucursal.DataSource = Sucursal.ObtenerSucursal();

            cboCliente.SelectedItem = null;
            cmbHabitacion.SelectedItem = null;
            cboSucursal.SelectedItem = null;

            reserva = new Reserva();
        }
    }
}
