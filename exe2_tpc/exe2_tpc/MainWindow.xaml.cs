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

namespace exe2_tpc
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnporto_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("VENCEU O FCPORTO!");
        }

        private void btnbenfica_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("VENCEU O SLBENFICA!");
        }

        private void btnsporting_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("VENCEU O SPORTINGCP!");
        }

        private void btnbenfica_MouseEnter(object sender, MouseEventArgs e)
        {
            btnbenfica.Content = "FCPORTO";
            btnporto.Content = "SLBENFICA";
        }

        private void btnsporting_MouseEnter(object sender, MouseEventArgs e)
        {
            btnsporting.Content = "FCPORTO";
            btnporto.Content = "SPORTINGCP";
        }
    }
}
