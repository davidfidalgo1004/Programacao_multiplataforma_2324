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

namespace aula5
{
    /// <summary>
    /// Lógica interna para WindowAdicionar.xaml
    /// </summary>
    public partial class WindowAdicionar : Window
    {
        public Figura Fig { get; private set; }
        public WindowAdicionar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void btnAdicionar_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            if (rbQuadrado.IsChecked == true)
            {
                Fig.Nome = "Quadrado";
            }
            else if (rbRetangulo.IsChecked == true)
            {
                Fig.Nome = "Retangulo";
            }
            else
            {
                Fig.Nome = "Circulo";
            }
            Fig.Largura = tbLargura.Text;
            Fig.comprimento = tbcomprimento.Text;
        }
    }

}
