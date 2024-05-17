using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula6
{
    public delegate void MetodosComString(string str);
    public class ModelNotas
    {
        //Definição das estruturas de dados do Model
        public List<string> ListaNotas { get; set; }
        //Definição do evento associado
        public event MetodosComString NotaAdicionada;
        public ModelNotas() { 
            //Inicialização da estrutura de dados do Model
            ListaNotas = new List<string>();
        }
        public void Adiciona(string nota)
        {
            //Adiciona nova nota à lista (estrutura de dados)
            ListaNotas.Add(nota);

            //Verifica se evento está programado (se tem metodos associados)
            if (NotaAdicionada != null)
            {
                //Lançamento do evento (Notificação)
                NotaAdicionada(nota);
            }
        }
    }
}
