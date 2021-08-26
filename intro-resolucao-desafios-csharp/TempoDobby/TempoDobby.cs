using System;

namespace TempoDobby
{
    class TempoDobby 
    {
        static void Main(string[] args) 
        {
            // recebe a entrada e converte em inteiros
            var minutosFinais = int.Parse(Console.ReadLine());
            
            // recebe a entrada e separa por espaços
            string[] tokens = Console.ReadLine().Split(" ");
            
            // converte todos os elementos do array tokens em inteiros
            int[] itens = Array.ConvertAll<string, int>(tokens, int.Parse);

            // soma os tempos
            int tempoPresente1 = itens[0];
            int tempoPresente2 = itens[1];
            int tempoPresentes = tempoPresente1 + tempoPresente2;
            
            // testa se o tempo total será suficiente
            if (tempoPresentes <= minutosFinais) 
            {
                Console.WriteLine("Farei hoje!");
            }
            else 
            {
                Console.WriteLine("Deixa para amanha!");
            }
        }
    }
}
