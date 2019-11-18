using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReservaAlquilerHabi
{
    public class Cliente
    {
        public int Id { get; set; }
        public string ciCliente { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }

        public override string ToString()
        {
            return nombre;
        }


        public static List<Cliente> listaClientes = new List<Cliente>();

        //Nuevo Metodo para agregar Clientes en BD
        public static void AgregarCliente(Cliente c)
        {
            // listaHabitaciones.Add(h);
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string textoCmd = "insert into Cliente (ciCliente, nombre, direccion, telefono, email)VALUES (@ciCliente,@nombre, @direccion, @telefono, @email)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = c.ObtenerParametros(cmd);
                cmd.ExecuteNonQuery();
            }
        }

        private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean Id = false)
        {
            SqlParameter p1 = new SqlParameter("@ciCliente", this.ciCliente);
            SqlParameter p2 = new SqlParameter("@nombre", this.nombre);
            SqlParameter p3 = new SqlParameter("@direccion", this.direccion);
            SqlParameter p4 = new SqlParameter("@telefono", this.telefono);
            SqlParameter p5 = new SqlParameter("@email", this.email);

            p1.SqlDbType = SqlDbType.VarChar;
            p2.SqlDbType = SqlDbType.VarChar;
            p3.SqlDbType = SqlDbType.VarChar;
            p4.SqlDbType = SqlDbType.VarChar;
            p5.SqlDbType = SqlDbType.VarChar;

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);

            if (Id == true)
            {
                cmd = ObtenerParametrosId(cmd);
            }
            return cmd;
        }

        private SqlCommand ObtenerParametrosId(SqlCommand cmd)
        {
            SqlParameter p6 = new SqlParameter("@Id", this.Id);
            p6.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p6);
            return cmd;
        }
        
        //Metodo para Obtener Clientes
        //public static List<Cliente> ObtenerClientes()
        //{
        //    return listaClientes;
        //}

        public static List<Cliente> ObtenerCliente()
        {
            //return listaClientes;
            Cliente cli;
            listaClientes.Clear();
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {

                con.Open();
                string tectoCMD = "select * from Cliente";

                SqlCommand cmd = new SqlCommand(tectoCMD, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    cli = new Cliente();
                    cli.Id = elLectorDeDatos.GetInt32(0);
                    cli.ciCliente = elLectorDeDatos.GetString(1);
                    cli.nombre = elLectorDeDatos.GetString(2);
                    cli.direccion = elLectorDeDatos.GetString(3);
                    cli.telefono = elLectorDeDatos.GetString(4);
                    cli.email = elLectorDeDatos.GetString(5);

                   
                    listaClientes.Add(cli);

                }
                return listaClientes;
            }
        }

        public static void EditarCliente(int indice, Cliente c)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "UPDATE Cliente SET ciCliente = @ciCLiente, nombre = @nombre, direccion = @direccion, telefono = @telefono, email = @email where Id = @Id";

                SqlCommand cmd = new SqlCommand(textoCMD, con);
                cmd = c.ObtenerParametros(cmd, true);

                cmd.ExecuteNonQuery();
            }
        }

        public static void EliminarCliente(Cliente c)
        {
            //listaClientes.Remove(h);
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string SENTENCIA_SQL = "delete from Cliente where Id = @Id";

                SqlCommand cmd = new SqlCommand(SENTENCIA_SQL, con);
                SqlParameter p6 = new SqlParameter("@Id", c.Id);
                p6.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p6);

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

       
    }
}
