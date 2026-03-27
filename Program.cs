using System;
using System.Collections.Generic;
using System.IO;

namespace GerenciadorDeTarefas
{
    class Program
    {
        static string arquivoControle = "tarefas.txt";
        static void Main(string[] args)
        {
            List<Tarefa> listaDeTarefas = CarregarTarefasDoArquivo();
            string opcao = "";

            while (opcao != "4")
            {
                Console.WriteLine("\n======= TASK MANAGER PRO =======");
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
                        listaDeTarefas.Add(new Tarefa(desc));
                        SalvarTarefasNoArquivo(listaDeTarefas);
                        Console.WriteLine("Tarefa anotada!");
                        break;

                    case "2":
                        Console.WriteLine("\n--- LISTA ATUAL ---");
                        if (listaDeTarefas.Count == 0) Console.WriteLine("Sua lista está vazia.");

                        for (int i = 0; i < listaDeTarefas.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {listaDeTarefas[i]}");
                        }
                        break;

                    case "3":
                        Console.Write("Digite o número da tarefa que concluiu: ");
                        if (int.TryParse(Console.ReadLine(), out int indice) && indice > 0 && indice <= listaDeTarefas.Count)
                        {
                            listaDeTarefas[indice - 1].Concluir();
                            SalvarTarefasNoArquivo(listaDeTarefas);
                            Console.WriteLine("Parabéns! Mais uma tarefa concluída!");
                        }
                        else
                        {
                            Console.WriteLine("Número inválido.");
                        }
                        break;

                    case "4":
                        Console.WriteLine("Saindo e salvando o progresso...");
                        break;

                    default:
                        Console.WriteLine("Opção inexistente.");
                        break;
                }
            }
        }

        static void SalvarTarefasNoArquivo(List<Tarefa> tarefas)
        {
            List<string> linhasParaSalvar = new List<string>();
            foreach (var t in tarefas)
            {
                linhasParaSalvar.Add(t.ParaArquivo());
            }
            File.WriteAllLines(arquivoControle, linhasParaSalvar);
        }

        static List<Tarefa> CarregarTarefasDoArquivo()
        {
            List<Tarefa> listaCarregada = new List<Tarefa>();

            try
            {
                if (File.Exists(arquivoControle))
                {
                    string[] linhas = File.ReadAllLines(arquivoControle);
                    foreach (string linha in linhas)
                    {
                        string[] partes = linha.Split(';');
                        if (partes.Length == 2)
                        {
                            Tarefa t = new Tarefa(partes[0]);
                            t.Concluida = bool.Parse(partes[1]);
                            listaCarregada.Add(t);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao carregar arquivo: " + ex.Message);
            }

            return listaCarregada;
        }
    }
}