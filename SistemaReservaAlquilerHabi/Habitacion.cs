using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SistemaReservaAlquilerHabi;

namespace SistemaReservaAlquilerHabi
{
    public enum EstadoHab
    {
        Si,
        No
    }
    public enum CategoriaH
    {
        Individual,
        Estandar,
        Doble,
        Premium,
        Presidencial
        
    }
    public class Habitacion
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public CategoriaH categoria { get; set; }
        public Piso piso { get; set; }
        public EstadoHab habilitado { get; set; }


        public static List<Habitacion> listaHabitaciones = new List<Habitacion>();



        public static void AgregarHabitacion(Habitacion h)
        {
            // listaHabitaciones.Add(h);
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string textoCmd = "INSERT INTO Habitacion (descripcion, categoria, piso, habilitado)VALUES (@descripcion, @categoria, @piso, @habilitado)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = h.ObtenerParametros(cmd);
                cmd.ExecuteNonQuery();
            }
        }


        private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean id = false)
        {
            SqlParameter p1 = new SqlParameter("@descripcion", this.descripcion);
            SqlParameter p2 = new SqlParameter("@categoria", this.categoria);
            SqlParameter p3 = new SqlParameter("@piso", this.piso.NroPiso);
            SqlParameter p4 = new SqlParameter("@habilitado", this.habilitado);

            p1.SqlDbType = SqlDbType.VarChar;
            p2.SqlDbType = SqlDbType.Int;
            p3.SqlDbType = SqlDbType.Int;
            p4.SqlDbType = SqlDbType.Int;

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);       

            if (id == true)
            {
                cmd = ObtenerParametrosId(cmd);
            }
            return cmd;


        }



        private SqlCommand ObtenerParametrosId(SqlCommand cmd)
        {
            SqlParameter p5 = new SqlParameter("@id", this.id);
            p5.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p5);
            return cmd;
        }




        public static void EliminaHabitacion(Habitacion h)
        {
            //listaHabitaciones.Remove(h);
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string SENTENCIA_SQL = "delete from Habitacion where id = @id";

                SqlCommand cmd = new SqlCommand(SENTENCIA_SQL, con);
                SqlParameter p1 = new SqlParameter("@id", h.id);
                p1.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p1);

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }



        public static void EditarHabitacion(int indice, Habitacion h)
        {
            //Habitacion.listaHabitaciones[indice] = h;
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "UPDATE Habitacion SET descripcion = @descripcion, categoria = @categoria, piso = @piso, habilitado = @habilitado where id = @id";

                SqlCommand cmd = new SqlCommand(textoCMD, con);
                cmd = h.ObtenerParametros(cmd, true);

                cmd.ExecuteNonQuery();
            }
        }



        public static List<Habitacion> ObtenerHabitacion()
        {
            //return listaHabitaciones;
            Habitacion habi;

            listaHabitaciones.Clear();

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string tectoCMD = "select * from Habitacion";
                SqlCommand cmd = new SqlCommand(tectoCMD, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    habi = new Habitacion();
                    habi.id = elLectorDeDatos.GetInt32(0);
                    habi.descripcion = elLectorDeDatos.GetString(1);
                    habi.categoria = (CategoriaH)elLectorDeDatos.GetInt32(2);
                    habi.piso = Piso.ObtenerPiso(elLectorDeDatos.GetInt32(3));
                    habi.habilitado = (EstadoHab)elLectorDeDatos.GetInt32(4);
                 

                    listaHabitaciones.Add(habi);

                }
            }

            return listaHabitaciones;
        }


        public override string ToString()
        {
            return this.descripcion;
        }
    }
}
