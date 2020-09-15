using System;
using System.Globalization;

namespace Calculadora {
    class Program {
        static void Main(string[] args) {



            //numero1 = new Calculadora();
            //numero2 = new Calculadora();

            Console.WriteLine("Escolha a operação que deseja utilizar: ");
            Console.WriteLine("1  - ADIÇÃO ");
            Console.WriteLine("2  - SUBTRÇÃO ");
            Console.WriteLine("3  - MULTIPLICAÇÃO ");
            Console.WriteLine("4  - DIVISÃO ");
            Console.WriteLine("0  - SAIR ");
            Console.Write("Número: ");
            int operador = Convert.ToInt32(Console.ReadLine());

            var numeroUm = 0;
            var numeroDois = 0;

            Console.Write("Informe o primeiro número: ");
            numeroUm = Convert.ToInt32(Console.ReadLine());


            Console.Write("Informe o segundo número: ");
            numeroDois = Convert.ToInt32(Console.ReadLine());

            if (operador == 1) {
                Console.WriteLine($"A soma dos números é igual á {Calculadora.AdicaoDeProdutos(numeroUm, numeroDois)}");
            }
            else if (operador == 2) {
                Console.WriteLine($"A subtração dos números é igual á {Calculadora.SubtracaoDeProdutos(numeroUm, numeroDois)}");
            }
            else if (operador == 3) {
                Console.WriteLine($"A multilpicação dos números é gual á {Calculadora.MultiplicacaoDeProdutos(numeroUm, numeroDois)}");
            }
            else if (operador == 4) {
                Console.WriteLine($"A divisão dos números é gual á {Calculadora.DivisaoDeProdutos(numeroUm, numeroDois)}");
            }
            else if (operador == 0) { };
               


            //if (resposta == "Adição" || resposta == "adição") {
            //    Console.Write("Informe o primeiro número: ");
            //    numero1.Adicao = Convert.ToInt64(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    Console.Write("Informe o segundo número: ");
            //    numero2.Adicao = Convert.ToInt64(Console.ReadLine(), CultureInfo.InvariantCulture);

            //    numero1.AdicaoDeProdutos();
            //    Console.WriteLine("Resposta: " + numero1.AdicaoDeProdutos());

            //}
            //else if (resposta == "Subtração" || resposta == "subtração") {
            //    Console.Write("Informe o primeiro número: ");
            //    numero1.Subtracao = Convert.ToInt64(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    Console.Write("Informe o segundo número: ");
            //    numero2.Subtracao = Convert.ToInt64(Console.ReadLine(), CultureInfo.InvariantCulture);

            //    numero1.SubtracaoDeProdutos();
            //    Console.WriteLine("Resposta: " + numero1.SubtracaoDeProdutos());
            //}
            //else if(resposta == "Divisão" || resposta == "divisão") {
            //    Console.Write("Informe o primeiro número: ");
            //    numero1.Divisao = Convert.ToInt64(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    Console.Write("Informe o segundo número: ");
            //    numero2.Divisao = Convert.ToInt64(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    Console.WriteLine($"Resposta: {numero1.DivisaoDeProdutos()}");
            //}


            Console.ReadKey();


        
        }


    }
}
