using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SistemaReservaAlquilerHabi
{
    public class Piso
    {
        public int Id { get; set; }
        public string NroPiso { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }

        public static List<Piso> listaPisos = new List<Piso>();



        public static void AgregarPiso(Piso p)
        {
             //listaProveedores.Add(p);
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open(); //Abrimos la conex con la BD
                string textoCmd = "insert into Piso (NroPiso, Descripcion) VALUES (@NroPiso, @Descripcion)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);

                //PARAMETROS
                SqlParameter p1 = new SqlParameter("@NroPiso", p.NroPiso);
                SqlParameter p2 = new SqlParameter("@Descripcion", p.Descripcion);
               

                //Le decimos a los parametros de que tipo de datos son
                p1.SqlDbType = SqlDbType.VarChar;
                p2.SqlDbType = SqlDbType.VarChar;
               

                //Agragamos los parametros al command
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
               

                cmd.ExecuteNonQuery();
            }
            
        }


        public static void EliminaPiso(Piso p)
        {
            
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string SENTENCIA_SQL = "delete from Piso where Id = @Id";

                SqlCommand cmd = new SqlCommand(SENTENCIA_SQL, con);
                SqlParameter p3 = new SqlParameter("@Id", p.Id);
                p3.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p3);

                cmd.ExecuteNonQuery();
            }
        }

        public static void EditarPiso(int index, Piso p)
        {
             //listaProveedores[index] = p;
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "UPDATE Piso SET NroPiso = @NroPiso, Descripcion = @Descripcion where Id = @Id";

                SqlCommand cmd = new SqlCommand(textoCMD, con);

                //DEFINICION DE PARAMETROS
                SqlParameter p1 = new SqlParameter("@NroPiso", p.NroPiso);
                SqlParameter p2 = new SqlParameter("@Descripcion", p.Descripcion);
                SqlParameter p3 = new SqlParameter("@Id", p.Id);

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
        public static List<Piso> ObtenerPisos()
        {

            Piso piso;
            listaPisos.Clear();
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string textoCMD = "Select * from Piso";

                SqlCommand cmd = new SqlCommand(textoCMD, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    piso = new Piso();
                    piso.Id = elLectorDeDatos.GetInt32(0);
                    piso.NroPiso = elLectorDeDatos.GetString(1);
                    piso.Descripcion = elLectorDeDatos.GetString(2);
                    

                    listaPisos.Add(piso);
                }

                
            return listaPisos;
        }
        }

        public static Piso ObtenerPiso(int id)
        {
            Piso piso = null;

            if (listaPisos.Count == 0)
            {
                Piso.ObtenerPisos();
            }

            foreach (Piso p in listaPisos)
            {
                if (p.Id == id)
                {
                    piso = p;
                    break;
                }
            }

            return piso;
        }

    }
}