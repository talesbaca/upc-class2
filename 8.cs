using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o peso (kg): ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura (m): ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine("IMC: " + imc.ToString("0.00"));

            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc < 25)
            {
                Console.WriteLine("Peso normal");
            }
            else if (imc < 30)
            {
                Console.WriteLine("Sobrepeso");
            }
            else
            {
                Console.WriteLine("Obesidade");
            }
        }
    }
}