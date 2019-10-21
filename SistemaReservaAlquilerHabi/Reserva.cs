using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReservaAlquilerHabi
{
    public class Reserva
    {
        public int codReserva { get; set; }
        public string detalle { get; set; }
        public string estado { get; set; }
        public Cliente cliente { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaReserva { get; set; }
        public DateTime fechaFin { get; set; }
        public string sucursal { get; set; }
        public string tipoReserva { get; set; }


        public static List<Reserva> listaReservas = new List<Reserva>();

        public static List<Reserva> ObtenerReserva()
        {
            return listaReservas;
        }
        public static void AgregarReserva(Reserva r)
        {
            listaReservas.Add(r);
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
