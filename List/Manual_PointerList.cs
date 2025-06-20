using System;
namespace PointerList
{
    class No
    {
        public char Valor;
        public No Proximo;

        public No(char valor)
        {
            Valor = valor;
            Proximo = null;
        }
    }
    class ListaDinamica
    {
        private No inicio;
        public ListaDinamica()
        {
            inicio = null;
        }
        public void Inserir(char Valor)
        {
            No novo = new No(Valor);
            if (inicio == null)
            {
                inicio = novo;
            }
            else
            {
                No atual = inicio;
                while (atual.Proximo != null)
                {
                    atual = atual.Proximo;
                }
                atual.Proximo = novo;
            }
        }
        public void InserirNaPosição(int pos, char valor)
        {
            No novo = new No(valor);

            if (pos == 0)
            {
                novo.Proximo = inicio;
                inicio = novo;
                return;
            }

            No atual = inicio;
            for (int i = 0; i < pos - 1; i++)
            {
                if (atual == null)
                {
                    Console.WriteLine("Posição Invalida.");
                    return;
                }
                atual = atual.Proximo;
            }
            if (atual == null)
            {
                Console.WriteLine("Posição invalida.");
            }
            novo.Proximo = atual.Proximo;
            atual.Proximo = novo;
        }

        public void Remover(int pos)
        {
            if (inicio == null)
            {
                Console.WriteLine("Lista vazia");
                return;
            }
            if (pos == 0)
            {
                inicio.Proximo = inicio;
                return;
            }
            No atual = inicio;
            for (int i = 0; i < pos - 1; i++)
            {
                if (atual.Proximo == null)
                {
                    Console.WriteLine("Posição Invalida.");
                    return;
                }
                atual = atual.Proximo;
            }
            if (atual == null)
            {
                Console.WriteLine("Posição invalida.");
            }
            atual.Proximo = atual.Proximo.Proximo;
        }
        public void Exibir()
        {
            if (inicio == null)
            {
                Console.WriteLine("Lista vazia");
                return;
            }

            Console.WriteLine("Lista: ");
            No atual = inicio;
            while (atual != null)
            {
                Console.WriteLine(atual.Valor + " ");
                atual = atual.Proximo;
            }
            Console.WriteLine();
        }
        public int Size()
        {
            int cont = 0;
            No atual = inicio;
            while (atual != null)
            {
                cont++;
                atual = atual.Proximo;
            }
            return cont;
        }
        public bool Empty()
        {
            return inicio == null;
        }
        public char ElementosNaPosicao(int pos)
        {
            No atual = inicio;
            int cont = 0;

            while (atual != null)
            {
                if (cont == pos)
                {
                    return atual.Valor;
                }
                atual = atual.Proximo;
                cont++;
            }
            Console.WriteLine("Posição invalida.");
            return '\0';
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                ListaDinamica Lista = new ListaDinamica();
                int opcao;
                char valor;
                int pos;

                do
                {
                    Console.WriteLine("\nLISTA DINÂMICA");
                    Console.WriteLine("0. Sair");
                    Console.WriteLine("1. Inserir no final");
                    Console.WriteLine("2. Inserir na posição especifica");
                    Console.WriteLine("3. Remover por posição");
                    Console.WriteLine("4. Tamanho da Lista");
                    Console.WriteLine("5. Exibir lista");
                    Console.WriteLine("6. Exibir elementos na posição");
                    Console.WriteLine("Escolha uma opção: ");
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
                            Lista.Inserir(valor);
                            break;

                        case 2:
                            Console.WriteLine("Digite a posição");
                            pos = int.Parse(Console.ReadLine());
                            Console.WriteLine("Digite o valor: ");
                            valor = Console.ReadKey().KeyChar;
                            Console.WriteLine();
                            Lista.InserirNaPosição(pos, valor);
                            break;

                        case 3:
                            Console.WriteLine("Digite a posicão para remover");
                            pos = int.Parse(Console.ReadLine());
                            Lista.Remover(pos);
                            break;

                        case 4:
                            Console.WriteLine("Tamanho atual: " + Lista.Size());
                            break;

                        case 5:
                            Lista.Exibir();
                            break;

                        case 6:
                            Console.WriteLine("Digite a posição: ");
                            pos = int.Parse(Console.ReadLine());
                            valor = Lista.ElementosNaPosicao(pos);
                            Console.WriteLine("Elementos: " + valor);
                            break;

                        default:
                            Console.WriteLine("Opçãp invalida!");
                            break;
                    }

                } while (opcao != 0);
            }
        }
    }
}
