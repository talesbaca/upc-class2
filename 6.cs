using System;
using System.Collections.Generic;

namespace CadastroProdutos
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public void mostrarInfos() {
            double valorTotal = Preco * Quantidade;
            Console.WriteLine($"Nome: {Nome}, Preço: {Preco}, Quantidade: {Quantidade}, Valor Total: {valorTotal}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Cadastro do produto {i + 1}:");

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine());

                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                produtos.Add(new Produto { Nome = nome, Preco = preco, Quantidade = quantidade });
            }

            Console.WriteLine("\nLista de produtos:");
            double totalEstoque = 0;

            foreach (var produto in produtos)
            {
                double valorTotal = produto.Preco * produto.Quantidade;
                totalEstoque += valorTotal;
                produto.mostrarInfos();
            }

            Console.WriteLine($"\nValor total em estoque: {totalEstoque}");
        }
    }
}