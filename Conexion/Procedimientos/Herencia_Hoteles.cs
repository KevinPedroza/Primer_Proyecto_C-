using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procedimientos
{
    public class Herencia_Hoteles : Hoteles
    {
        private int id;
        private string nombre;
        private string foto;
        private int pais;
        private int lugar;
        private int habitaciones;

        public int Id1 { get => id; set => id = value; }
        public string Nombre1 { get => nombre; set => nombre = value; }
        public string Foto1 { get => foto; set => foto = value; }
        public int Pais1 { get => pais; set => pais = value; }
        public int Lugar1 { get => lugar; set => lugar = value; }
        public int Habitaciones1 { get => habitaciones; set => habitaciones = value; }
    }
}
