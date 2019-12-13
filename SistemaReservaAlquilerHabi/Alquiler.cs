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
        ConReserva,
        SinReserva
    }
    

    public class Alquiler
    {
        public int Id { get; set; }
        public DateTime FechaAlquilerDesde { get; set; }
        public DateTime FechaAlquilerHasta { get; set; }
        public TipoAlquiler TipoAlquiler { get; set; }
        public Reserva reserva_id { get; set; }


        public List<AlquilerDetalle> detalle_alquiler = new List<AlquilerDetalle>();

        public static List<Alquiler> listaAlquileres = new List<Alquiler>();

        public static void AgregarAlquiler(Alquiler a)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();

                //Cabecera del Pedido
                string textoCMD = "INSERT INTO Alquiler (FechaAlquilerDesde, FechaAlquilerHasta, TipoAlquiler) output INSERTED.Id VALUES (@descripcion, @estado, @fechaInicio, @fechaReserva, @fechaFin, @cliente, @sucursal, @tipoReserva)";
                SqlCommand cmd = new SqlCommand(textoCMD, con);


                SqlParameter p1 = new SqlParameter("@FechaAlquilerDesde", a.FechaAlquilerDesde);
                SqlParameter p2 = new SqlParameter("@FechaAlquilerHasta", a.FechaAlquilerHasta);
                SqlParameter p3 = new SqlParameter("@TipoAlquiler", a.TipoAlquiler);
                SqlParameter p4 = new SqlParameter("@reserva_id", a.reserva_id);
               
                p1.SqlDbType = System.Data.SqlDbType.DateTime;
                p2.SqlDbType = System.Data.SqlDbType.DateTime;
                p3.SqlDbType = System.Data.SqlDbType.VarChar;
                p4.SqlDbType = System.Data.SqlDbType.Int;
               
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
          

              //  int reserva_id = (int)cmd.ExecuteScalar();
         
                foreach (AlquilerDetalle ad in a.detalle_alquiler)
                {
                   string textoCMD2 = "INSERT INTO AlquilerDetalle(id, habitacion ,precioCategoria , precioTipoHabitacion, precioTipoHabitacion, alquiler_id) VALUES (@id, @habitacion, @precioCategoria, @precioTipoHabitacion, @alquiler_id)";
                  SqlCommand cmd2 = new SqlCommand(textoCMD2, con);

               // SqlParameter p5 = new SqlParameter("@Id", id_reserva);
                 SqlParameter p5 = new SqlParameter("@id", ad.Id);//Numero de detalle
                 SqlParameter p6 = new SqlParameter("@habitacion", Habitacion.ObtenerHabitacion());
                 SqlParameter p7 = new SqlParameter("@precioCategoria",ad.precioCategoria);
                 SqlParameter p8 = new SqlParameter("@precioTipoHabitacion", ad.precioTipoHabitacion);
                 SqlParameter p9 = new SqlParameter("@alquiler_id", ad.alquiler_id);

                   cmd2.Parameters.Add(p5);
                    cmd2.Parameters.Add(p6);
                    cmd2.Parameters.Add(p7);
                    cmd2.Parameters.Add(p8);
                    cmd2.Parameters.Add(p9);

                    cmd2.ExecuteNonQuery();
                }
            }
        }

        public static void EditarAlquiler(int indice, Alquiler a)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "UPDATE Alquiler SET FechaAlquilerDesde = @FechaAlquilerDesde, FechaAlquilerHasta = @FechaAlquilerHasta, TipoAlquiler = @TipoAlquiler, reserva_id = @reserva_id   where Id = @Id";

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
  
            return listaAlquileres;
        }


        private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean Id = false)
        {

            SqlParameter p1 = new SqlParameter("@FechaAlquilerDesde", this.FechaAlquilerDesde);
            SqlParameter p2 = new SqlParameter("@FechaAlquilerHasta", this.FechaAlquilerHasta);
            SqlParameter p3 = new SqlParameter("@TipoAlquiler", this.TipoAlquiler);
            SqlParameter p4 = new SqlParameter("@reserva_id", this.reserva_id);


            p1.SqlDbType = SqlDbType.DateTime;
            p2.SqlDbType = SqlDbType.DateTime;
            p3.SqlDbType = SqlDbType.VarChar;
            p4.SqlDbType = SqlDbType.Int;

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

            SqlParameter p5 = new SqlParameter("@Id", this.Id);
            p5.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p5);
            return cmd;
        }
    }

}