using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace FT1_exe4._1
{
    /// <summary>
    /// Interação lógica para App.xaml
    /// </summary>
    public partial class App : Application
    {
        public GerirFicheiro GerirFicheiro { get; set; }


        public App()
        {
            //Criar primeiro o model
            GerirFicheiro = new GerirFicheiro();

        }

    }
}
