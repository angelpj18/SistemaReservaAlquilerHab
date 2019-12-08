using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReservaAlquilerHabi
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double precioC { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }


        public static List<Categoria> listaCategoria = new List<Categoria>();



        public static void AgregarCategoria(Categoria c)
        {
            //listaProveedores.Add(p);
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open(); //Abrimos la conex con la BD
                string textoCmd = "insert into Categoria (Descripcion, precioC) VALUES (@Descripcion, @precioCategoria)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);

                //PARAMETROS
                SqlParameter p1 = new SqlParameter("@Descripcion", c.Descripcion);
                SqlParameter p2 = new SqlParameter("@precioCategoria", c.precioC);


                //Le decimos a los parametros de que tipo de datos son
                p1.SqlDbType = SqlDbType.VarChar;
                p2.SqlDbType = SqlDbType.VarChar;


                //Agragamos los parametros al command
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);


                cmd.ExecuteNonQuery();
            }

        }


        public static void EliminarCategoria(Categoria c)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string SENTENCIA_SQL = "delete from Categoria where Id = @Id";

                SqlCommand cmd = new SqlCommand(SENTENCIA_SQL, con);
                SqlParameter p3 = new SqlParameter("@Id", c.Id);
                p3.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p3);

                cmd.ExecuteNonQuery();
            }
        }

        public static void EditarCategoria(int index, Categoria c)
        {
            //listaProveedores[index] = p;
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "UPDATE Categoria SET Descripcion = @Descripcion, precioC = @precioCategoria where Id = @Id";

                SqlCommand cmd = new SqlCommand(textoCMD, con);

                //DEFINICION DE PARAMETROS
                SqlParameter p1 = new SqlParameter("@Descripcion", c.Descripcion);
                SqlParameter p2 = new SqlParameter("@precioCategoria", c.precioC);
                SqlParameter p3 = new SqlParameter("@Id", c.Id);

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
        public static List<Categoria> ObtenerCategorias()
        {

            Categoria categoria;
            listaCategoria.Clear();
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string textoCMD = "Select * from Categoria";

                SqlCommand cmd = new SqlCommand(textoCMD, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    categoria = new Categoria();
                    categoria.Id = elLectorDeDatos.GetInt32(0);
                    categoria.Descripcion = elLectorDeDatos.GetString(1);
                    categoria.precioC = elLectorDeDatos.GetDouble(2);

                    listaCategoria.Add(categoria);
                }


                return listaCategoria;
            }
        }

        public static Categoria ObtenerCategoria(int id)
        {
            Categoria categoria = null;

            if (listaCategoria.Count == 0)
            {
                Categoria.ObtenerCategorias();
            }

            foreach (Categoria c in listaCategoria)
            {
                if (c.Id == id)
                {
                    categoria = c;
                    break;
                }
            }

            return categoria;
        }
    }
}
