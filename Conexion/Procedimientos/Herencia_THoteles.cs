using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//this method will have the attributes from the class herency_hotels
namespace Procedimientos
{
    public class Herencia_THoletes : Rutas
    {
        private int id;
        private int precio;

        public int Idi { get => id; set => id = value; }
        public int Precio { get => precio; set => precio = value; }
    }
}
