using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WpfApp1
{
    public class ModelEsscola: IEnumerable
    {
        public string Escola { get; private set; }
        public List<ModelDepartamento> Lista { get; private set; }

        public event MetodosSemParametros InicializacaoTerminada;
        public ModelEsscola()
        {
            Lista=new List<ModelDepartamento>();
        }
        public void Inicializacao()
        {
            Escola = "Escola de Ciências e Tecnologia";
            Lista.Add(new ModelDepartamento("Departamento de Engenharias", "60"));
            Lista.Add(new ModelDepartamento("Departamento de Fisica", "45"));
            Lista.Add(new ModelDepartamento("Departamento de Matemática", "90"));
            if(InicializacaoTerminada!=null) { InicializacaoTerminada(); }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i=0; i<Lista.Count; i++)
            {
                yield return Lista[i];
            }
        }
        public string ObterDocentes(int op)
        {
            return Lista[op].NDocentes;
        }
    }
}
