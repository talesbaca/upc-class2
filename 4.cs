using System;

namespace ConversorTemperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;

            while (run)
            {
                Console.WriteLine("1 - Celsius para Fahrenheit");
                Console.WriteLine("2 - Fahrenheit para Celsius");
                Console.WriteLine("3 - Sair");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite a temperatura em Celsius: ");
                        double celsius = double.Parse(Console.ReadLine());
                        double fahrenheit = celsius * 9 / 5 + 32;
                        Console.WriteLine($"{celsius} C = {fahrenheit} F");
                        break;

                    case 2:
                        Console.Write("Digite a temperatura em Fahrenheit: ");
                        double f = double.Parse(Console.ReadLine());
                        double c = (f - 32) * 5 / 9;
                        Console.WriteLine($"{f} F = {c} C");
                        break;

                    case 3:
                        run = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }
    }
}