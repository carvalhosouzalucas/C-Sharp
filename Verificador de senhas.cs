using System;

namespace verificador_de_senhas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string senhaCorreta = "1234"; 

            Console.WriteLine("Digite sua senha: ");
            string senha = Console.ReadLine();

            if (senha == senhaCorreta) 
            {
                Console.WriteLine("Senha correta digitada.");
            }
            else
            {
                Console.WriteLine("Senha incorreta.");
            }
        }
    }
}
