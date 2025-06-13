using System;

namespace dataSearchHashTable
{

    public class Program
    {
        static void Main(string[] args)
        {
            HashTable<int> tableList = new HashTable<int>();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Tabela hash");
                Console.WriteLine("1: inserir valor");
                Console.WriteLine("2: Buscar valor");
                Console.WriteLine("3: Remover valor");
                Console.WriteLine("4: Exibir tabela");
                Console.WriteLine("0: sair");
                Console.Write("insira uma das opções: ");

                char opcao = Console.ReadKey().KeyChar;
                Console.Clear();

                switch (opcao)
                {
                    case '1':
                        Console.Write("valor a inserir: ");
                        if (int.TryParse(Console.ReadLine(),out int valueInsert))
                        {
                            tableList.insert(valueInsert);
                        }
                        else
                        {
                            Console.WriteLine("valor inválido!");
                        }
                            break;
                    case '2':
                        Console.Write("valor a inserir: ");
                        if (int.TryParse(Console.ReadLine(), out int valueSearch))
                        {
                            if (tableList.Search(valueSearch))
                            {
                                Console.WriteLine($"{valueSearch} Encontrado");
                            }
                            else
                            {
                                Console.WriteLine($"{valueSearch} não está na tabela");
                            }
                        }
                        else
                        {
                            Console.WriteLine("valor inválido!");
                        }
                        break;
                    case '3':
                        Console.Write("valor a remover: ");
                        if (int.TryParse(Console.ReadLine(), out int valueRemove))
                        {
                            if (tableList.Remove(valueRemove))
                            {
                                Console.WriteLine($"{valueRemove} removido");
                            }
                            else
                            {
                                Console.WriteLine($"{valueRemove} não encontrado");
                            }
                        }
                        else
                        {
                            Console.WriteLine("valor inválido!");
                        }
                        break;
                    case '4':
                        Console.WriteLine();
                        break;
                    case '0':
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.WriteLine("\nPressione Enter para continuar....");

                Console.ReadKey();
            }
        }
    }
}
