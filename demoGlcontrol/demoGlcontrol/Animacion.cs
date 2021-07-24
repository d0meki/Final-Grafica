using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoGlcontrol
{
    class Animacion
    {
        public string objeto { get; set; }
        public string accion { get; set; }
        public bool estado { get; set; }
        public int tiempoTotal { get; set; }
        public float[] parametros { get; set; }
        public int contadorTime { get; set; }
        public Animacion() {

        }

    }
}
