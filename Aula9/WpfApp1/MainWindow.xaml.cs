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

namespace WpfApp1
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
            myapp=(App)App.Current;
            myapp.me.InicializacaoTerminada += Me_InicializacaoTerminada;
        }

        private void Me_InicializacaoTerminada()
        {
            tbEscola.Text = myapp.me.Escola;

            foreach(ModelDepartamento dep in myapp.me)
            {
                cbDepartamentos.Items.Add(dep.Designacao);
            }
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Inicialização ou pedido de inicialização do estado da aplicação
            myapp.me.Inicializacao();
        }

        private void cbDepartamentos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            sbiDocentes.Content="NºDocentes: "+ myapp.me.ObterDocentes(cbDepartamentos.SelectedIndex);
        }
    }
}
