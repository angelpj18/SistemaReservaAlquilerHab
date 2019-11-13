using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        Doble,
        Premium,
        Presidencial
        
    }
    public class Habitacion
    {
        public string detalle { get; set; }
        public string descripcion { get; set; }
        public CategoriaH categoria { get; set; }
        public Piso piso { get; set; }
        public EstadoHab habilitado { get; set; }


        public static List<Habitacion> listaHabitaciones = new List<Habitacion>();



        public static void AgregarHabitacion(Habitacion h)
        {
            listaHabitaciones.Add(h);
        }


        public static void EliminaHabitacion(Habitacion h)
        {
            listaHabitaciones.Remove(h);
        }


        public static void EditarHabitacion(Habitacion h, int indice)
        {
            Habitacion.listaHabitaciones[indice] = h;
        }


        public static List<Habitacion> ObtenerHabitacion()
        {
            return listaHabitaciones;
        }


        public override string ToString()
        {
            return this.detalle;
        }
    }
}
