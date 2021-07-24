using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoGlcontrol
{
    class Silla:Objeto
    {
        protected float ancho;
        protected float alto;
        protected float largo;
        protected Vector3 pos;
        public Silla(Vector3 posicion, float ancho, float alto, float largo)
        {
            this.pos = posicion;
            this.ancho = ancho;
            this.alto = alto;
            this.largo = largo;

            float lar;
            if (this.ancho > this.largo)
            {
                lar = ancho;
            }
            else
            {
                lar = largo;
            }
            //-------------------------partes de la Silla relativo--------------------------------

            
            this.getListaPartes().Add("asiento", new Partes(pos, ancho, largo, alto * 5 / 100));
            this.getListaPartes().Add("espaldar", new Partes(new Vector3(pos.X, pos.Y, pos.Z - ancho + ancho * 10 / 100), ancho * 10 / 100, largo, -alto * 50 / 100));
            this.getListaPartes().Add("pata1", new Partes(new Vector3(pos.X + largo * 10 / 100, pos.Y - alto * 5 / 100, pos.Z - ancho * 10 / 100), lar * 15 / 100, lar * 15 / 100, alto * 45 / 100 - alto * 5 / 100));
            this.getListaPartes().Add("pata2", new Partes(new Vector3(pos.X + largo * 10 / 100, pos.Y - alto * 5 / 100, pos.Z - ancho + ancho * 10 / 100 + lar * 15 / 100), lar * 15 / 100, lar * 15 / 100, alto * 45 / 100 - alto * 5 / 100));
            this.getListaPartes().Add("pata3", new Partes(new Vector3(pos.X + largo - largo * 10 / 100 - lar * 15 / 100, pos.Y - alto * 5 / 100, pos.Z - ancho * 10 / 100), lar * 15 / 100, lar * 15 / 100, alto * 45 / 100 - alto * 5 / 100));
            this.getListaPartes().Add("pata4", new Partes(new Vector3(pos.X + largo - largo * 10 / 100 - lar * 15 / 100, pos.Y - alto * 5 / 100, pos.Z - ancho + ancho * 10 / 100 + lar * 15 / 100), lar * 15 / 100, lar * 15 / 100, alto * 45 / 100 - alto * 5 / 100));

        }
    }
}
