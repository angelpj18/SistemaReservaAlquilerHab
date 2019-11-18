using SistemaReservaAlquilerHabi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReservaAlquilerHabi
{
    public enum TipoAlquiler
    {
        Alquiler,
        Habitacion
    }


    public class Alquiler
    {
        public int Id { get; set; }
        public DateTime FechaAlquilerDesde { get; set; }
        public DateTime FechaAlquilerHasta { get; set; }
        public TipoAlquiler TipoAlquiler { get; set; }

        public static List<Alquiler> listaAlquileres = new List<Alquiler>();

        public static void AgregarAlquiler(Alquiler a)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string textoCmd = "insert into Alquiler (FechaAlquilerDesde, FechaAlquilerHasta, TipoAlquiler)VALUES (@FechaAlquilerDesde, @FechaAlquilerHasta,@TipoAlquiler)";

                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = a.ObtenerParametros(cmd);
                cmd.ExecuteNonQuery();
            }
        }

        public static void EditarAlquiler(int indice, Alquiler a)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "UPDATE Alquiler SET FechaAlquilerDesde = @FechaAlquilerDesde, FechaAlquilerHasta = @FechaAlquilerHasta, TipoAlquiler = @TipoAlquiler where Id = @Id";

                SqlCommand cmd = new SqlCommand(textoCMD, con);
                cmd = a.ObtenerParametros(cmd, true);

                cmd.ExecuteNonQuery();
            }

        }



        public static void EliminarAlquiler(Alquiler alquiler)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string SENTENCIA_SQL = "delete from Alquiler where Id = @Id";

                SqlCommand cmd = new SqlCommand(SENTENCIA_SQL, con);
                SqlParameter p1 = new SqlParameter("@Id", alquiler.Id);
                p1.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p1);

                cmd.ExecuteNonQuery();
                
                con.Close();
            }
        }

        public static List<Alquiler> ObtenerAlquileres()
        {
            Alquiler alquiler;

            listaAlquileres.Clear();

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string tectoCMD = "select * from Alquiler";
                SqlCommand cmd = new SqlCommand(tectoCMD, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    alquiler = new Alquiler();
                    alquiler.Id = elLectorDeDatos.GetInt32(0);
                    alquiler.FechaAlquilerDesde = elLectorDeDatos.GetDateTime(1);
                    alquiler.FechaAlquilerHasta = elLectorDeDatos.GetDateTime(2);
                    alquiler.TipoAlquiler = (TipoAlquiler)elLectorDeDatos.GetInt32(3);


                    listaAlquileres.Add(alquiler);

                }
            }

            return listaAlquileres;
        }


        private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean Id = false)
        {

            SqlParameter p1 = new SqlParameter("@FechaAlquilerDesde", this.FechaAlquilerDesde);
            SqlParameter p2 = new SqlParameter("@FechaAlquilerHasta", this.FechaAlquilerHasta);
            SqlParameter p3 = new SqlParameter("@TipoAlquiler", this.TipoAlquiler);


            p1.SqlDbType = SqlDbType.DateTime;
            p2.SqlDbType = SqlDbType.DateTime;
            p3.SqlDbType = SqlDbType.Int;


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
    }

}