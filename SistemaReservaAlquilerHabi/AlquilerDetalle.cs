using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReservaAlquilerHabi
{
    public class AlquilerDetalle
    {
        public int Id { get; set; }
        public Habitacion habitacion { get; set; }

        public string precioCategoria { get; set; }
        public string precioTipoHabitacion { get; set; }

    }
}
