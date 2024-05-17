using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_10
{
    public delegate void MetodosComInt(int carga);
    public interface IBateria
    {
        //Definição de Propriedades
        int carga { get; set; }

        //Definição de Método (comportamentos da interface)
        void Carrega();
        void Descarrega();

        //Definição de eventos
        event MetodosComInt cargaalterada;
    }
}
