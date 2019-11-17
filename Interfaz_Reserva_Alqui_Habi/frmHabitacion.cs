﻿using System;
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
    public partial class frmHabitacion : Form
    {
        string modo;
        public frmHabitacion()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            /*Habitacion habi = ObtenerHabitacionFormulario();
            Habitacion.AgregarHabitacion(habi);
            ActualizarListaHabitacion();
            LimpiarFormulario();*/


            /*if (modo == "I")
            {
                Habitacion habi = ObtenerHabitacionFormulario();
                Habitacion.AgregarHabitacion(habi);
            }
            else if (modo == "E")
            {
                int index = lstHabitacion.SelectedIndex;
                Habitacion habi = ObtenerHabitacionFormulario();
                Habitacion.EditarHabitacion(index, habi);
            }
            ActualizarListaHabitacion();
            LimpiarFormulario();*/

            Habitacion habi = new Habitacion();
            habi.descripcion = txtDescripcion.Text;
            habi.categoria = (CategoriaH)cmbCategoria.SelectedItem;
            habi.piso = (Piso)cmbPiso.SelectedItem;
            habi.habilitado = (EstadoHab)cmbCategoria.SelectedItem;


            Habitacion.AgregarHabitacion(habi);
            LimpiarFormulario();
            ActualizarListaHabitacion();

        }

        private void LimpiarFormulario()
        {
            txtNroHabi.Text = "";
            cmbCategoria.SelectedItem = null;
            cmbPiso.SelectedItem = null;
            txtDescripcion.Text = "";
        }

        private void ActualizarListaHabitacion()
        {
            lstHabitacion.DataSource = null;
            lstHabitacion.DataSource = Habitacion.ObtenerHabitacion();
        }

        private Habitacion ObtenerHabitacionFormulario()
        {
            Habitacion h = new Habitacion();
            h.descripcion = txtDescripcion.Text;
            h.categoria = (CategoriaH)cmbCategoria.SelectedItem;
            h.piso = (Piso)cmbPiso.SelectedItem;
            

            if (rdbSi.Checked)
            {
                h.habilitado = EstadoHab.Si;
            }
            else if (rdbNo.Checked)
            {
                h.habilitado = EstadoHab.No;
            }

            return h;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstHabitacion.SelectedItems.Count > 0)
            {

                Habitacion habi = (Habitacion)lstHabitacion.SelectedItem;
                Habitacion.listaHabitaciones.Remove(habi);
                ActualizarListaHabitacion();
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Para eliminar debe seleccionar una fila");
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            /*Habitacion habi = (Habitacion)lstHabitacion.SelectedItem;
            if (habi != null)
            {
                int index = lstHabitacion.SelectedIndex;
                Habitacion.listaHabitaciones[index] = ObtenerHabitacionFormulario();
                ActualizarListaHabitacion();
            }*/

            int index = lstHabitacion.SelectedIndex;
            Habitacion habi = ObtenerHabitacionFormulario();
            Habitacion.EditarHabitacion(index, habi);


            LimpiarFormulario();
            ActualizarListaHabitacion();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void lstHabitacion_Click(object sender, EventArgs e)
        {
            Habitacion habi = (Habitacion)lstHabitacion.SelectedItem;
            if (habi != null)
            {
                txtDescripcion.Text = habi.descripcion;
                cmbCategoria.SelectedItem = habi.categoria;
                cmbPiso.SelectedItem = habi.piso;              

                if (habi.habilitado == EstadoHab.Si)
                {
                    rdbSi.Checked = true;
                }
                else if (habi.habilitado == EstadoHab.No)
                {
                    rdbNo.Checked = true;
                }

            }
        }

        private void frmHabitacion_Load(object sender, EventArgs e)
        {
            ActualizarListaHabitacion();
            cmbCategoria.DataSource = Enum.GetValues(typeof(CategoriaH));
            cmbPiso.DataSource = Piso.ObtenerPiso();

            cmbCategoria.SelectedItem = null;
            cmbPiso.SelectedItem = null;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Habitacion habi = (Habitacion)lstHabitacion.SelectedItem;

            if (habi != null)
            {
                txtNroHabi.Text = Convert.ToString(habi.id);
                txtDescripcion.Text = habi.descripcion;
                //REVISAR
                cmbCategoria.SelectedItem = habi.categoria;
                cmbPiso.SelectedItem = habi.piso;

                if (habi.habilitado == EstadoHab.Si)
                {
                    rdbSi.Checked = true;
                }
                else if (habi.habilitado == EstadoHab.No)
                {
                    rdbNo.Checked = true;
                }
            }

        }
    }
}
