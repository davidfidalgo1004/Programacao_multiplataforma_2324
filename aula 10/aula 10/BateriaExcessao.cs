using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_10
{
    public class BateriaExcessao: ApplicationException
    {
        public BateriaExcessao(string msg): base(msg) 
        {
            
        }   
    }
}
