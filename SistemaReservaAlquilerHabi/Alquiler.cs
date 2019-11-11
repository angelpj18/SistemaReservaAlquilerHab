using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReservaAlquilerHabi
{
    public enum TipoReserva
    {
        Alquiler,
        Habitacion
    }

    public enum EstadoReserva
    {
        Cancelada,
        Reservada,
        EnEspera,
    }
    public class Alquiler
    {
        public string CodAlquiler { get; set; }
        public Cliente Cliente { get; set; }
        public Habitacion Habitacion { get; set; }
       
        public TipoReserva Tipo_reserva { get; set; }
        public int Costo { get; set; }

        public EstadoReserva Estado_reserva { get; set; }

        public static List<Alquiler> listaAlquileres = new List<Alquiler>();

        public static void AgregarAlquiler(Alquiler a)
        {
            listaAlquileres.Add(a);
        }

        public static void EditarAlquiler(Alquiler a, int indice)
        {
            Alquiler.listaAlquileres[indice] = a;

        }
        public static void EliminarAlquiler(Alquiler alquiler)
        {
            listaAlquileres.Remove(alquiler);
        }

        public static List<Alquiler> ObtenerAlquileres()
        {
            return listaAlquileres;
        }

        public override string ToString()
        {
            return this.CodAlquiler;
        }
    }

}
