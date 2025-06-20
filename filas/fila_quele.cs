using System.Collections.Generic;
using System;

namespace Fila_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<char> queue = new Queue<char>();

            int opcao;
            char valor;
            Console.WriteLine("Fila usando Queue");

            do
            {
                Console.WriteLine("Escolha uma o~pção");
                Console.WriteLine("0. Sair");
                Console.WriteLine("1. Enqueue");
                Console.WriteLine("2. Head");
                Console.WriteLine("3. Desenfileirar");
                Console.WriteLine("4. Tamanho da fila");
                Console.WriteLine("5. Exibir fila");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;

                    case 1:
                        Console.WriteLine("Digite um valor a ser enfileirado: ");
                        valor = Console.ReadKey().KeyChar;
                        queue.Enqueue(valor);
                        Console.WriteLine();
                        break;

                    case 2:
                        if (queue.Count > 0)
                            Console.WriteLine("Inicio da fila: " + queue.Peek());
                        else
                            Console.WriteLine("Fila Vazia");
                        break;

                    case 3:
                        if (queue.Count > 0)
                            Console.WriteLine("Elementos desenfileirados: " + queue.Dequeue());
                        else
                            Console.WriteLine("Fila Vazia");
                        break;

                    case 4:
                        Console.WriteLine("Quantidade de elementos na fila: " + queue.Count);
                        break;

                    case 5:
                        Console.WriteLine("Fila: ");
                        foreach (var item in queue)
                        {
                            Console.WriteLine(item + " ");
                        }
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Opção invalida!");
                        break;

                }
            } while (opcao != 0);
        }
    }
}
