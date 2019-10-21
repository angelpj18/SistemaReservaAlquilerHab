using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReservaAlquilerHabi
{
    public class Cliente
    {
        public string ciCliente { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }


        public static List<Cliente> listaClientes = new List<Cliente>();

        //Metodo para Obtener Clientes
        public static List<Cliente> ObtenerClientes()
        {
            return listaClientes;
        }

        //Metodo para Agregar Clientes

        public static void AgregarCliente(Cliente c)
        {
            listaClientes.Add(c);
        }

        public static void EliminarClientes(Cliente c)
        {
            listaClientes.Remove(c);
        }

        public static void EditarCliente(Cliente c, int indice)
        {

            Cliente.listaClientes[indice] = c;
        }
    }
}
