using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoGlcontrol
{
    class Escenario
    {
        Dictionary<string, Objeto> listaDibujos;

        public Escenario()
        {
            this.listaDibujos = new Dictionary<string, Objeto>();
        }
        public void agregarDibujo(string nombre, Objeto dibujo)
        {
            this.listaDibujos.Add(nombre, dibujo);
        }
        public void mover(Vector3 direccion)
        {

            foreach (Objeto dibujos in listaDibujos.Values)
            {
                dibujos.mover(direccion);
            }

        }
        public Objeto getObjeto(string key)
        {
            if (listaDibujos.ContainsKey(key))
            {
                return listaDibujos[key];
            }
            else
            {
                return listaDibujos["chair"];
            }


        }
        public void dibujarEscenario()
        {
            foreach (Objeto dibujos in listaDibujos.Values)
            {
                dibujos.dibujar();
            }
        }
        public void rotar(Vector4 rotaciones)
        {
            foreach (Objeto dibujos in listaDibujos.Values)
            {
                dibujos.rotar(rotaciones);
            }

        }
        public void redimencionar(Vector3 escala)
        {
            foreach (Objeto dibujos in listaDibujos.Values)
            {
                dibujos.redimencionar(escala);
            }

        }

        
    }
}
