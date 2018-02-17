using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procedimientos
{
    public class Herencia_Rutas : Rutas
    {
        private int id1;
        private string origen;
        private string destino;
        private string duracion1;

        public int Id1 { get => id1; set => id1 = value; }
        public string Origen { get => origen; set => origen = value; }
        public string Destino { get => destino; set => destino = value; }
        public string Duracion1 { get => duracion1; set => duracion1 = value; }
    }
}
