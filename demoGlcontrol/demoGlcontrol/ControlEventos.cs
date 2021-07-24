using OpenTK;
using OpenTK.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace demoGlcontrol
{
    class ControlEventos
    {
        
        Escenario es = new Escenario();
        IObjeto v;
        public ControlEventos(Escenario esc, string seleccionado)
        {
            if (seleccionado == "Escenario")
            {
                this.es = esc;
            }
            else {
                this.v = esc.getObjeto(seleccionado);
            }
        }
        public void eventosTeclado(KeyboardState entrada)
        {
            if (entrada.IsKeyDown(Key.A)) {
                this.v.mover(new Vector3(-0.1f,0,0));
            }
            if (entrada.IsKeyDown(Key.D))
            {
                this.v.mover(new Vector3(0.1f, 0, 0));
            }
            if (entrada.IsKeyDown(Key.W))
            {
                this.v.mover(new Vector3(0, 0.1f, 0));
            }
            if (entrada.IsKeyDown(Key.S))
            {
                this.v.mover(new Vector3(0, -0.1f, 0));
            }
        }
        public void eventosTecladoEscenario(KeyboardState entrada)
        {
            if (entrada.IsKeyDown(Key.Left))
            {
                this.es.mover(new Vector3(-0.1f, 0, 0));
            }
            if (entrada.IsKeyDown(Key.Right))
            {
                this.es.mover(new Vector3(0.1f, 0, 0));
            }
            if (entrada.IsKeyDown(Key.Up))
            {
                this.es.mover(new Vector3(0, 0.1f, 0));
            }
            if (entrada.IsKeyDown(Key.Down))
            {
                this.es.mover(new Vector3(0, -0.1f, 0));
            }
        }
    }
}
