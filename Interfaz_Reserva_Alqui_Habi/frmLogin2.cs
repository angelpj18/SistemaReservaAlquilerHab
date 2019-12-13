using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaReservaAlquilerHabi;

namespace Interfaz_Reserva_Alqui_Habi
{
    public partial class frmLogin2 : Form
    {
        public frmLogin2()
        {
            InitializeComponent();
        }

       
        public void login()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
                {
                   con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Usuario WHERE nombreUsu='" + txtUsuario.Text + "' AND contrasena='" + txtContrasena.Text + "'",con))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            string nombre = dr["nombreUsu"].ToString();
                            MessageBox.Show("¡¡Bienvenido '" + nombre + "'!!.");
                            frmLogin2 form2 = new frmLogin2();
                            form2.Close();
                            frmMenu form = new frmMenu();
                            form.Show();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No puede acceder a la BD; REVISE SU CONEXION", "Alerta",
                                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnSingIn_Click(object sender, EventArgs e)
        {
            login();
        }

        
    }
}
