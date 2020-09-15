using System;
using System.Globalization;

namespace Banco {
   public class Program {
        static void Main(string[] args) {

            ContaBancaria number = new ContaBancaria();

            Console.Write("Entre o número da conta: ");
            int numero = Convert.ToInt16(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial: ");
            char resp = char.Parse(Console.ReadLine());
            
            if (resp == 's' || resp == 'S') {
                Console.Write("Entre o valor do depósito inicial: ");
                double saldo = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Dados da conta:");
                Console.WriteLine($"Conta {numero}, Titular: {titular}, Saldo: ${saldo.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine();
            }
            
            else {
                Console.WriteLine("Dados da conta: ");
                Console.WriteLine($"Conta: {numero}, Titular: {titular}, Saldo: $0.00 ");
               }

            Console.Write("Entre um valor para depósito ");
            double deposito = Convert.ToDouble(Console.ReadLine());

            double resultado = 

            























        }
    }
}
