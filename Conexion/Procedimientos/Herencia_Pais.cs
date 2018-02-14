using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procedimientos
{
    public class Herencia_Pais
    {
        private int idpais;
        private string nombre;
        private string bandera_foto;

        public int Idpais { get => idpais; set => idpais = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Bandera_foto { get => bandera_foto; set => bandera_foto = value; }
    }
}
