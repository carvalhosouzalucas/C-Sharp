using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace exercicio_par_ou_impar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Insira um n�mero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O n�mero � par.");
            }
            else
            {
                Console.WriteLine("O n�mero � �mpar.");
            }
        }
    }
}
