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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void habitacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHabitacion frmHabi = new frmHabitacion();
            frmHabi.Show();
        }

        private void alquilerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAlquiler frmAlq = new frmAlquiler();
            frmAlq.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoria frmCateg = new frmCategoria();
            frmCateg.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente frmCli = new frmCliente();
            frmCli.Show();
        }

        private void pisoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPiso frmpi = new frmPiso();
            frmpi.Show();
        }
    }
}
