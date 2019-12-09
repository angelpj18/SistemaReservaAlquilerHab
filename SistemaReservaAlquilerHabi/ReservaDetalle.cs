using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaReservaAlquilerHabi;

namespace SistemaReservaAlquilerHabi
{
    public class ReservaDetalle
    {

        public int Id { get; set; }
        public tipoHabitacion tipoHabitacion { get; set; }
        public Categoria categoria { get; set; }

        public string cantidad { get; set; }

        
        
    }
}