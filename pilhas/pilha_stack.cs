using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_pilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<char> pilha = new Stack<char>();
            char opcao;
            do
            {
                Console.WriteLine("escolha uma opção: ");
                Console.WriteLine("1 - Inserir elemento na Pilha: ");
                Console.WriteLine("2 - Remover elemento da Pilha: ");
                Console.WriteLine("3 - Exibir elementos da Pilha: ");
                Console.WriteLine("4 - Mostrar topo da Pilha: ");
                Console.WriteLine("5 - Mostrar tamanho da Pilha: ");
                Console.WriteLine("0 - Sair: ");
                opcao = Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch (opcao)
                {
                    case '1':
                        Console.WriteLine("digite o caractere que deseja empilhar");
                        char cara = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        pilha.Push(cara);
                        break;
                    case '2':
                        if (pilha.Count > 0)
                            Console.WriteLine("elemento de cima removido: " + pilha.Pop());
                        else
                            Console.WriteLine("Pilha vazia");
                            break;
                    case '3':
                        if (pilha.Count == 0)
                            Console.WriteLine("Pilha vazia");
                        else
                            Console.WriteLine("elementos da pilha: ");
                        foreach(var item in pilha)
                        {
                            Console.WriteLine(" " + item);
                        }
                            break;
                    case '4':
                        if (pilha.Count > 0)
                            Console.WriteLine("o topo da pilha é o: " + pilha.Peek());
                        else
                            Console.WriteLine("não há nenhum item na pilha");

                            Console.WriteLine();

                        break;
                    case '5':
                        Console.WriteLine("o tamanho da pilha é:"+pilha.Count);
                        Console.WriteLine();
                        break;
                    case '0':
                        Console.WriteLine("saindo....");
                        break;
             
                }
                Console.WriteLine();

            } while (opcao != '0');

        }
    }
}
