using System.Collections.Generic;
using System;

namespace DynamicList
{
    public class Program
    {

        static void Main()
        {
            List<char> lista = new List<char>();
            char valor;
            int opcao;
            do
            {
                Console.WriteLine("\nLISTA DYNAMICA - List<T>");
                Console.WriteLine("0. Sair");
                Console.WriteLine("1. Inserir elemento");
                Console.WriteLine("3. Remover elemento");
                Console.WriteLine("4. Verificar se contém na lista");
                Console.WriteLine("5. Tamanho da lista");
                Console.WriteLine("6. Limpar lista");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;

                    case 1:
                        Console.WriteLine("Digite o valor");
                        valor = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        lista.Add(valor);
                        break;

                    case 2:
                        Console.WriteLine("Digite o valor");
                        valor = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        if (lista.Remove(valor))
                            Console.WriteLine("Valor removido com sucesso.");
                        else
                            Console.WriteLine("Valor não encontrado");
                        break;

                    case 3:
                        if (lista.Count == 0)
                        {
                            Console.WriteLine("Lista vazia.");
                        }
                        else
                        {
                            Console.WriteLine("Lista: ");
                            foreach (char c in lista)
                            {
                                Console.Write(c + " ");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 4:
                        Console.WriteLine("Digite o valor a ser verificado: ");
                        valor = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        Console.WriteLine(
                            //if ternario
                            lista.Contains(valor) // teste logico
                            ? "Valor encontado na lista." //valor se verdadeiro - true
                            : "Valor não encontrado na lista."// valor se falso - else
                            );
                        break;

                    case 5:
                        Console.WriteLine("Tamanho da lista: " + lista.Count);
                        break;

                    case 6:
                        lista.Clear();
                        Console.WriteLine("Lista limpa.");
                        break;

                    default:
                        Console.WriteLine("Opçãp invalida!");
                        break;
                }

            } while (opcao != 0);
        }
    }
}
