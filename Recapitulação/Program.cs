using System;
using System.Globalization;

namespace Recapitulação {
    class Program {
       
        static void Main(string[] args) {

            Console.Write("Quantos quartos serão alugados? ");
            int quartos = Convert.ToInt16(Console.ReadLine());

            int[] vect = new int[quartos];
            Console.WriteLine();
            for (int i = 0; i < quartos; i++) {
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.WriteLine($"Quarto: {i}");
                Console.WriteLine();
                if (i == quartos) {
                    Console.WriteLine($"{i}: {nome}, {email} ");

                        

                      
                    
                }
            }
           

            Console.ReadKey();
        }
    }
}
