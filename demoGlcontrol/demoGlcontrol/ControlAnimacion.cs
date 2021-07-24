using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenTK;
namespace demoGlcontrol
{
    class ControlAnimacion
    {
        Escenario es = new Escenario();
        IObjeto v;
        Libreto x = new Libreto();
        List<Animacion> anima = new List<Animacion>();
        public Thread hilo { get; set; }
        public ControlAnimacion(Escenario esc) {
            this.es = esc;
            this.anima = x.getLibreto();
            this.hilo = new Thread(new ThreadStart(animar));
        }

        public void animar() {
            int tiempoIni = (int)DateTime.Now.TimeOfDay.TotalMilliseconds; 
            while (detener()) { //se va detener cuando todos los estados cambien
                foreach (Animacion lista in this.anima) //recorremos el json
                {
                    if (!lista.estado) //preguntamos si alguno de los objetos cambio su estado para que ya no vuelva a entrar
                    {
                        //------------------------------INICIA EL PROCESO--------------------------------------//
                        int tiempoActual = (int)DateTime.Now.TimeOfDay.TotalMilliseconds;
                        string objeto = lista.objeto; //json
                        string operacion = lista.accion;//json
                        this.v = es.getObjeto(objeto);//json
                        float[] parametros = lista.parametros;//json
                        int time = lista.tiempoTotal * 1000;//json
                        //calculos aux
                        int constate = 250;
                        int tiempoParcial = time / constate;
                        float x = parametros[0] / constate; 
                        float y = parametros[1] / constate; 
                        float z = parametros[2] / constate;
                        if (tiempoActual >= tiempoIni + lista.contadorTime) //SI EL TIEMPO AUN NO SE HA CUMPLIDO REALIZAR LA ACCION
                        {
                            switch (operacion)
                            {
                                case "mover":
                                     v.mover(new Vector3(x, y, z));
                                    break;
                                case "redimencionar":
                                    v.redimencionar(new Vector3(x, y, z));
                                    break;
                            }
                            lista.contadorTime = lista.contadorTime + tiempoParcial;
                            if (lista.contadorTime >= time)
                            {
                                lista.estado = true;
                            }
                        }
                    }
                }

            }
        }
        public bool detener() {
            foreach (Animacion lista in this.anima) {
                if (lista.estado == false) {
                    return true;
                }
            }
            return false;
        }
    }
}
