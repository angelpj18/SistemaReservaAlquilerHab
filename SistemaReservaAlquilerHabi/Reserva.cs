using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaReservaAlquilerHabi;
using System.Data;

namespace SistemaReservaAlquilerHabi
{
    public enum Estado
    {
        Activa,
        Inactiva
    }

    public enum TipoReserva
    {
        PorAgencia,
        PorRecepcion
    }
    public class Reserva
    {
        //Tipo Reserva va a ser Enum
        public int Id { get; set; }        
        public string descripcion { get; set; }
        public Estado estado { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaReserva { get; set; }
        public DateTime fechaFin { get; set; }
        public Cliente cliente { get; set; }
        public Sucursal sucursal { get; set; }
        public TipoReserva tipoReserva { get; set; }

        public List<ReservaDetalle> detalle_reserva = new List<ReservaDetalle>();

        public static List<Reserva> listaReservas = new List<Reserva>();


        public static void AgregarReserva(Reserva r)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                
                //Cabecera del Pedido
                string textoCMD = "INSERT INTO Reserva (descripcion, estado, fechaInicio, fechaReserva, fechaFin, cliente, sucursal, tipoReserva) output INSERTED.Id VALUES (@descripcion, @estado, @fechaInicio, @fechaReserva, @fechaFin, @cliente, @sucursal, @tipoReserva)";
                SqlCommand cmd = new SqlCommand(textoCMD, con);

               
                SqlParameter p1 = new SqlParameter("@descripcion", r.descripcion);
                SqlParameter p2 = new SqlParameter("@estado", r.estado);
                SqlParameter p3 = new SqlParameter("@fechaInicio", r.fechaInicio);
                SqlParameter p4 = new SqlParameter("@fechaReserva", r.fechaReserva);
                SqlParameter p5 = new SqlParameter("@fechaFin", r.fechaFin);
                SqlParameter p6 = new SqlParameter("@cliente", Cliente.ObtenerCliente());
                SqlParameter p7 = new SqlParameter("@sucursal", Sucursal.ObtenerSucursal());
                SqlParameter p8 = new SqlParameter("@tipoReserva", r.tipoReserva);

                //detalle, estado, cliente, fechaInicio, fechaReserva, fechaFin, sucursal, tipoReserva
                p1.SqlDbType = System.Data.SqlDbType.VarChar;
                p2.SqlDbType = System.Data.SqlDbType.VarChar;
                p3.SqlDbType = System.Data.SqlDbType.DateTime;
                p4.SqlDbType = System.Data.SqlDbType.DateTime;
                p5.SqlDbType = System.Data.SqlDbType.DateTime;
                p6.SqlDbType = System.Data.SqlDbType.Int;
                p7.SqlDbType = System.Data.SqlDbType.Int;
                p8.SqlDbType = System.Data.SqlDbType.VarChar;
    
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.Parameters.Add(p6);
                cmd.Parameters.Add(p7);
                cmd.Parameters.Add(p8);



                //int reserva_id = (int)cmd.ExecuteScalar();

                //Detalle de la Reserva
                foreach (ReservaDetalle rd in r.detalle_reserva)
                {
                    string textoCMD2 = "INSERT INTO ReservaDetalle(tipoHabitacion, categoria, cantidad) VALUES (@tipoHabitacion, @categoria, @cantidad)";
                    SqlCommand cmd2 = new SqlCommand(textoCMD2, con);

                    //SqlParameter p9 = new SqlParameter("@Id", id_reserva);
                    SqlParameter p9 = new SqlParameter("@id", rd.Id);//Numero de detalle
                    SqlParameter p10 = new SqlParameter("@tipoHabitacion", tipoHabitacion.ObtenerTipos());
                    SqlParameter p11 = new SqlParameter("@categoria", Categoria.ObtenerCategorias());
                    SqlParameter p12 = new SqlParameter("@cantidad", rd.cantidad);

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

        public static DataTable ObtenerReservasPendientes()
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                //string textoCmd = "SELECT det.id, ped.fecha_arribo, pro.RazonSocial, det.cantidad, car.nombre FROM pedido ped inner join proveedor pro on ped.proveedor = pro.id inner join Pedido_Detalle det on det.pedido_id = ped.id inner join carne car on car.id = det.carne where det.recibido = 0";
                //SqlCommand cmd = new SqlCommand(textoCmd, con);
                DataTable tabla = new DataTable();
                //tabla.Load(cmd.ExecuteReader());
                return tabla;
            }

        }

        public static void ConfirmarReservas(List<int> listaIds)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                foreach (int id in listaIds)
                {
              //      string textoCmd = @"UPDATE Pedido_Detalle SET recibido = 1 where id = @id";
                   //SqlCommand cmd = new SqlCommand(textoCmd, con);
                   // SqlParameter p1 = new SqlParameter("@id", id);
                   // p1.SqlDbType = SqlDbType.Int;
                   // cmd.Parameters.Add(p1);
                   // cmd.ExecuteNonQuery();
                }

            }
        }


        public override string ToString()
        {
            return this.cliente.nombre;
        }


    }
}
