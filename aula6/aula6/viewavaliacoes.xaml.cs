using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace aula6
{
    /// <summary>
    /// Lógica interna para viewavaliacoes.xaml
    /// </summary>
    public partial class viewavaliacoes : Window
    {
        //Variável que representa instância da classe App (Camada de Interligação)
        private App app;
        public viewavaliacoes()
        {
            InitializeComponent();

            //Obtem instancia da classe App (Camada de Interligação)
            app = App.Current as App;

            //Subscrição de método da View no evento do Model
            app.Model_Notas.NotaAdicionada += Model_Notas_NotaAdicionada;
        }

        private void Model_Notas_NotaAdicionada(string str)
        {
            double nota = Convert.ToDouble(str);

            if (nota >= 9.5) {
                lbavaliacoes.Items.Add("Aprovado(" + Math.Round(nota) + ")");
            }
            else
            {
                lbavaliacoes.Items.Add("Reprovado(" + Math.Round(nota) + ")");
            }
        }
    }
}
