using Microsoft.Win32;
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

namespace aula7
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        //Apontador para a classe App (camada de interligação)
        private App app;
        public MainWindow()
        {
            InitializeComponent();

            //Obtem apontador para App (camada de interligação)
            app = App.Current as App;

            //Subscrição de método da View em evento do Model
            app.Model_Ficheiro.EscritaTerminada += Model_Ficheiro_EscritaTerminada;
            app.Model_Ficheiro.LeituraTerminada += Model_Ficheiro_LeituraTerminada; ;
        }

        private void Model_Ficheiro_LeituraTerminada()
        {
            tbFicheiro.Text = app.Model_Ficheiro.Texto;
        }

        private void  Model_Ficheiro_EscritaTerminada()
        {
            MessageBox.Show("Ficheiro guardado com sucesso!!");
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dlg= new SaveFileDialog();
            dlg.Filter = "Ficheiros de Texto (*.txt)|*.txt|Todos os Ficheiros (*.*)|*.*";

            if (dlg.ShowDialog() == true)
            {
                //Acesso da camada apresentação (View) à camada lógica (Model)
                app.Model_Ficheiro.EscritaFicheiro(tbFicheiro.Text, dlg.FileName);
            }
        }

        private void btnAbrir_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Ficheiros de Texto (*.txt)|*.txt|Todos os Ficheiros (*.*)|*.*";

            if (dlg.ShowDialog() == true)
            {
                //Acesso da camada apresentação (View) à camada lógica (Model)
                app.Model_Ficheiro.LeituraFicheiro(dlg.FileName);
            }
        }
    }
}
