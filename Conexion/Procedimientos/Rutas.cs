using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procedimientos
{
    public class Rutas
    {
        public int id;
        public string porigen;
        public string pdestino;
        public string duracion;

        public int Id { get => id; set => id = value; }
        public string Porigen { get => porigen; set => porigen = value; }
        public string Pdestino { get => pdestino; set => pdestino = value; }
        public string Duracion { get => duracion; set => duracion = value; }

    }
}
