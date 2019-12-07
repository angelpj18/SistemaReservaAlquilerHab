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


        //Conexion de angel en el app config
         //<add name = "SqlServer" connectionString="Data Source = (localdb)\SERVER; 
         //                   Initial Catalog = ReservaAlquiler;
       // integrated security = true;" providerName="System.Data.SqlClient"/>
    }
}
