using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procedimientos
{
    public class Aeropuerto
    {
        public int id;
        public string nombre;
        public string localidad;
        public string iata;

        public Aeropuerto(int ide,string nombree,string localidad2,string iata2)
        {
            ide = id;
            nombree = nombre;
            localidad2 = localidad;
            iata2 = iata;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public string Iata { get => iata; set => iata = value; }
    }
}
