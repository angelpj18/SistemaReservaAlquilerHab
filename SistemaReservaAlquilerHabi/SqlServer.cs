using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace SistemaReservaAlquilerHabi
{
    public class SqlServer
    {
        public static string CADENA_CONEXION = ConfigurationManager.ConnectionStrings["SqlServer"].ConnectionString;
    }
}
