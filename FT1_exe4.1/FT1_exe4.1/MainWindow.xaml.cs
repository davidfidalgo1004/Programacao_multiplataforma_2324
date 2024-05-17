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

namespace FT1_exe4._1
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {

        private App MyApplication;

        public MainWindow()
        {
            InitializeComponent();

            MyApplication = (App)App.Current;
        }

        private void BtnModificar_Click(object sender, RoutedEventArgs e)
        {

            //Abrir janela de edição e esperar pelo resultado

            Modificar Modificar = new Modificar();


            //Ver mudanças ao janela ser fechada
            if (Modificar.ShowDialog() == true)
            {

                tbNumero.Text = MyApplication.GerirFicheiro.Numero;
                tbNome.Text = MyApplication.GerirFicheiro.Nome;
                tbCurso.Text = MyApplication.GerirFicheiro.Curso;

            }


        }
        private void BtnSair_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Vai abandonar o programa.\nTem a certeza?", "Abandonar o Programa", MessageBoxButton.OKCancel, MessageBoxImage.Information);

            if (result == MessageBoxResult.OK)
            {
                // The user clicked OK, close the application
                MyApplication.Shutdown();
                MyApplication.GerirFicheiro.EscreverFicheiro(tbNumero.Text, tbNome.Text, tbCurso.Text);
            }
            else
            {
                // The user clicked Cancel, do nothing
            }

        }


        //Evento quando a janela é carregada

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {


            tbNumero.Text = MyApplication.GerirFicheiro.Numero;
            tbNome.Text = MyApplication.GerirFicheiro.Nome;
            tbCurso.Text = MyApplication.GerirFicheiro.Curso;


        }
    }
}
