
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
        string accion;

        public frmAlquiler()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            accion = "AGREGAR";
            LimpiarFormulario();
            DesbloquearFormulario();
            txtCodigo.Focus();
        }
        private void LimpiarFormulario()
        {
            txtCodigo.Text = "";
            cboHabitacion.SelectedItem = null;
            cboCliente.SelectedItem = null;
            cboTipoReserva.SelectedItem = null;
            nudCosto.Value = 0;
            cboEstadoReserva.SelectedItem = null;
        }

        private void DesbloquearFormulario()
        {
            txtCodigo.Enabled = true;
            cboHabitacion.Enabled = true;
            cboCliente.Enabled = true;
            cboTipoReserva.Enabled = true;
            nudCosto.Enabled = true;
            cboEstadoReserva.Enabled = true;

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;

           
            btnAgregar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;

        }

        private void frmAlquiler_Load(object sender, EventArgs e)
        {
            ActualizarListaAlquileres();

            cboCliente.DataSource = Cliente.ObtenerClientes();
            cboHabitacion.DataSource = Habitacion.ObtenerHabitacion();
            cboTipoReserva.DataSource = Enum.GetValues(typeof(TipoReserva));
            cboEstadoReserva.DataSource = Enum.GetValues(typeof(EstadoReserva));

            cboCliente.SelectedItem = null;
            cboHabitacion.SelectedItem = null;
            cboTipoReserva.SelectedItem = null;
            cboEstadoReserva.SelectedItem = null;

            BloquearFormulario();

        }

        private void BloquearFormulario()
        {
            txtCodigo.Enabled = false;
            cboHabitacion.Enabled = false;
            cboCliente.Enabled = false;
            cboTipoReserva.Enabled = false;
            nudCosto.Enabled = false;
            cboEstadoReserva.Enabled = false;

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = false;


            btnAgregar.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;

        }
        private void ActualizarListaAlquileres()
        {
            lstAlquileres.DataSource = null;
            lstAlquileres.DataSource = Alquiler.ObtenerAlquileres();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (accion == "AGREGAR")
            {
                Alquiler alquiler = ObtenerDatosFormulario();

                Alquiler.AgregarAlquiler(alquiler);
            }
            else if (accion == "EDITAR")
            {
                int index = lstAlquileres.SelectedIndex;

                Alquiler.listaAlquileres[index] = ObtenerDatosFormulario();

            }
            ActualizarListaAlquileres();
            LimpiarFormulario();
            BloquearFormulario();
        }

        private Alquiler ObtenerDatosFormulario()
            {
                Alquiler alqui = new Alquiler();

            alqui.CodAlquiler = txtCodigo.Text;
            alqui.Cliente = (Cliente)cboCliente.SelectedItem;
            alqui.Habitacion = (Habitacion)cboHabitacion.SelectedItem;
            alqui.Tipo_reserva = (TipoReserva)cboTipoReserva.SelectedItem;
            alqui.Costo = (int)nudCosto.Value;
            alqui.Estado_reserva = (EstadoReserva)cboEstadoReserva.SelectedItem;

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

            if (alqui != null)
            {
                txtCodigo.Text = alqui.CodAlquiler;
                cboCliente.SelectedItem = alqui.Cliente;
                cboHabitacion.SelectedItem = alqui.Habitacion;
                cboTipoReserva.SelectedItem = alqui.Tipo_reserva;
                nudCosto.Value = (decimal)alqui.Costo;
                cboEstadoReserva.SelectedItem = alqui.Estado_reserva;

            }
        }
    }
    }

