using System;
namespace Fila_manual
{
    class Program
    {
        class fila
        {
            private char[] elementos;
            private int inicio, fim, tamanho, capacidade;
            public fila(int capacidade)
            {
                this.capacidade = capacidade;
                elementos = new char[capacidade];
                inicio = 0;
                fim = -1;
                tamanho = 0;
            }
            public bool empty()
            {
                return tamanho == 0;
            }
            public void enqueue(char carac)
            {
                if (tamanho == capacidade)
                {
                    Console.WriteLine("fila cheia");
                    return;
                }
                fim = (fim + 1) % capacidade;
                elementos[fim] = carac;
                tamanho++;
            }
            public char dequeue()
            {
                if (empty())
                {
                    Console.WriteLine("a fila está vazia!");
                    return '\0';
                }
                char valor = elementos[inicio];
                inicio = (inicio + 1) % capacidade;
                tamanho--;
                return valor;
            }
            public void exibir()
            {
                if (empty())
                {
                    Console.WriteLine("a fila está vazia!");
                    return;
                }
                Console.WriteLine("fila: ");
                for (int i = 0; i < tamanho; i++)
                {
                    int index = (inicio + i) % capacidade;
                    Console.Write(elementos[index] + " ");
                }
                Console.WriteLine();
            }
            public int size()
            {
                return tamanho;
            }
            public char head()
            {
                return elementos[inicio];
            }
        }
        static void Main(string[] args)
        {
            fila fila = new fila(10);
            char valor, opcao;
            do
            {
                Console.WriteLine("Escolha uma das seguintes opções: ");
                Console.WriteLine("0 - sair");
                Console.WriteLine("1 - enfileirar");
                Console.WriteLine("2 - head");
                Console.WriteLine("3 - desenfileirar");
                Console.WriteLine("4 - tamanho da fila");
                Console.WriteLine("5 - Exibir elementos da fila");
                opcao = Console.ReadKey().KeyChar;
                switch (opcao)
                {
                    case '0':
                        Console.WriteLine("Finalizando o sistema...");
                        break;
                    case '1':
                        Console.WriteLine("Digite o valor para entrar na fila");
                        valor = Console.ReadKey().KeyChar;
                        fila.enqueue(valor);
                        break;
                    case '2':
                        valor = fila.head();
                        Console.WriteLine("inicio da fila: " + valor);
                        break;
                    case '3':
                        valor = fila.dequeue();
                        Console.WriteLine("elemento desenfileirado: " + valor);
                        break;
                    case '4':
                        Console.WriteLine("quantidade de elementos da fila" + fila.size());
                        break;
                    case '5':
                        fila.exibir();
                        break;
                }
            } while (opcao != '0');
        }
    }
}
