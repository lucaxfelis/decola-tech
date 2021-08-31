using System;

namespace SequenciaLogica
{
    class SequenciaLogica
    {
        static void Main(string[] args)
        {
            // recebe e divide as entradas por espaço
            string[] vet = Console.ReadLine().Split(' ');
            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);
            
            // laço for que percorre todos os número de 1 a y
            for (int i = 1; i<=y; i++)
            {
                Console.Write(i);
                // testa se é a vez do número da ponta (múltiplo de x)
                if (((i % x) == 0))
                {
                    // caso afirmativo, pula uma linha
                    Console.WriteLine();
                }
                else
                {
                    // em caso negativo, escreve um espaço
                    Console.Write(" ");
                }
            }
        }
    }
}
