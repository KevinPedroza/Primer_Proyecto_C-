using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procedimientos
{
    public class Herencia_Aeropuerto : Aeropuerto
    {
        public Herencia_Aeropuerto(int id, string nombre, string localidad, string iata) : base(id, nombre, localidad, iata)
        {
        }
    }
}
