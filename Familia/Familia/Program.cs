using static System.Console;
using System.Text;

namespace Familia {
    class Program {
        static void Main(string[] args) {

            var familia  = new StringBuilder();

            familia.AppendLine("Fabio Parreira");
            familia.AppendLine("Idade: 36");

            //Console.WriteLine(nome);
            //Console.WriteLine(idade);

            //string nome2 = "Rosangela Santana";
            //byte idade2 = 34;

            //Console.WriteLine(nome2);
            //Console.WriteLine(idade2);

            //string nome3 = "Maria Elisa";
            // byte idade3 = 7;

            //string nome4 = "Riquelme Santana";
            //byte idade4 = 14;

            //string nome5 = "Pitucha";
            //byte idade5 = 7;

            //string nome6 = "Pantera";
            //byte idade6 = 2;

            //string nome7 = "Balu";
            //byte idade7 = 4;

            //string frase = "Obrigado por ter me guiado até aqui.";
            //string frase2 = "Prêmio de melhor pai do mundo.";
            //string frase3 = "Obrigado.";
            //string frase4 = "Da proxima vez eu deixo em um visual melhor";
            //string frase5 = "Ligue o computador ao lado";




            WriteLine(familia.ToString());
            WriteLine("Informe seu nome?");
            var nome =  ReadLine();

           WriteLine("Seu nome é " + nome);
            ReadKey();
            //Console.WriteLine(nome5);
            //Console.WriteLine(idade5);
            //Console.WriteLine(nome6);
            //Console.WriteLine(idade6);
            //Console.WriteLine(nome7);
            //Console.WriteLine(idade7);
            //Console.WriteLine(frase);
            //Console.WriteLine(frase2);
            //Console.WriteLine(frase3);
            //Console.WriteLine(frase4);
            //Console.WriteLine(frase5);



        }
    }
}
