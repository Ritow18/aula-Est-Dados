using System;
using System.Collections.Generic;
using System.Linq;
//  Algoritmos de Pesquisa (vistos na aula de 13/05) não é necessario fazer essa opção no Menu
namespace Menu_interativo_entrutura_de_dados_VMFPL
{
    class Program
    {
        static void Main(string[] args)

        {
            char escolha;
            MostrarMenuPrincipal();
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
                        CriarMatrizPqIssoEhComplexo.CriarMatriz();
                        break;
                    case '0':
                        Console.WriteLine("Saindo do programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        MostrarMenuPrincipal();
                        break;
                }
            } while (escolha != '0');
        }

        static void MostrarMenuPrincipal()
        {
            Console.WriteLine("\n Menu Principal");
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1 - Criar Lista");
            Console.WriteLine("2 - Criar Fila");
            Console.WriteLine("3 - Criar Pilha");
            Console.WriteLine("4 - Criar Vetor");
            Console.WriteLine("5 - Criar Matriz");
            Console.WriteLine("0 - Sair");
        }

        static void CriarLista()
        {
            List<char> lista = new List<char>();
            Console.WriteLine("\nCriar sua Lista");
            while (true)
            {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1 - Adicionar item");
                Console.WriteLine("2 - Exibir lista");
                Console.WriteLine("3 - Remover elemento da lista");
                Console.WriteLine("4 - Consultar/Buscar Elemento");
                Console.WriteLine("0 - Voltar para o Menu Principal");

                char escolha = Console.ReadKey().KeyChar;

                switch (escolha)
                {
                    case '1':
                        Console.Write("Digite um item a ser adicionado: ");
                        char adicionarItem = Console.ReadKey().KeyChar;

                        lista.Add(adicionarItem);

                        Console.WriteLine($"'{adicionarItem}' adicionado à lista.");
                        break;

                    case '2':
                        if (lista.Count > 0)
                        {
                            Console.WriteLine("\nelementos da Lista");
                            foreach (var item in lista)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        else
                        {
                            Console.WriteLine("sua lista está vazia.");
                        }
                        break;

                    case '3':
                        if (lista.Count > 0)
                        {
                            Console.WriteLine("Qual elemento da Lista você gostaria de Remover? ");
                            foreach (var item in lista)
                            {
                                Console.WriteLine(item);
                            }
                            char ItemRemover = Console.ReadKey().KeyChar;
                            Console.WriteLine($"item removido: {ItemRemover}");
                            lista.Remove(ItemRemover);
                        }
                        else
                        {
                            Console.WriteLine("\nsua lista está vazia.");
                        }
                        break;

                    case '4':
                        if (lista.Count > 0)
                        {
                            Console.Write("Digite qual elemento voce deseja consultar: ");
                            char consulta = Console.ReadKey().KeyChar;
                            if (lista.Contains(consulta))
                            {
                                Console.WriteLine($"{consulta} está na lista!");
                            }
                            else
                            {
                                Console.WriteLine($"não foi encontrado {consulta} na lista");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Sua lista está vazia!");
                        }
                        break;

                    case '0':
                        MostrarMenuPrincipal();
                        return;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
        static void CriarFila()
        {
            Queue<char> fila = new Queue<char>();
            Console.WriteLine("\nCriar sua Fila");

            while (true)
            {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1 - adicionar item");
                Console.WriteLine("2 - remover item");
                Console.WriteLine("3 - Exibir fila");
                Console.WriteLine("4 - Consultar/Buscar Elemento");
                Console.WriteLine("0 - Voltar para o Menu Principal\n");

                char escolha = Console.ReadKey().KeyChar;

                switch (escolha)
                {
                    case '1':
                        Console.Write("\nDigite o item a ser enfileirado: ");
                        char enfileirarItem = Console.ReadKey().KeyChar;

                        fila.Enqueue(enfileirarItem);
                        Console.WriteLine($"\n{enfileirarItem} enfileirado.");

                        break;
                    case '2':
                        if (fila.Count > 0)
                        {
                            char desenfileirarItem = fila.Dequeue();
                            Console.WriteLine($"\n{desenfileirarItem} desenfileirado.");
                        }
                        else
                        {
                            Console.WriteLine("\nA fila está vazia.");
                        }
                        break;
                    case '3':
                        if (fila.Count > 0)
                        {
                            Console.WriteLine("elementos da Fila: ");
                            foreach (var item in fila)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nA fila está vazia.");
                        }
                        break;

                    case '4':
                        if (fila.Count > 0)
                        {
                            Console.Write("Digite qual elemento voce deseja consultar: ");
                            char consulta = Console.ReadKey().KeyChar;
                            if (fila.ToArray().Contains(consulta))
                            {
                                Console.WriteLine($"{consulta} está presente em sua Fila!");
                            }
                            else
                            {
                                Console.WriteLine($"Sua Fila não contém o elemento {consulta}!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Sua fila está vazia!");
                        }
                        break;

                    case '0':
                        MostrarMenuPrincipal();
                        return;
                    default:
                        Console.WriteLine("\nOpção inválida. Tente novamente.");
                        break;
                }
            }
        }

        static void CriarPilha()
        {
            Stack<char> pilha = new Stack<char>();
            Console.WriteLine("\nCriar sua Pilha");

            while (true)
            {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1 - adicionar item");
                Console.WriteLine("2 - remover item");
                Console.WriteLine("3 - Exibir pilha");
                Console.WriteLine("4 - Consultar/Buscar Elemento");
                Console.WriteLine("0 - Voltar para o Menu Principal");
                Console.WriteLine();

                char escolha = Console.ReadKey().KeyChar;

                switch (escolha)
                {
                    case '1':
                        Console.Write("Digite o item a ser empilhado: ");
                        char EmpilharItem = Console.ReadKey().KeyChar;
                        pilha.Push(EmpilharItem);
                        Console.WriteLine($"{EmpilharItem} empilhado.");
                        break;
                    case '2':
                        if (pilha.Count > 0)
                        {
                            char DesempilharItem = pilha.Pop();
                            Console.WriteLine($"{DesempilharItem} desempilhado.");
                        }
                        else
                        {
                            Console.WriteLine("sua pilha está vazia.");
                        }
                        break;
                    case '3':
                        if (pilha.Count > 0)
                        {
                            Console.WriteLine("\nelementos da Pilha");
                            foreach (var item in pilha)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nsua pilha está vazia.");
                        }
                        break;

                    case '4':
                        if (pilha.Count > 0)
                        {
                            Console.Write("Digite qual elemento voce deseja consultar: ");
                            char consulta = Console.ReadKey().KeyChar;
                            if (pilha.ToArray().Contains(consulta))
                            {
                                Console.WriteLine($"{consulta} está em sua pilha!");
                            }
                            else
                            {
                                Console.WriteLine($"Sua Pilha não contém o elemento {consulta}!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Sua fila está vazia!");
                        }
                        break;

                    case '0':
                        MostrarMenuPrincipal();
                        return;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }
        static void CriarVetor()
        {
            Console.WriteLine("Criar Vetor");
            Console.Write("por favor, digite qual tamanho que voce deseja ter em seu vetor: ");
            int tamanhoV, casa, i = 0;
            tamanhoV = int.Parse(Console.ReadLine());
            string[] vetor = new string[tamanhoV];
            string itemV;
            while (true)
            {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1 - adicionar item");
                Console.WriteLine("2 - remover item");
                Console.WriteLine("3 - Exibir Vetor");
                Console.WriteLine("4 - Consultar/Buscar Elemento");
                Console.WriteLine("0 - Voltar para o Menu Principal");
                Console.WriteLine();
                char escolha = Console.ReadKey().KeyChar;

                switch (escolha)
                {
                    case '1':
                        Console.Write("digite qual item que voce deseja adicionar em seu vetor: ");
                        if (vetor.Length != tamanhoV)
                        {
                            vetor[i] = Console.ReadLine(); i++;
                        }
                        else
                        {
                            Console.WriteLine("seu vetor está cheio!");
                        }
                        break;

                    case '2':
                        if (vetor.Length > 0)
                        {
                            vetor[i] = null; i--;
                            Console.WriteLine("ultimo item inserido no vetor foi removido...");
                        }
                        else
                        {
                            Console.WriteLine("Seu vetor está vazio!");
                        }
                        break;

                    case '3':
                        if (vetor.Length > 0)
                        {
                            foreach (string c in vetor)
                            {
                                Console.Write(c);
                            }
                        }
                        else
                        {
                            Console.WriteLine("seu vetor está vazio!");
                        }
                        break;

                    case '4':
                        if (vetor.Length > 0)
                        {
                            Console.WriteLine("digite qual item voce deseja verificar se existe dentro do vetor: ");
                            itemV = Console.ReadLine();
                            casa = Array.IndexOf(vetor, itemV);
                            if (casa != -1)
                            {
                                Console.WriteLine($"o vetor contém seu item {itemV} na posição {casa}!");
                            }
                            else
                            {
                                Console.WriteLine($"{itemV} não existe dentro de seu vetor");
                            }
                        }
                        else
                        {
                            Console.WriteLine("seu vetor está vazio!");
                        }
                        break;

                    case '0':
                        MostrarMenuPrincipal();
                        return;

                    default:
                        Console.WriteLine("opção invalida!");
                        break;
                }
            }
        }

        public class CriarMatrizPqIssoEhComplexo
        {
            private static string[,] matriz;
            private static int linMat;
            private static int colMat;
            
            public static void CriarMatriz()
            {
                Console.Clear();
                Console.WriteLine("Criar matriz");
                bool tamVal = false;
                do
                {
                    Console.WriteLine("Digite o numero de linhas e colunas " +
                        "da sua matriz separadas por espaço");
                    string[] lincolmatriz = Console.ReadLine().Split(' ');

                    if( lincolmatriz.Length==2 && 
                        int.TryParse(lincolmatriz[0], out linMat) && linMat > 0 &&
                        int.TryParse(lincolmatriz[1], out colMat) && colMat > 0 // ;---; if gigante do cacete, medo de dar erro
                        )
                    {
                        tamVal = true;
                    }
                    else
                    {
                        Console.WriteLine("por favor, digite um numero inteiro valido");
                        tamVal = false;
                    }
                }while (tamVal==false);
                matriz = new string[linMat,colMat];
                Console.WriteLine($"Você criou uma matriz {linMat}x{colMat} com sucesso" +
                    $"\nPressione qualquer tecla para continuar...");
                Console.ReadKey();

                //nota própria, as funções return dentro dos métodos chamados em casa case, voltaram para dentro deste while, não irão pedir para re-criar o tamanho da matriz

                while (true) 
                {
                    Console.Clear();
                    Console.WriteLine("Escolha uma opção: ");
                    Console.WriteLine("1 - adicionar item");
                    Console.WriteLine("2 - remover item");
                    Console.WriteLine("3 - Exibir Matriz");
                    Console.WriteLine("4 - Consultar/Buscar Elemento");
                    Console.WriteLine("0 - Voltar para o Menu Principal");
                    Console.WriteLine();

                    char escolha;
                    bool opcVal=false;
                    do
                    {
                        escolha = Console.ReadKey().KeyChar;

                        if((escolha == '1') || (escolha == '2') || (escolha == '3')|| (escolha == '4') || (escolha == '0'))
                        {
                            opcVal = true;
                        }
                        else
                        {
                            Console.WriteLine("escolha uma opção valida");
                        }
                    } while (opcVal == false);

                    switch (escolha)
                    {
                        case '1':
                            AddItem();
                            break;
                            
                        case '2':
                            RemItem();
                            break;

                        case '3':
                            ExibirItem();
                            break;

                        case '4':
                            ProcItem();
                            break;

                        case '0':
                            Console.WriteLine("pressione qualquer tecla para voltar ao menu principal...");
                            return;
                        default:
                            Console.WriteLine("digite uma opção valida!");
                            break;
                    }
                }
            }

            private static void AddItem()
            {
                Console.Clear();
                int j = 0,k = 0;

                if (matriz != null || !MatVazia(matriz))
                {
                    bool charvalido = false;
                    Console.WriteLine("Já existe uma matriz criada, ao adicionar item novamente, voce\n" +
                        "substituirá a matriz anterior, gostaria de prosseguir? :(1-sim / 2-não)");
                    do
                    {
                        char addDnv = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        if (addDnv == '1')
                        {
                            Console.WriteLine("Iniciando processo de substituição dos valores de sua matriz...");
                            charvalido = true;
                        }
                        else if (addDnv == '2')
                        {
                            Console.Write("Entendido, pressione qualquer tecla para voltar ao menu...");
                            Console.ReadKey();
                            return;
                        }
                        else
                        {
                            Console.WriteLine("por favor, digite um valor válido (1-sim / 2-não)");
                        }
                    }while (charvalido==false);
                }
                Console.WriteLine("você ja pode escrever os elementos de sua matriz!");
                for (j=0;j<linMat;j++)
                {
                    for (k=0;k<colMat;k++)
                    {
                        matriz[j,k]=Console.ReadLine();
                    }
                }
                return;
            }
            private static void RemItem()
            {
                Console.Clear();
                if (matriz == null || MatVazia(matriz))
                {
                    Console.WriteLine("Sua matriz está vazia ou não foi criada!");
                    Console.ReadKey();
                    return;
                }

                bool contRem = true;
                do
                {
                    ExibirItem();
                    Console.WriteLine("\nPara remover, digite a linha e a coluna do item que deseja remover (começando de 0 e separadas por espaço, ex: 0 1  irá eliminar o elemento da linha 0 coluna 1).");
                    Console.WriteLine("Digite 'sair' para voltar ao menu da matriz.");

                    string input = Console.ReadLine();
                    if (input.ToLower() == "sair")
                    {
                        contRem = false;
                        continue;
                    }

                    string[] coords = input.Split(' ');
                    int linRem, colRem;

                    if (coords.Length == 2 &&
                        int.TryParse(coords[0], out linRem) &&
                        int.TryParse(coords[1], out colRem) &&
                        linRem >= 0 && linRem < linMat &&
                        colRem >= 0 && colRem < colMat)
                    {
                        if (!string.IsNullOrEmpty(matriz[linRem, colRem]))
                        {
                            Console.WriteLine($"Removendo '{matriz[linRem, colRem]}' da posição [{linRem},{colRem}]");
                            matriz[linRem, colRem] = null; 
                            Console.WriteLine("Item removido com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Esta posição já está vazia!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Coordenadas inválidas, digite a linha e a coluna corretamente.");
                    }
                    Console.ReadKey(); 
                } while (contRem);
            }

            private static void ExibirItem()
            {
                Console.Clear();
                if (matriz == null || MatVazia(matriz))
                {
                    Console.WriteLine("Sua matriz está vazia ou não foi criada!");
                    Console.ReadKey();
                    return;
                }

                Console.WriteLine("Elementos da Matriz:");
                for (int j = 0; j < linMat; j++)
                {
                    for (int k = 0; k < colMat; k++)
                    {
                        Console.Write($"[{j},{k}]: {matriz[j, k] ?? "Vazio"}\t");//(tentando usar interrogação, objetivo: só mostrar vazio caso não haja elemento)
                    }
                    Console.WriteLine(); 
                }
                Console.ReadKey();
            }

            private static void ProcItem()
            {
                Console.Clear();
                if (matriz == null || MatVazia(matriz))
                {
                    Console.WriteLine("Sua matriz está vazia ou não foi criada!");
                    Console.ReadKey();
                    return;
                }

                Console.Write("Digite o item que você quer buscar na matriz: ");
                string itemBuscar = Console.ReadLine();
                bool encontrado = false;

                Console.WriteLine($"\nBuscando '{itemBuscar}' na matriz...");
                for (int j = 0; j < linMat; j++)
                {
                    for (int k = 0; k < colMat; k++)
                    {
                        if (matriz[j, k] != null && matriz[j, k].Equals(itemBuscar, StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine($"O item '{itemBuscar}' foi encontrado na posição [{j},{k}].");
                            encontrado = true;
                        }
                    }
                }
                if (encontrado==false)
                {
                    Console.WriteLine($"O item '{itemBuscar}' não foi encontrado na matriz.");
                }
                Console.ReadKey();
            }
            private static bool MatVazia(string[,] mat)
            {
                if (mat.Length==0)
                {
                    return true;
                }
                foreach (var item in mat)
                {
                    if (!string.IsNullOrEmpty(item))
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}

