using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    internal class Program
    {

        static void Main(string[] args)
        {
            char escolha;
            MenuPrincipal();

            do
            {
                escolha = Console.ReadKey().KeyChar;

                switch (escolha)
                {
                    case '1':
                        CriarLista();
                        break;

                    case '2':
                        CriarFila();
                        break;

                    case '3':
                        CriarPilha();
                        break;

                    case '4':
                        CriarVetor();
                        break;

                    case '5':
                        CriarMatrix();
                        break;
                    case '6':
                        CriarHashTable();
                        break;


                    case '0':
                        Console.WriteLine("Encerrando o programa...");
                        break;

                    default:
                        Console.WriteLine("Essa opção não existe...");
                        MenuPrincipal();
                        break;

                }

            } while (escolha != '0');

        }

        static void MenuPrincipal()
        {
            Console.WriteLine();
            Console.WriteLine("+-------------------+");
            Console.WriteLine("1 - Criar uma Lista");
            Console.WriteLine("2 - Criar uma Fila");
            Console.WriteLine("3 - Criar uma Pilha");
            Console.WriteLine("4 - Criar um Vetor");
            Console.WriteLine("5 - Criar uma Matrix");
            Console.WriteLine("6 - Criar uma Tabela Hash");
            Console.WriteLine("0 - Encerrar operação");
            Console.WriteLine("+-------------------+");
            Console.WriteLine();

        }
        /*-----------------------------------------------------------------------------------------------------------------*/
        static void CriarLista()
        {
            Console.WriteLine();
            Console.WriteLine();

            List<int> lista = new List<int>();
            int opcao;
            int valor;

            do
            {
                Console.WriteLine("+---- Menu de Lista ----+");
                Console.WriteLine("1 - Inserir Valor");
                Console.WriteLine("2 - Remover Valor");
                Console.WriteLine("3 - Exibir Valores");
                Console.WriteLine("4 - Consultar/Buscar Valor");
                Console.WriteLine("0 - Voltar ao menu principal");
                Console.WriteLine("+------------------------+");

                Console.Write("Escolha uma opção: ");
                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        Console.Write("Qual valor será inserido: ");
                        if (int.TryParse(Console.ReadLine(), out valor))
                        {
                            lista.Add(valor);
                            Console.WriteLine("Valor inserido com sucesso.");
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido.");
                        }
                        break;

                    case 2:
                        Console.Write("Qual valor deve ser removido: ");
                        if (int.TryParse(Console.ReadLine(), out valor))
                        {
                            if (lista.Remove(valor))
                            {
                                Console.WriteLine("Valor removido com sucesso.");
                            }
                            else
                            {
                                Console.WriteLine("Valor não encontrado.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Valores dentro da lista:");
                        if (lista.Count == 0)
                        {
                            Console.WriteLine("Lista vazia!");
                        }
                        else
                        {
                            foreach (int C in lista)
                            {
                                Console.WriteLine(C);
                            }
                        }
                        break;

                    case 4:
                        Console.Write("Digite o valor a buscar: ");
                        if (int.TryParse(Console.ReadLine(), out valor))
                        {
                            if (lista.Contains(valor))
                                Console.WriteLine("Valor encontrado na lista.");
                            else
                                Console.WriteLine("Valor NÃO está na lista.");
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido.");
                        }
                        break;

                    case 0:
                        Console.WriteLine("Voltando ao menu principal...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            } while (opcao != 0);
        }
        /*-----------------------------------------------------------------------------------------------------------------*/
        static void CriarFila()
        {
            Console.WriteLine();

            Queue<char> fila = new Queue<char>();
            int opcao;
            char valor;

            do
            {
                Console.WriteLine();
                Console.WriteLine("+--- Menu de Fila ----+");
                Console.WriteLine("1. Enqueue (Inserir)");
                Console.WriteLine("2. Head (Primeiro elemento)");
                Console.WriteLine("3. Desenfileirar (Remover)");
                Console.WriteLine("4. Tamanho da fila");
                Console.WriteLine("5. Exibir fila");
                Console.WriteLine("0. Voltar ao Menu Principal");
                Console.WriteLine("+------------------------+");

                Console.WriteLine();
                Console.Write("Escolha uma opção: ");
                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Entrada inválida. Digite um número.");
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite um valor a ser enfileirado: ");
                        valor = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        fila.Enqueue(valor);
                        break;

                    case 2:
                        if (fila.Count > 0)
                            Console.WriteLine("Início da fila: " + fila.Peek());
                        else
                            Console.WriteLine("Fila vazia.");
                        break;

                    case 3:
                        if (fila.Count > 0)
                            Console.WriteLine("Elemento desenfileirado: " + fila.Dequeue());
                        else
                            Console.WriteLine("Fila vazia.");
                        break;

                    case 4:
                        Console.WriteLine("Quantidade de elementos na fila: " + fila.Count);
                        break;

                    case 5:
                        Console.WriteLine("Fila: ");
                        if (fila.Count == 0)
                            Console.WriteLine("Fila vazia.");
                        else
                        {
                            foreach (var item in fila)
                            {
                                Console.Write(item + " ");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 0:
                        Console.WriteLine("Voltando ao menu principal...");
                        MenuPrincipal();
                        return;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            } while (opcao != 0);
        }
        /*-----------------------------------------------------------------------------------------------------------------*/
        static void CriarPilha()
        {
            Stack<string> pilha = new Stack<string>();
            int opcao;

            Console.WriteLine();

            do
            {
                Console.WriteLine();
                Console.WriteLine("+--- Menu de Fila ----+");
                Console.WriteLine("1 - Adicionar documento");
                Console.WriteLine("2 - Remover documento");
                Console.WriteLine("3 - Ver documento no topo");
                Console.WriteLine("4 - Listar todos os documentos");
                Console.WriteLine("5 - Quantidade de documentos");
                Console.WriteLine("0 - Voltar ao menu Principal");
                Console.WriteLine("+------------------------+");

                Console.WriteLine();
                Console.Write("Escolha: ");
                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Entrada inválida. Digite um número.");
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o nome do documento: ");
                        string doc = Console.ReadLine();
                        pilha.Push(doc);
                        Console.WriteLine("Documento adicionado.");
                        break;

                    case 2:
                        if (pilha.Count > 0)
                            Console.WriteLine($"Documento removido: {pilha.Pop()}");
                        else
                            Console.WriteLine("Pilha vazia.");
                        break;

                    case 3:
                        if (pilha.Count > 0)
                            Console.WriteLine($"No topo: {pilha.Peek()}");
                        else
                            Console.WriteLine("Pilha vazia.");
                        break;

                    case 4:
                        Console.WriteLine("Documentos pendentes:");
                        foreach (var d in pilha)
                            Console.WriteLine(d);
                        break;

                    case 5:
                        Console.WriteLine($"Total: {pilha.Count} documento(s)");
                        break;

                    case 0:
                        Console.WriteLine("Voltando ao menu principal...");
                        MenuPrincipal();
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            } while (opcao != 0);
        }
        /*-----------------------------------------------------------------------------------------------------------------*/
        static void CriarVetor()
        {
            List<int> vetor = new List<int>(); // vetor dinâmico
            int opcao;
            int valor;

            Console.WriteLine(); Console.WriteLine("+-------------------+");

            do
            {
                Console.WriteLine("1 - Inserir Valor");
                Console.WriteLine("2 - Remover Valor");
                Console.WriteLine("3 - Exibir Valores");
                Console.WriteLine("4 - Consultar/Buscar Valor");
                Console.WriteLine("0 - Voltar ao menu principal");
                Console.WriteLine("+-------------------+");
                Console.Write("Escolha: ");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Entrada inválida. Digite um número.");
                    continue;
                }

                switch (opcao)
                {
                    case 1: // Inserir
                        Console.Write("Valor a ser inserido: ");
                        if (int.TryParse(Console.ReadLine(), out valor))
                        {
                            vetor.Add(valor);
                            Console.WriteLine("Valor inserido com sucesso.");
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido.");
                        }
                        break;

                    case 2: // Remover
                        Console.Write("Valor a ser removido: ");
                        if (int.TryParse(Console.ReadLine(), out valor))
                        {
                            if (vetor.Remove(valor))
                                Console.WriteLine("Valor removido com sucesso.");
                            else
                                Console.WriteLine("Valor não encontrado.");
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido.");
                        }
                        break;

                    case 3: // Exibir
                        if (vetor.Count == 0)
                        {
                            Console.WriteLine("Lista está vazia.");
                        }
                        else
                        {
                            Console.WriteLine("Valores na lista:");
                            foreach (int v in vetor)
                            {
                                Console.WriteLine(v);
                            }
                        }
                        break;

                    case 4: // Buscar
                        Console.Write("Qual valor deseja buscar?: ");
                        if (int.TryParse(Console.ReadLine(), out valor))
                        {
                            int indice = vetor.IndexOf(valor);
                            if (indice != -1)
                                Console.WriteLine($"Valor encontrado na posição {indice}.");
                            else
                                Console.WriteLine("Valor não encontrado.");
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido.");
                        }
                        break;

                    case 0:
                        Console.WriteLine("Voltando ao menu principal...");
                        // MenuPrincipal(); // Descomente se quiser voltar
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

            } while (opcao != 0);
        }
        /*-----------------------------------------------------------------------------------------------------------------*/
        static void CriarMatrix()
        {
            List<List<int>> matriz = new List<List<int>>();
            int opcao, linha, coluna, valor;

            do
            {
                Console.WriteLine("\n1 - Inserir Valor");
                Console.WriteLine("2 - Remover Valor");
                Console.WriteLine("3 - Exibir Matriz");
                Console.WriteLine("4 - Consultar Valor");
                Console.WriteLine("0 - Voltar ao menu principal");
                Console.WriteLine("+-------------------+");
                Console.Write("Escolha: ");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Entrada inválida.");
                    continue;
                }

                switch (opcao)
                {
                    case 1: // Inserir
                        Console.Write("Linha: ");
                        linha = int.Parse(Console.ReadLine());

                        Console.Write("Coluna: ");
                        coluna = int.Parse(Console.ReadLine());

                        Console.Write("Valor: ");
                        valor = int.Parse(Console.ReadLine());

                        // Expande a matriz, se necessário
                        while (matriz.Count <= linha)
                            matriz.Add(new List<int>());

                        while (matriz[linha].Count <= coluna)
                            matriz[linha].Add(0); // valor padrão

                        matriz[linha][coluna] = valor;
                        Console.WriteLine("Valor inserido com sucesso.");
                        break;

                    case 2: // Remover
                        Console.Write("Linha: ");
                        linha = int.Parse(Console.ReadLine());

                        Console.Write("Coluna: ");
                        coluna = int.Parse(Console.ReadLine());

                        if (linha < matriz.Count && coluna < matriz[linha].Count)
                        {
                            matriz[linha][coluna] = 0; // Define como 0
                            Console.WriteLine("Valor removido.");
                        }
                        else
                        {
                            Console.WriteLine("Posição inválida.");
                        }
                        break;

                    case 3: // Exibir
                        Console.WriteLine("\nMatriz:");
                        for (int i = 0; i < matriz.Count; i++)
                        {
                            for (int j = 0; j < matriz[i].Count; j++)
                            {
                                Console.Write(matriz[i][j] + "\t");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 4: // Buscar
                        Console.Write("Valor a buscar: ");
                        valor = int.Parse(Console.ReadLine());
                        bool encontrado = false;

                        for (int i = 0; i < matriz.Count; i++)
                        {
                            for (int j = 0; j < matriz[i].Count; j++)
                            {
                                if (matriz[i][j] == valor)
                                {
                                    Console.WriteLine($"Encontrado em [{i}, {j}]");
                                    encontrado = true;
                                }
                            }
                        }
                        if (!encontrado)
                            Console.WriteLine("Valor não encontrado.");
                        break;

                    case 0:
                        Console.WriteLine("Voltando...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

            } while (opcao != 0);
        }
        static void CriarHashTable()
        {
            Dictionary<string, string> tabelaHash = new Dictionary<string, string>();
            int opcao;

            do
            {
                Console.WriteLine();
                Console.WriteLine("+--- Menu de Tabela Hash ---+");
                Console.WriteLine("1 - Inserir (chave, valor)");
                Console.WriteLine("2 - Remover por chave");
                Console.WriteLine("3 - Buscar valor por chave");
                Console.WriteLine("4 - Exibir todos os pares");
                Console.WriteLine("0 - Voltar ao menu principal");
                Console.WriteLine("+---------------------------+");
                Console.Write("Escolha: ");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Entrada inválida. Digite um número.");
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite a chave: ");
                        string chave = Console.ReadLine();
                        Console.Write("Digite o valor: ");
                        string valor = Console.ReadLine();
                        if (!tabelaHash.ContainsKey(chave))
                        {
                            tabelaHash.Add(chave, valor);
                            Console.WriteLine("Par inserido com sucesso.");
                        }
                        else
                        {
                            Console.WriteLine("Chave já existe. Use outra chave.");
                        }
                        break;

                    case 2:
                        Console.Write("Digite a chave a ser removida: ");
                        chave = Console.ReadLine();
                        if (tabelaHash.Remove(chave))
                            Console.WriteLine("Chave removida com sucesso.");
                        else
                            Console.WriteLine("Chave não encontrada.");
                        break;

                    case 3:
                        Console.Write("Digite a chave para buscar: ");
                        chave = Console.ReadLine();
                        if (tabelaHash.TryGetValue(chave, out valor))
                            Console.WriteLine($"Valor encontrado: {valor}");
                        else
                            Console.WriteLine("Chave não encontrada.");
                        break;

                    case 4:
                        if (tabelaHash.Count == 0)
                        {
                            Console.WriteLine("Tabela Hash vazia.");
                        }
                        else
                        {
                            Console.WriteLine("Pares (chave, valor):");
                            foreach (var par in tabelaHash)
                                Console.WriteLine($"Chave: {par.Key} - Valor: {par.Value}");
                        }
                        break;

                    case 0:
                        Console.WriteLine("Voltando ao menu principal...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            } while (opcao != 0);
        }

    }
}
