using System;
namespace Vetor_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] nomes = new string[N];
            int[] idades = new int[N];
            for (int i = 0; i < N; i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                nomes[i] = entrada[0];
                idades[i] = int.Parse(entrada[1]);
            }
            int maiorIdade = idades[0];
            int posMaisVelha = 0;
            for (int i = 1; i < N; i++)
            {
                if (idades[i] > maiorIdade)
                {
                    maiorIdade = idades[i];
                    posMaisVelha = i;
                }
            }
            Console.WriteLine("Pessoa mais velha: " + nomes[posMaisVelha]);
        }
    }
}
