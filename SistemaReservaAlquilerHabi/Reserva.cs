using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReservaAlquilerHabi
{
    public class Reserva
    {


        //Tipo Reserva va a ser Enum
        public int codReserva { get; set; }        //detalle, estado, cliente, fechaInicio, fechaReserva, fechaFin, sucursal, tipoReserva
        public string detalle { get; set; }
        public string estado { get; set; }
        public Cliente cliente { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaReserva { get; set; }
        public DateTime fechaFin { get; set; }
        public string sucursal { get; set; }
        public string tipoReserva { get; set; }

        public List<ReservaDetalle> detalle_reserva = new List<ReservaDetalle>();

        public static List<Reserva> listaReservas = new List<Reserva>();


        public static void AgregarReserva(Reserva r)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
              
                string textoCMD = "INSERT INTO Reserva (detalle, estado, cliente, fechaInicio, fechaReserva, fechaFin, sucursal, tipoReserva) output INSERTED.id VALUES (@detalle, @estado, @cliente, @fechaInicio, @fechaReserva, @fechaFin, @sucursal, @tipoReserva)";
                SqlCommand cmd = new SqlCommand(textoCMD, con);

               
                SqlParameter p1 = new SqlParameter("@detalle", r.detalle);
                SqlParameter p2 = new SqlParameter("@estado", r.estado);
                SqlParameter p3 = new SqlParameter("@cliente", r.cliente.ciCliente);
                SqlParameter p4 = new SqlParameter("@fechaInicio", r.fechaInicio);
                SqlParameter p5 = new SqlParameter("@fechaReserva", r.fechaReserva);
                SqlParameter p6 = new SqlParameter("@fechaFin", r.fechaFin);
                SqlParameter p7 = new SqlParameter("@sucursal", r.sucursal);
                SqlParameter p8 = new SqlParameter("@tipoReserva", r.tipoReserva);

                //detalle, estado, cliente, fechaInicio, fechaReserva, fechaFin, sucursal, tipoReserva
                p1.SqlDbType = System.Data.SqlDbType.VarChar;
                p2.SqlDbType = System.Data.SqlDbType.VarChar;
                p3.SqlDbType = System.Data.SqlDbType.Int;
                p4.SqlDbType = System.Data.SqlDbType.DateTime;
                p5.SqlDbType = System.Data.SqlDbType.DateTime;
                p6.SqlDbType = System.Data.SqlDbType.DateTime;
                p1.SqlDbType = System.Data.SqlDbType.VarChar;
                p1.SqlDbType = System.Data.SqlDbType.VarChar;
    
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.Parameters.Add(p6);
                cmd.Parameters.Add(p7);
                cmd.Parameters.Add(p8);



                int id_reserva = (int)cmd.ExecuteScalar();

                foreach (ReservaDetalle rd in r.detalle_reserva)
                {
                    string textoCMD2 = "INSERT INTO ReservaDetalle(reserva_id, Cantidad, precioTotal, cantPersonas) VALUES (@Id, @Cantidad, @precioTotal, @cantPersonas)";
                    SqlCommand cmd2 = new SqlCommand(textoCMD2, con);

                    SqlParameter p9 = new SqlParameter("@id", id_reserva);
                    SqlParameter p10 = new SqlParameter("@Cantidad", rd.Cantidad);
                    SqlParameter p11 = new SqlParameter("@precioTotal", rd.precioTotal);
                    SqlParameter p12 = new SqlParameter("@cantPersonas", rd.precioTotal);

                    cmd2.Parameters.Add(p9);
                    cmd2.Parameters.Add(p10);
                    cmd2.Parameters.Add(p11);
                    cmd2.Parameters.Add(p12);


                    cmd2.ExecuteNonQuery();
                }
            }

        }

        public static void EditarReserva(Reserva r, int indice)
        {
            Reserva.listaReservas[indice] = r;

        }
        public static void EliminarReserva(Reserva reser)
        {
            listaReservas.Remove(reser);
        }

        public static List<Reserva> ObtenerReservas()
        {
            return listaReservas;
        }

        public override string ToString()
        {
            return this.detalle;
        }


    }
}
