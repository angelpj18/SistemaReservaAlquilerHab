﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Interfaz_Reserva_Alqui_Habi
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmMenuNuevo_Load(object sender, EventArgs e)
        {
            Personalizacion.BorderRedondoButton(btnCliente);
            Personalizacion.BorderRedondoButton(btnHabitacion);
            Personalizacion.BorderRedondoButton(btnPiso);
            Personalizacion.BorderRedondoButton(btnSucursal);
            Personalizacion.BorderRedondoButton(btnProcesos);
            Personalizacion.BorderRedondoButton(btnProceso1);
            Personalizacion.BorderRedondoButton(btnProceso2);
            Personalizacion.BorderRedondoButton(btnTipoHabitacion);
            Personalizacion.BorderRedondoButton(btnCategoria);

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

       

        private void btnProcesos_Click(object sender, EventArgs e)
        {
            SubMenu.Visible = true;
            

        }

        private void btnProceso1_Click(object sender, EventArgs e)
        {
            SubMenu.Visible = false;
            frmReserva frmRe = new frmReserva();
            frmRe.Show();

        }

        private void btnProceso2_Click(object sender, EventArgs e)
        {
            SubMenu.Visible = false;
            frmAlquiler frmAl = new frmAlquiler();
            frmAl.Show();

        }

        private void SubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHabitacion_Click(object sender, EventArgs e)
        {
            frmHabitacion frmHabi = new frmHabitacion();
            frmHabi.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmCliente frmCli = new frmCliente();
            frmCli.Show();
        }

        private void btnPiso_Click(object sender, EventArgs e)
        {
            frmPiso frmPi = new frmPiso();
            frmPi.Show();
        }

        private void btnSucursal_Click(object sender, EventArgs e)
        {
            frmSucursal frmSu = new frmSucursal();
            frmSu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCategoria frmCat = new frmCategoria();
            frmCat.Show();
        }

        private void lblAcercaDe_Click(object sender, EventArgs e)
        {
            frmAcercaDe frmAcer = new frmAcercaDe();
            frmAcer.Show();
        }

        private void btnTipoHabitacion_Click(object sender, EventArgs e)
        {
            frmTipoHabi frmTipoH = new frmTipoHabi();
            frmTipoH.Show();
        }
    }
}
