using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReservaAlquilerHabi
{
    public enum CategoriaHabi
    {
        Individual,
        Doble,
        Matrimonial,
        King,
        Presidencial
    
    }
    public class Categoria
    {
        public int codigo { get; set; }
        public string descripcion { get; set; }
        public Categoria categoria { get; set; }

        public static List<Categoria> listaCategorias = new List<Categoria>();


        public static void AgregarCategoria(Categoria c)
        {
            listaCategorias.Add(c);
        }


        public static void EliminarCategoria(Categoria c)
        {
            listaCategorias.Add(c);
        }

        public static void EditarCategoria(Categoria c, int indice)
        {
            Categoria.listaCategorias[indice] = c;
        }

        public static List<Categoria> ObtenerCatgoria()
        {
            return listaCategorias;
        }

        public override string ToString()
        {
            return descripcion;
        }

    }
}
