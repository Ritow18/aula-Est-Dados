using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace pilha
{
    class pilha
    {
        private char[] elementos;
        private int topo, tamanho;
        public pilha(int capacidade)
        {
            elementos = new char[capacidade];
            topo = -1;
            tamanho = 0;

        }
        //método para adicionar elementos na pilha
        public void push(char cara)
        {
            //validação futura
            if (tamanho == elementos.Length)
            {
                Console.WriteLine("A pilha está cheia!");
                return;
            }
            elementos[++topo] = cara;
            tamanho++;
        }
        //método para mostrar quais são os elementos da pilha
        public void exibir()
        {
            //validacao futuras
            if (Empty())
            {
                Console.WriteLine("Sua pilha está vazia!");
                return;
            }
            Console.WriteLine("Pilha: ");
            for (int i = topo; i >= 0; i--)
            {
                Console.WriteLine(" " + elementos[i]);
            }
        }
        // método para retornar o tamanho da pilha 
        public int size()
        {
            return tamanho;
        }
        //metodo para obter o elemento do topo da pilha
        public char top()
        {
            //validações futuras
            if (Empty())
            {
                Console.WriteLine("a pilha está sem elementos para ser mostrado!");
                return '\0'; // ao lado do return, é a mesma coisa que dizer que ele é nulo "null"
            }
            else
            {
                return elementos[topo];
            }
        }
        //metodo para conseguir remover o elemento do topo da torre
        public char pop()
        {
            if (Empty())
            {
                Console.WriteLine("sua pilha está vazia! não há elementos para ser retirado");
            }

            char c = elementos[topo--];
            tamanho--;
            return c;
        }

        public bool Empty()
        {
            return tamanho == 0;
        }


        class Program
        {
            static void Main()
            {
                pilha pilha = new pilha(10);
                char opcao;

                do
                {
                    Console.WriteLine("escolha uma opção: ");
                    Console.WriteLine("1 - Inserir um elemento na Pilha: ");
                    Console.WriteLine("2 - Remover um elemento da Pilha: ");
                    Console.WriteLine("3 - Exibir os elementos da Pilha: ");
                    Console.WriteLine("4 - Mostrar o topo da Pilha: ");
                    Console.WriteLine("5 - Mostrar o tamanho da Pilha: ");
                    Console.WriteLine("0 - Sair: ");

                    opcao = Console.ReadKey().KeyChar; // le somente uma tecla 
                    Console.ReadLine();
                    switch (opcao)
                    {
                        case '1':
                            Console.WriteLine(" ");
                            char cara = Console.ReadKey().KeyChar;
                            Console.WriteLine();
                            pilha.push(cara);
                            break;
                        case '2':
                            Console.WriteLine("Elemento removido: " + pilha.pop());
                            break;
                        case '3':
                            pilha.exibir();
                            break;
                        case '4':
                            Console.WriteLine("Topo da pilha: " + pilha.top());
                            break;
                        case '5':
                            Console.WriteLine("Tamanho da Pilha: " + pilha.size());
                            break;
                        case '0':
                            Console.WriteLine("Saindo...");
                            break;
                        default:
                            Console.WriteLine("Opção invalida!");
                            break;
                    }
                } while (opcao != '0');
            }
        }
    }
}
