﻿
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
            if (ValidarCampos())
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
        }

        private bool ValidarCampos()
        {
            if (cboTipoAlquiler.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione un Tipo de Alquiler", "Error");
                cboTipoAlquiler.Focus();
                return false;
            }

            var fechaIncorrecta = new DateTime(2100, 1, 1);
            if (dtpFechaDesde.Value < DateTime.Now || dtpFechaDesde.Value > DateTime.Parse("01/01/2100") || dtpFechaDesde.Value > fechaIncorrecta)
            {
                MessageBox.Show("Por favor ingrese una fecha correcta", "Error");
                dtpFechaDesde.Focus();
                return false;
            }

            var fechaIncorrectaDos = new DateTime(2100, 1, 1);
            if (dtpFechaHasta.Value < DateTime.Now || dtpFechaHasta.Value > DateTime.Parse("01/01/2100") || dtpFechaHasta.Value > fechaIncorrectaDos)
            {
                MessageBox.Show("Por favor ingrese una fecha correcta", "Error");
                dtpFechaHasta.Focus();
                return false;
            }          

            return true;
        }


        private Alquiler ObtenerDatosFormulario()
            {
            Alquiler alqui = new Alquiler();
            if (!string.IsNullOrEmpty(txtCodigo.Text))
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
            ;
            Alquiler alquiler = (Alquiler)lstAlquileres.SelectedItem;
            if (alquiler != null)
            {
                accion = "EDITAR";
                DesbloquearFormulario();
            }
            else
            {
                MessageBox.Show("Seleccione un Item");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //if (lstAlquileres.SelectedItems.Count > 0)
            //{
            //    Alquiler alqui = (Alquiler)lstAlquileres.SelectedItem;
            //    Alquiler.listaAlquileres.Remove(alqui);
            //    ActualizarListaAlquileres();
            //    LimpiarFormulario();
            //}
            //else
            //{
            //    MessageBox.Show("Selecione una lista para eliminar");
            //}

            Alquiler alquiler = (Alquiler)lstAlquileres.SelectedItem;
            if (alquiler != null)
            {
                Alquiler.EliminarAlquiler(alquiler);
                ActualizarListaAlquileres();
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Favor seleccionar una lista para eliminar");
            }
        }

        private void lstAlquileres_Click(object sender, EventArgs e)
        {
            Alquiler alqui = (Alquiler)lstAlquileres.SelectedItem;
            txtCodigo.Text = Convert.ToString(alqui.Id);
            cboTipoAlquiler.SelectedItem = alqui.TipoAlquiler;
            dtpFechaDesde.Value = alqui.FechaAlquilerDesde;
            dtpFechaHasta.Value = alqui.FechaAlquilerHasta;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
    }

