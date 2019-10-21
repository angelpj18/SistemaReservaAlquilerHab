using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReservaAlquilerHabi
{
    public class Piso
    {

        public string NroPiso { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }

        public static List<Piso> listaPisos = new List<Piso>();



        public static void AgregarPiso(Piso p)
        {
            listaPisos.Add(p);
        }


        public static void EliminaPiso(Piso p)
        {
            listaPisos.Remove(p);
        }


        public static void EditarPiso(Piso p, int indice)
        {
            Piso.listaPisos[indice] = p;
        }


        public static List<Piso> ObtenerPiso()
        {
            return listaPisos;
        }
    }
}
