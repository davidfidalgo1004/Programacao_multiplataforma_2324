using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace aula7
{
    /// <summary>
    /// Interação lógica para App.xaml
    /// </summary>
    public partial class App : Application
    {
        //Views 
        //Apenas são coloacadas views extra a principal
        
        //Models
        public ModelFicheiro Model_Ficheiro { get; private set; }

        //construtor da classe
        public App()
        {
            //Inicializa instância da classe Model (ModelFicheiro)
            Model_Ficheiro=new ModelFicheiro();
        }

    }
}
