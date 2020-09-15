using System;

namespace Pizzaria {
    class Program {
        static void Main(string[] args) {
            Console.Write("Insira seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine();

            double sabor1 = 0;
            double sabor2 = 0;
            double sabor3 = 0;
            double sabor4 = 0;
            double sabor5 = 0;
            double sabor6 = 0;

            sabor1 = 28.70;
            sabor2 = 26.70;
            sabor3 = 30.00;
            sabor4 = 35.00;
            sabor5 = 32.20;
            sabor6 = 30.80;

            

            Console.WriteLine("Os sabores restantes são esses: Pizza de Murassela, Brotinho, Gold - 2 Sabores, Gold - 4 sabores, Brotinho Doce e Pizza de 4 Queijos. ");
            Console.WriteLine("Qual seu pedido?");
            string pedido = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Foram adicionadas ao seu pedido {pedido}");
            Console.Write("Gostaria de uma bebida? ");
            string resposta = Console.ReadLine();
            if (resposta == "Sim" || resposta == "sim") {
                Console.WriteLine("As bebidas restantes são: Coca - Cola, Guaraná, Pepsi e Fanta");
                Console.Write("Qual sabor deseja? ");
                string resposta2 = Console.ReadLine();
                Console.Write("Deseja mais de uma?");

                if (resposta2 == "Sim" || resposta2 == "sim") {
                    Console.Write("Quantas? ");
                    string resposta3 = Console.ReadLine();
                    Console.WriteLine($"{resposta3} {resposta2} foram adicionadas ao seu pedido");
                }
                else {
                    double operacao = pedido + resposta2; 
                    Console.WriteLine("O total da sua conta foi de ");
                   
                }
            }
           



















        }
    }
}
