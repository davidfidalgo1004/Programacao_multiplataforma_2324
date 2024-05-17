using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace aula_10
{
    public class ModelBateria : IBateria
    {


        public int carga { get; set; }

        public event MetodosComInt cargaalterada;
        
        public void Carrega()
        {
            try
            {
                if (carga != 100)
                {
                    carga += 10;
                }
                else
                {
                    throw new BateriaExcessao("Bateria Excedida");
                }
                if (cargaalterada != null)
                {
                    cargaalterada(carga);
                }
            }
            catch(BateriaExcessao erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            
            }
        }

        public void Descarrega()
        {
            try
            {
                if (carga != 0)
                {
                    carga -= 10;
                }
                else
                {
                    throw new BateriaExcessao("Bateria Descarregada");
                }
                if (cargaalterada != null)
                {
                    cargaalterada(carga);
                }
            }
            catch(BateriaExcessao erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }
    }
}
