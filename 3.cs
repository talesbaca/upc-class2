using System;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro positivo: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("Número deve ser positivo.");
            }
            else
            {
                long fat = 1;
                int i = n;

                while (i > 1)
                {
                    fat = fat * i;
                    i--;
                }

                Console.WriteLine($"O fatorial de {n} é {fat}");
            }
        }
    }
}