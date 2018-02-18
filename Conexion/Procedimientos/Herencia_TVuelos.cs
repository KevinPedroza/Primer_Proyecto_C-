using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procedimientos
{
    public class Herencia_TVuelos : Tarifa_Vuelos
    {
        private int id;
        private int idruta;
        private int precio;

        public int Idi { get => id; set => id = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Idruta1 { get => idruta; set => idruta = value; }
    }
}
