using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SistemaReservaAlquilerHabi
{
     class Usuario
    {

        public int Id { get; set; }
        public string nombreUsu { get; set; }
        public string contrasena { get; set; }
        public string email { get; set; }

        public override string ToString()
        {
            return nombreUsu;
        }


        public static List<Usuario> listaUsuarios = new List<Usuario>();

        //Nuevo Metodo para agregar Clientes en BD
        public static void AgregarUsuario(Usuario u)
        {
            // listaHabitaciones.Add(h);
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string textoCmd = "insert into Usuario (nombre, contrasena, email)VALUES (@nombre, @contrasena, @email)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = u.ObtenerParametros(cmd);
                cmd.ExecuteNonQuery();
            }
        }

        private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean Id = false)
        {
            SqlParameter p1 = new SqlParameter("@nombre", this.nombreUsu);
            SqlParameter p2 = new SqlParameter("@contrasena", this.contrasena);
            SqlParameter p3 = new SqlParameter("@email", this.email);

            p1.SqlDbType = SqlDbType.VarChar;
            p2.SqlDbType = SqlDbType.VarChar;
            p3.SqlDbType = SqlDbType.VarChar;

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);

            if (Id == true)
            {
                cmd = ObtenerParametrosId(cmd);
            }
            return cmd;
        }

        private SqlCommand ObtenerParametrosId(SqlCommand cmd)
        {
            SqlParameter p4 = new SqlParameter("@Id", this.Id);
            p4.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p4);
            return cmd;
        }

        //Metodo para Obtener Clientes
        //public static List<Cliente> ObtenerClientes()
        //{
        //    return listaClientes;
        //}

        public static List<Usuario> ObtenerUsuario()
        {
            //return listaClientes;
            Usuario u;
            listaUsuarios.Clear();
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {

                con.Open();
                string tectoCMD = "select * from Usuario";

                SqlCommand cmd = new SqlCommand(tectoCMD, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    u = new Usuario();
                    u.Id = elLectorDeDatos.GetInt32(0);
                    u.nombreUsu = elLectorDeDatos.GetString(1);
                    u.contrasena = elLectorDeDatos.GetString(2);
                    u.email = elLectorDeDatos.GetString(3);


                    listaUsuarios.Add(u);

                }
                return listaUsuarios;
            }
        }

        //public static void EditarCliente(int indice, Cliente c)
        //{
        //    using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
        //    {
        //        con.Open();
        //        string textoCMD = "UPDATE Cliente SET ciCliente = @ciCLiente, nombre = @nombre, direccion = @direccion, telefono = @telefono, email = @email where Id = @Id";

        //        SqlCommand cmd = new SqlCommand(textoCMD, con);
        //        cmd = c.ObtenerParametros(cmd, true);

        //        cmd.ExecuteNonQuery();
        //    }
        //}

        public static void EliminarCliente(Cliente c)
        {
            //listaClientes.Remove(h);
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string SENTENCIA_SQL = "delete from Usuario where Id = @Id";

                SqlCommand cmd = new SqlCommand(SENTENCIA_SQL, con);
                SqlParameter p4 = new SqlParameter("@Id", c.Id);
                p4.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p4);

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

       

    }
}
