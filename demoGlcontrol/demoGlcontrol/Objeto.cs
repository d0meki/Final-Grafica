using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;

namespace demoGlcontrol
{
    class Objeto : IObjeto
    {
        Dictionary<string, Partes> ListaDePartes;
        public Objeto()
        {
            ListaDePartes = new Dictionary<string, Partes>();
        }
        public Dictionary<string, Partes> getListaPartes()
        {
            return ListaDePartes;

        }
        public void dibujar()
        {
            foreach (Partes partes in ListaDePartes.Values)
            {
                partes.dibujar();
            }
        }

        public void mover(Vector3 direccion)
        {
            foreach (Partes dibujos in ListaDePartes.Values)
            {
                dibujos.mover(direccion);
            }
        }

        public void redimencionar(Vector3 escala)
        {
            foreach (Partes dibujos in ListaDePartes.Values)
            {
                dibujos.redimencionar(escala);
            }
        }

        public void rotar(Vector4 rotaciones)
        {
            foreach (Partes dibujos in ListaDePartes.Values)
            {
                dibujos.rotar(rotaciones);
            }
        }
        
    }
}
