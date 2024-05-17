using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula7
    //1º CRIAR DELEGATE
    //2º CRIAR EVENTO
    //3º LANÇAR EVENTO
{
    public class ModelFicheiro
    {
        //Declaração de Evento
        public event MetodosSemParametros EscritaTerminada;
        public event MetodosSemParametros LeituraTerminada;
        public string Texto {  get; private set; }
        public void EscritaFicheiro(string texto, string ficheiro)
        {
            StreamWriter sw = new StreamWriter(ficheiro);
            sw.Write(texto);
            sw.Close();

            //Lançamento evento
            if (EscritaTerminada != null)
            {
                EscritaTerminada();
            }
        }

        public void LeituraFicheiro(string ficheiro) 
        {
            StreamReader sr = new StreamReader(ficheiro);
            Texto=sr.ReadToEnd();
            sr.Close();
            if (LeituraTerminada != null)
            {
                LeituraTerminada();
            }
        }

    }
}
