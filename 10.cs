using System;
using System.Collections.Generic;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tarefas = new List<string>();
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("1 - Adicionar tarefa");
                Console.WriteLine("2 - Listar tarefas");
                Console.WriteLine("3 - Sair");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite a tarefa: ");
                        string tarefa = Console.ReadLine();
                        tarefas.Add(tarefa);
                        break;

                    case 2:
                        Console.WriteLine("Tarefas:");
                        for (int i = 0; i < tarefas.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {tarefas[i]}");
                        }
                        break;

                    case 3:
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }
    }
}