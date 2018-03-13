using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//this class will create the herency from prices of flies
namespace Procedimientos
{
    public class Tarifa_Vuelos
    {
        private int id;
        private int idruta;
        private int precio;

        public int Id { get => id; set => id = value; }
        public int Idruta { get => idruta; set => idruta = value; }
        public int Precio { get => precio; set => precio = value; }
    }
}
