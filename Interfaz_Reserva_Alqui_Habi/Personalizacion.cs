using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_Reserva_Alqui_Habi
{
    class Personalizacion
    {
        public static void BorderRedondoButton(Button b)
        {
            Rectangle r = new Rectangle(0, 0, b.Width, b.Height);
            System.Drawing.Drawing2D.GraphicsPath button = new System.Drawing.Drawing2D.GraphicsPath();
            int d = 10;
            button.AddArc(r.X, r.Y, d, d, 180, 90);
            button.AddArc(r.X + r.Width - d, r.Y, d, d, 280, 90);
            button.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            button.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            b.Region = new Region(button);


        }
    }
}
