using System;

namespace TMB_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu sexo (M/F):");
            string sexo = Console.ReadLine().ToUpper();

            Console.WriteLine("Digite seu peso em kg:");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua altura em cm:");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua idade em anos:");
            int idade = int.Parse(Console.ReadLine());

            double tmb = 0;

            if (sexo == "M")
            {
                tmb = 88.36 + (13.4 * peso) + (4.8 * altura) - (5.7 * idade);
            }
            else if (sexo == "F")
            {
                tmb = 447.6 + (9.2 * peso) + (3.1 * altura) - (4.3 * idade);
            }
            else
            {
                Console.WriteLine("Sexo inválido.");
                return;
            }

            Console.WriteLine("Sua Taxa Metabólica Basal é: " + tmb + " calorias/dia");
        }
    }
}
