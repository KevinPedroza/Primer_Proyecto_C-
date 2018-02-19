using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procedimientos
{
    public class Herencia_Vehiculos : Vehiculos
    {
        private int id;
        private string marca;
        private string modelo;
        private string tipo;
        private int precio;
        private int canidad;

        public int Id1 { get => id; set => id = value; }
        public string Marca1 { get => marca; set => marca = value; }
        public string Modelo1 { get => modelo; set => modelo = value; }
        public string Tipo1 { get => tipo; set => tipo = value; }
        public int Precio1 { get => precio; set => precio = value; }
        public int Canidad { get => canidad; set => canidad = value; }
    }
}
