using System;
namespace Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dimensoes = Console.ReadLine().Split(' ');
            int M = int.Parse(dimensoes[0]);
            int N = int.Parse(dimensoes[1]);

            int[,] matriz = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                string[] linha = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    matriz[i, j] = int.Parse(linha[j]);
                }
            }

            Console.WriteLine("VALORES NEGATIVOS:");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        Console.WriteLine(matriz[i, j]);
                    }
                }
            }
        }
    }
}
