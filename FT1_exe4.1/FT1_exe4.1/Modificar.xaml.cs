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

namespace FT1_exe4._1
{
    /// <summary>
    /// Lógica interna para Modificar.xaml
    /// </summary>
    public partial class Modificar : Window
    {


        private App MyApplication;

        public Modificar()
        {
            InitializeComponent();

            MyApplication = (App)App.Current;

            tbNome.Text = MyApplication.GerirFicheiro.Nome;
            tbCurso.Text = MyApplication.GerirFicheiro.Curso;
            tbNumero.Text = MyApplication.GerirFicheiro.Numero;
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            //Alterações não são feitas

            this.DialogResult = true;

        }

        private void BtnAlterar_Click(object sender, RoutedEventArgs e)
        {
            //Alterações são feitas:

            MyApplication.GerirFicheiro.Nome = tbNome.Text;
            MyApplication.GerirFicheiro.Curso = tbCurso.Text;
            MyApplication.GerirFicheiro.Numero = tbNumero.Text;

            this.DialogResult = true;
        }
    }
}


