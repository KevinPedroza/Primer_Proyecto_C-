using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procedimientos
{
    public class Hoteles
    {
        private int id;
        private string nombre;
        private string foto;
        private int pais;
        private int lugar;
        private int habitaciones;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Foto { get => foto; set => foto = value; }
        public int Pais { get => pais; set => pais = value; }
        public int Lugar { get => lugar; set => lugar = value; }
        public int Habitaciones { get => habitaciones; set => habitaciones = value; }
    }
}
