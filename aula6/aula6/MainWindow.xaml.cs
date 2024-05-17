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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace aula6
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        private App app;
        public MainWindow()
        {
            InitializeComponent();

            //Obtem instancia da classe app (camada de interligação)
            app = App.Current as App;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //efetua ligação entre view e model
            app.Model_Notas.Adiciona(tbnota.Text);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            app.view_nota.Show();
            app.view_avaliacoes.Show();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            app.view_avaliacoes.Close();
            app.view_nota.Close();
        }
    }
}
