using System;

namespace SomaPares
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            int soma = 0;

            foreach (int num in numeros)
            {
                if (num % 2 == 0) soma += num;
            }

            Console.WriteLine("Soma dos números pares: " + soma);
        }
    }
}