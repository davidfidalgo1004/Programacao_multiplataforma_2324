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
    /// Lógica interna para viewnota.xaml
    /// </summary>
    public partial class viewnota : Window
    {
        //Declaração da variável que representa a Classe App (camada de Interface)
        private App app;
        public viewnota()
        {
            InitializeComponent();

            //Obtem instancia da classe App (camada de interligação)
            app = App.Current as App;

            //Subscreve um método da view no evento do Model
            app.Model_Notas.NotaAdicionada += Model_Notas_NotaAdicionada;
        }

        private void Model_Notas_NotaAdicionada(string str)
        {
            lvNotas.Items.Add(str + " valores");
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
