using System;

namespace Adivinhacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int numero = rand.Next(1, 101);
            int tentativas = 0;
            bool acertou = false;

            while (!acertou)
            {
                Console.Write("Tente adivinhar o número (1-100): ");
                int chute = int.Parse(Console.ReadLine());
                tentativas++;

                if (chute < numero)
                {
                    Console.WriteLine("Maior");
                }
                else if (chute > numero)
                {
                    Console.WriteLine("Menor");
                }
                else
                {
                    Console.WriteLine($"Parabéns! Você acertou em {tentativas} tentativas.");
                    acertou = true;
                }
            }
        }
    }
}