using System;
using System.Collections.Generic;

namespace GerenciadorDeTarefas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tarefas = new List<string>();
            string opcao = "";

            Console.WriteLine("--- BEM-VINDO AO TASK MASTER C# ---");

            //loop principal do programa
            while (opcao != "3")
            {
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1. Adicionar tarefa");
                Console.WriteLine("2. Listar tarefas");
                Console.WriteLine("3. Sair");
                Console.Write("Opção: ");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Digite a descrição da tarefa: ");
                        string novaTarefa = Console.ReadLine();
                        tarefas.Add(novaTarefa);
                        Console.WriteLine("Tarefa adicionada com sucesso!");
                        break;

                    case "2":
                        Console.WriteLine("\n--- SUAS TAREFAS ---");
                        if (tarefas.Count == 0) {
                            Console.WriteLine("Nenhuma tarefa cadastrada.");
                        } else {
                            for (int i = 0; i < tarefas.Count; i++){
                                Console.WriteLine($"{i + 1}. {tarefas[i]}");
                            }
                        }
                        break;
                    case "3":
                        Console.WriteLine("Saindo... Até Logo!");
                        break;

                    default:
                        Console.WriteLine("Opção inválida, tente novamente.");
                        break;
                }
            }
        }
    }
}