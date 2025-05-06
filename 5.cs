using System;

namespace PalindromoSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma palavra ou frase: ");
            string input = Console.ReadLine();

            string texto = input.ToLower();
            int esquerda = 0;
            int direita = texto.Length - 1;
            bool ehPalindromo = true;

            while (esquerda < direita)
            {
                if (texto[esquerda] != texto[direita])
                {
                    ehPalindromo = false;
                    break;
                }
                esquerda++;
                direita--;
            }

            if (ehPalindromo)
            {
                Console.WriteLine("É um palíndromo");
            }
            else
            {
                Console.WriteLine("Não é um palíndromo");
            }
        }
    }
}
