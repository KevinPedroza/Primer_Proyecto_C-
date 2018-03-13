using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//this class will create the herency from prices of hotels
namespace Procedimientos
{
    public class Tarifa_Hoteles
    {
        private int id;
        private int precio;

        public int Id { get => id; set => id = value; }
        public int Precio { get => precio; set => precio = value; }
    }
}
