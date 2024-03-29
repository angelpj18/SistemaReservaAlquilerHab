﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReservaAlquilerHabi
{
    public class tipoHabitacion
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double precioTipoHab { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }


        public static List<tipoHabitacion> listaTipoHab = new List<tipoHabitacion>();



        public static void AgregarTipoHab(tipoHabitacion tH)
        {
            //listaProveedores.Add(p);
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open(); //Abrimos la conex con la BD
                string textoCmd = "insert into TipoHabitacion (Id, Descripcion, precioTipoHab) VALUES (@Id, @Descripcion, @precioTipoHab)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);

                //PARAMETROS
                SqlParameter p1 = new SqlParameter("@Id", tH.Id);
                SqlParameter p2 = new SqlParameter("@Descripcion", tH.Descripcion);
                SqlParameter p3 = new SqlParameter("@precioTipoHab", tH.precioTipoHab);


                //Le decimos a los parametros de que tipo de datos son

                p1.SqlDbType = SqlDbType.Int;
                p2.SqlDbType = SqlDbType.VarChar;
                p3.SqlDbType = SqlDbType.Float;

                //Agragamos los parametros al command
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);


                cmd.ExecuteNonQuery();
            }

        }


        public static void EliminarTipoHabitacion(tipoHabitacion t)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string SENTENCIA_SQL = "delete from TipoHabitacion where Id = @Id";

                SqlCommand cmd = new SqlCommand(SENTENCIA_SQL, con);
                SqlParameter p3 = new SqlParameter("@Id", t.Id);
                p3.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p3);

                cmd.ExecuteNonQuery();
            }
        }

        public static void EditarTipoHab(int index, tipoHabitacion th)
        {
            //listaProveedores[index] = p;
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "UPDATE TipoHabitacion SET Descripcion = @Descripcion, precioTipoHab = @precioTipoHabitacion where Id = @Id";

                SqlCommand cmd = new SqlCommand(textoCMD, con);

                //DEFINICION DE PARAMETROS
                SqlParameter p1 = new SqlParameter("@Descripcion", th.Descripcion);
                SqlParameter p2 = new SqlParameter("@precioTipoHabitacion", th.precioTipoHab);
                SqlParameter p3 = new SqlParameter("@Id", th.Id);

                //Le decimos a los parametros de que tipo de datos son
                p1.SqlDbType = SqlDbType.VarChar;
                p2.SqlDbType = SqlDbType.Float;
                p3.SqlDbType = SqlDbType.Int;

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);


                cmd.ExecuteNonQuery();
            }

        }
        public static List<tipoHabitacion> ObtenerTipos()
        {

            tipoHabitacion tipoH;
            listaTipoHab.Clear();
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string textoCMD = "Select * from TipoHabitacion";

                SqlCommand cmd = new SqlCommand(textoCMD, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    tipoH = new tipoHabitacion();
                    tipoH.Id = elLectorDeDatos.GetInt32(0);
                    tipoH.Descripcion = elLectorDeDatos.GetString(1);
                    tipoH.precioTipoHab = elLectorDeDatos.GetDouble(2);

                    listaTipoHab.Add(tipoH);
                }


                return listaTipoHab;
            }
        }

        public static tipoHabitacion ObtenerTipoH(int id)
        {
            tipoHabitacion tipoH = null;

            if (listaTipoHab.Count == 0)
            {
                tipoHabitacion.ObtenerTipos();
            }

            foreach (tipoHabitacion th in listaTipoHab)
            {
                if (th.Id == id)
                {
                    tipoH = th;
                    break;
                }
            }

            return tipoH;
        }
    }
    }
