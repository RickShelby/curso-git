using System;
using System.Globalization;



namespace Primeiro {
    class Program {
        static void Main(string[] args) {






            string nome = "João";
            int idade = 22;
            double saldo = 10.887598;
            byte id = 01;


            string nome2 = "José";
            int idade2 = 19;
            double saldo2 = 1.000;
            byte id2 = 02;

            

            Console.WriteLine("{0} tem {1} anos e o seu saldo é de {2:F2} reais", nome, idade, saldo);

            Console.WriteLine($"{nome} tem {idade} anos e seu saldo atual é de {saldo:F3} reais");

            Console.WriteLine(nome + " tem " + idade +" anos e o seu saldo atual é de " + saldo.ToString("F3", CultureInfo.InvariantCulture) + " reais ");















        }
    }
}
