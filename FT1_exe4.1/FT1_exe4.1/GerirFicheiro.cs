using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT1_exe4._1
{
    public class GerirFicheiro
    {


        public string Numero { get; set; }

        public string Nome { get; set; } = string.Empty;

        public string Curso { get; set; } = string.Empty;



        public GerirFicheiro()
        {

            //Inicialização, ao criar classe ler o ficheiro assim ficam logo os dados na classe e a view pode acessar e mostra
            LerFicheiro();

        }


        public void LerFicheiro()
        {

            StreamReader streamReader = new StreamReader("Fic.txt");

            // Ler linha do numero
            // numeroString = streamReader.ReadLine();
            //Converter para inteiro
            Numero = streamReader.ReadLine();

            // ler linha do nome
            Nome = streamReader.ReadLine();

            // Ler linha do curso
            Curso = streamReader.ReadLine();

            streamReader.Close();

        }



        public void EscreverFicheiro(string numero, string nome, string curso)
        {

            StreamWriter streamWriter = new StreamWriter("Fic.txt");

            streamWriter.WriteLine(numero);
            streamWriter.WriteLine(nome);
            streamWriter.WriteLine(curso);

            streamWriter.Close();


        }

    }
}
