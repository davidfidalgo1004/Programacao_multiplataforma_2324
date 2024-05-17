using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class ModelDepartamento
    {
        public string Designacao { get; private set; }
        public string NDocentes { get; private set; }

        public ModelDepartamento(string designacao, string ndocentes) 
        { 
            Designacao= designacao;
            NDocentes= ndocentes;
        }

    }
}
