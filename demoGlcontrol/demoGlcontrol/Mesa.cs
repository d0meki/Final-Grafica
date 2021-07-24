using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoGlcontrol
{
    class Mesa: Objeto
    {
        public Mesa(Vector3 posicion, float ancho, float alto, float largo)
        {
            float lar;
            if (ancho > largo)
            {
                lar = ancho;
            }
            else
            {
                lar = largo;
            }
            this.getListaPartes().Add("baseMesa", new Partes(posicion, ancho, largo, alto * 10 / 100));
            this.getListaPartes().Add("pata1", new Partes(new Vector3(posicion.X + largo * 10 / 100, posicion.Y - alto * 10 / 100, posicion.Z - ancho * 10 / 100), lar * 10 / 100, lar * 10 / 100, alto - alto * 10 / 100));
            this.getListaPartes().Add("pata2", new Partes(new Vector3(posicion.X + largo * 10 / 100, posicion.Y - alto * 10 / 100, posicion.Z - ancho + ancho * 10 / 100 + lar * 10 / 100), lar * 10 / 100, lar * 10 / 100, alto - alto * 10 / 100));
            this.getListaPartes().Add("pata3", new Partes(new Vector3(posicion.X + largo - largo * 10 / 100 - lar * 10 / 100, posicion.Y - alto * 10 / 100, posicion.Z - ancho * 10 / 100), lar * 10 / 100, lar * 10 / 100, alto - alto * 10 / 100));
            this.getListaPartes().Add("pata4", new Partes(new Vector3(posicion.X + largo - largo * 10 / 100 - lar * 10 / 100, posicion.Y - alto * 10 / 100, posicion.Z - ancho + ancho * 10 / 100 + lar * 10 / 100), lar * 10 / 100, lar * 10 / 100, alto - alto * 10 / 100));
        }
    }
}
