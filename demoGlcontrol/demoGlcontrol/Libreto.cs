using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoGlcontrol
{
    class Libreto
    {
        private string _path = @"D:\Archivos\libreto.json";
        public List<Animacion> a = new List<Animacion>();
        public Libreto() {
            string listaParametrosJson = getListaParametrosJsonFile();
            serializeJsonFile(listaParametrosJson);
        }
        public List<Animacion> getLibreto()
        {
            return this.a;
        }
        public string getListaParametrosJsonFile()
        {
           
            string listaParametrosJsonFile;
            using (var reader = new StreamReader(_path))
            {
                listaParametrosJsonFile = reader.ReadToEnd();
            }

            return listaParametrosJsonFile;
        }
        public void serializeJsonFile(string listaJson) {
        this.a = JsonConvert.DeserializeObject<List<Animacion>>(listaJson);
            int constate = 250;
            foreach (Animacion lista in this.a) {
                lista.contadorTime = (lista.tiempoTotal * 1000) / constate;
            }

        }
        

    }
}
