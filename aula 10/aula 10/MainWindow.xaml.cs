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

namespace aula_10
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    
    public partial class MainWindow : Window
    {
        private App myapp;
        public MainWindow()
        {
            InitializeComponent();
            myapp = (App)App.Current;
            myapp.mb.cargaalterada += Mb_cargaalterada;
        }

        private void Mb_cargaalterada(int carga)
        {
            pbCarga.Value = carga;
            this.Title = "GESTOR DE BATERIA: " + carga+"%";
        }

        private void btnCarrega_Click(object sender, RoutedEventArgs e)
        {
            myapp.mb.Carrega();
        }

        private void btnDescarrega_Click(object sender, RoutedEventArgs e)
        {
            myapp.mb.Descarrega();
        }
    }
}
