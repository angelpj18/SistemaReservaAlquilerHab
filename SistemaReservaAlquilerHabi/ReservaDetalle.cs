﻿using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaReservaAlquilerHabi;

namespace SistemaReservaAlquilerHabi
{
    public class ReservaDetalle
    {

        public Habitacion habitacion { get; set; }

        //public double Cantidad { get; set; }

        public string Cantidad { get; set; }

        public double precioTotal { get; set; }
        public double cantPersonas { get; set; }
    }
}