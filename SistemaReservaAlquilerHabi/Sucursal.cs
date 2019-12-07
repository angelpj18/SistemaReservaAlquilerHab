using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReservaAlquilerHabi
{
    public class Sucursal
    {

        public int Id { get; set; }
        public string NroSucursal { get; set; }
        public string Direccion { get; set; }

        public override string ToString()
        {
            return Direccion;
        }

        public static List<Sucursal> listaSucursal = new List<Sucursal>();



        public static void AgregarSucursal(Sucursal s)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open(); //Abrimos la conex con la BD
                string textoCmd = "insert into Sucursal (NroSucursal, Direccion) VALUES (@NroSucursal, @Direccion)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);

                //PARAMETROS
                SqlParameter p1 = new SqlParameter("@NroSucursal", s.NroSucursal);
                SqlParameter p2 = new SqlParameter("@Direccion", s.Direccion);


                //Le decimos a los parametros de que tipo de datos son
                p1.SqlDbType = SqlDbType.VarChar;
                p2.SqlDbType = SqlDbType.VarChar;


                //Agragamos los parametros al command
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);


                cmd.ExecuteNonQuery();
            }

        }


        public static void EliminarSucursal(Sucursal s)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string SENTENCIA_SQL = "delete from Sucursal where Id = @Id";

                SqlCommand cmd = new SqlCommand(SENTENCIA_SQL, con);
                SqlParameter p3 = new SqlParameter("@Id", s.Id);
                p3.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p3);

                cmd.ExecuteNonQuery();
            }
        }

        public static void EditarSucursal(int index, Sucursal s)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "UPDATE Sucursal SET NroSucursal = @NroSucursal, Direccion = @Direccion where Id = @Id";

                SqlCommand cmd = new SqlCommand(textoCMD, con);

                //DEFINICION DE PARAMETROS
                SqlParameter p1 = new SqlParameter("@NroSucursal", s.NroSucursal);
                SqlParameter p2 = new SqlParameter("@Direccion", s.Direccion);
                SqlParameter p3 = new SqlParameter("@Id", s.Id);

                //Le decimos a los parametros de que tipo de datos son
                p1.SqlDbType = SqlDbType.VarChar;
                p2.SqlDbType = SqlDbType.VarChar;
                p3.SqlDbType = SqlDbType.Int;

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);

                cmd.ExecuteNonQuery();
            }

        }
        public static List<Sucursal> ObtenerSucursal()
        {

            Sucursal sucursal;
            listaSucursal.Clear();
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string textoCMD = "Select * from Sucursal";

                SqlCommand cmd = new SqlCommand(textoCMD, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    sucursal = new Sucursal();
                    sucursal.Id = elLectorDeDatos.GetInt32(0);
                    sucursal.NroSucursal = elLectorDeDatos.GetString(1);
                    sucursal.Direccion = elLectorDeDatos.GetString(2);


                    listaSucursal.Add(sucursal);
                }


                return listaSucursal;
            }
        }

        public static Sucursal ObtenerSucursal(int id)
        {
            Sucursal sucursal = null;

            if (listaSucursal.Count == 0)
            {
                Sucursal.ObtenerSucursal();
            }

            foreach (Sucursal s in listaSucursal)
            {
                if (s.Id == id)
                {
                    sucursal = s;
                    break;
                }
            }

            return sucursal;
        }

    }
}

