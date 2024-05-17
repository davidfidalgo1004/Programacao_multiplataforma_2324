using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace aula6
{
    /// <summary>
    /// Interação lógica para App.xaml
    /// </summary>
    public partial class App : Application
    {
        //Definição das propriedades que representa as views
        public viewnota view_nota { get; private set; }
        public viewavaliacoes view_avaliacoes { get; private set; }
        //Definição das propriedades que representam os models
        public ModelNotas Model_Notas { get; private set; }

        public App()
        {
            //instanciação dos Models
            Model_Notas= new ModelNotas();

            //Instanciação das views
            view_nota= new viewnota();
            view_avaliacoes= new viewavaliacoes();
        }
    }
}
