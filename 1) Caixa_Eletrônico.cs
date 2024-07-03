using System;

namespace caixa_eletronico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double saldo = 0;

            while (true)
            {
                Console.WriteLine("\n=====================");
                Console.WriteLine("\nCAIXA ELETRÔNICO");
                Console.WriteLine("\n=================");
                Console.WriteLine("\n1 - Depósito");
                Console.WriteLine("\n2 - Saque");
                Console.WriteLine("\n3 - Ver Saldo");
                Console.WriteLine("\n4 - Sair");

                Console.WriteLine("\nEscolha uma opção: ");
                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Informe o valor a ser depositado: ");
                        double deposito = double.Parse(Console.ReadLine());
                        saldo += deposito;
                        Console.WriteLine("Depósito efetuado com sucesso!");
                        break;

                    case 2:
                        Console.WriteLine("Informe o valor a ser sacado: ");
                        double saque = double.Parse(Console.ReadLine());
                        if (saque > saldo)
                        {
                            Console.WriteLine("Saldo insuficiente!");
                        }
                        else
                        {
                            saldo -= saque;
                            Console.WriteLine("Saque efetuado com sucesso!");
                        }
                        break;

                    case 3:
                        Console.WriteLine($"Saldo atual: {saldo}");
                        break;

                    case 4:
                        Console.WriteLine("Obrigado por utilizar o nosso caixa eletrônico.");
                        return;

                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }
            }
        }
    }
}
