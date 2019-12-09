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



        public static List<Alquiler> listaAlquileres = new List<Alquiler>();

        public static void AgregarAlquiler(Alquiler a)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();

                //Cabecera del Pedido
                string textoCMD = "INSERT INTO Alquiler (FechaAlquilerDesde, FechaAlquilerHasta, TipoAlquiler) output INSERTED.Id VALUES (@descripcion, @estado, @fechaInicio, @fechaReserva, @fechaFin, @cliente, @sucursal, @tipoReserva)";
                SqlCommand cmd = new SqlCommand(textoCMD, con);


                //SqlParameter p1 = new SqlParameter("@descripcion", r.descripcion);
                //SqlParameter p2 = new SqlParameter("@estado", r.estado);
                //SqlParameter p3 = new SqlParameter("@fechaInicio", r.fechaInicio);
                //SqlParameter p4 = new SqlParameter("@fechaReserva", r.fechaReserva);
                //SqlParameter p5 = new SqlParameter("@fechaFin", r.fechaFin);
                //SqlParameter p6 = new SqlParameter("@cliente", Cliente.ObtenerCliente());
                //SqlParameter p7 = new SqlParameter("@sucursal", Sucursal.ObtenerSucursal());
                //SqlParameter p8 = new SqlParameter("@tipoReserva", r.tipoReserva);

                //detalle, estado, cliente, fechaInicio, fechaReserva, fechaFin, sucursal, tipoReserva
                //p1.SqlDbType = System.Data.SqlDbType.VarChar;
                //p2.SqlDbType = System.Data.SqlDbType.VarChar;
                //p3.SqlDbType = System.Data.SqlDbType.DateTime;
                //p4.SqlDbType = System.Data.SqlDbType.DateTime;
                //p5.SqlDbType = System.Data.SqlDbType.DateTime;
                //p6.SqlDbType = System.Data.SqlDbType.Int;
                //p7.SqlDbType = System.Data.SqlDbType.Int;
                //p8.SqlDbType = System.Data.SqlDbType.VarChar;

                //cmd.Parameters.Add(p1);
                //cmd.Parameters.Add(p2);
                //cmd.Parameters.Add(p3);
                //cmd.Parameters.Add(p4);
                //cmd.Parameters.Add(p5);
                //cmd.Parameters.Add(p6);
                //cmd.Parameters.Add(p7);
                //cmd.Parameters.Add(p8);



                //int reserva_id = (int)cmd.ExecuteScalar();

                //Detalle de la Reserva
                //foreach (ReservaDetalle rd in r.detalle_reserva)
                //{
                //    string textoCMD2 = "INSERT INTO ReservaDetalle(tipoHabitacion, categoria, cantidad) VALUES (@tipoHabitacion, @categoria, @cantidad)";
                //    SqlCommand cmd2 = new SqlCommand(textoCMD2, con);

                //    //SqlParameter p9 = new SqlParameter("@Id", id_reserva);
                //    SqlParameter p9 = new SqlParameter("@id", rd.Id);//Numero de detalle
                //    SqlParameter p10 = new SqlParameter("@tipoHabitacion", tipoHabitacion.ObtenerTipos());
                //    SqlParameter p11 = new SqlParameter("@categoria", Categoria.ObtenerCategorias());
                //    SqlParameter p12 = new SqlParameter("@cantidad", rd.cantidad);

                //    cmd2.Parameters.Add(p9);
                //    cmd2.Parameters.Add(p10);
                //    cmd2.Parameters.Add(p11);
                //    cmd2.Parameters.Add(p12);


                //    cmd2.ExecuteNonQuery();
                //}
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