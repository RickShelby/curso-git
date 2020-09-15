using System;
using System.Globalization;

namespace Calculadora {
    class Program {
        static void Main(string[] args) {

            Calculadora calc = new Calculadora();

            Console.WriteLine("Escolha sua operação:");
            string escolha = Console.ReadLine();

            if(escolha == "adição" || escolha == "Adição" || escolha == "ADIÇÃO" || escolha == "adicao" || escolha == "Adicao" || escolha == "ADICAO") {
                Console.Write("Insira  o primeiro número: ");
                double numero1 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Insira o segundo número: ");
                double numero2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                double conta = numero1 + numero2;
                Console.WriteLine($"Resultado: {conta}");
            }

           else if (escolha == "subtração" || escolha == "Subtração" || escolha == "SUBTRAÇÃO" || escolha == "subtracao" || escolha == "Subtracao" || escolha == "SUBTRACAO") {
                Console.Write("Insira  o primeiro número: ");
                double numero3 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Insira o segundo número: ");
                double numero4 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                double conta = numero3 - numero4;
                Console.WriteLine($"Resultado: {conta}");
            }


            else if (escolha == "divisão" || escolha == "Divisão" || escolha == "DIVISÃO" || escolha == "divisao" || escolha == "Divisao" || escolha == "DIVISAO") {
                Console.Write("Insira  o primeiro número: ");
                double numero5 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Insira o segundo número: ");
                double numero6 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                double conta = numero5 / numero6;
                Console.WriteLine($"Resultado: {conta}");
            }

            else if (escolha == "multiplicação" || escolha == "Multiplicção" || escolha == "MULTIPLICAÇÃO" || escolha == "multiplicacao" || escolha == "multiplicacao" || escolha == "multiplicacao") {
                Console.Write("Insira  o primeiro número: ");
                double numero7 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Insira o segundo número: ");
                double numero8 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                double conta = numero7 * numero8;
                Console.WriteLine($"Resultado: {conta}");
            }
            else {
                Console.WriteLine("Esta operação é inexistente nessa calculadora");
            }
        }
    }
}
