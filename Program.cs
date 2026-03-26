using System;
using System.Collections.Generic;

namespace GerenciadorDeTarefas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tarefa> listaDeTarefas = new List<Tarefa>();
            string opcao = "";

            while (opcao != "4")
            {
                Console.WriteLine("\n======= MEU GERENCIADOR ADS =======");
                Console.WriteLine("1. Adicionar nova tarefa");
                Console.WriteLine("2. Listar todas");
                Console.WriteLine("3. Concluir uma tarefa");
                Console.WriteLine("4. Sair");
                Console.Write("Escolha uma opção: ");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Descrição da tarefa: ");
                        string desc = Console.ReadLine();
                        Tarefa nova = new Tarefa(desc);
                        listaDeTarefas.Add(nova);
                        Console.WriteLine("Sucesso!");
                        break;

                    case "2":
                        Console.WriteLine("\n--- LISTA ATUAL ---");
                        if (listaDeTarefas.Count == 0) Console.WriteLine("Vazio.");

                        for (int i = 0; i < listaDeTarefas.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {listaDeTarefas[i]}");
                        }
                        break;

                    case "3":
                        Console.Write("Digite o número da tarefa que concluiu: ");
                        if(int.TryParse(Console.ReadLine(), out int indice))
                        {
                            if (indice > 0 && indice <= listaDeTarefas.Count)
                            {
                                listaDeTarefas[indice - 1].Concluir();
                                Console.WriteLine("Tarefa atualizada!");
                            }
                            else { Console.WriteLine("Número inválido."); }
                        }
                        break;

                    case "4":
                        Console.WriteLine("Até a próxima!");
                        break;

                    default:
                        Console.WriteLine("Opção inexistente.");
                        break;
                }
            }
        }
    }
}