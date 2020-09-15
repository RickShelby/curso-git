using System;
using System.Globalization;

namespace Serio {

    class Program {
        static void Main(string[] args) {

            Banco banc = new Banco();


            Console.Write("Entre o número da conta: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            banc.SetNumero(numero);
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            banc.SetTitular(titular);
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = Convert.ToChar(Console.ReadLine(), CultureInfo.InvariantCulture);
            if(resp == 's' || resp == 'S') {
                Console.Write("Ente o valor de depósito inicial: ");
                double deposito = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                banc.SetDeposito(deposito);             
            }

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(banc);
           
            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double derp = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            banc.OperacaoSoma(derp);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(banc);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double saque = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            banc.OperacaoSaque(saque);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(banc);
            Console.ReadKey();

        }
    }
}




