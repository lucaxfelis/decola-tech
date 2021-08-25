using System;

namespace SomaSimples
{
    class SomaSimples
    {
        static void Main(string[] args)
        {
            // declarando as variáveis
            // convertendo os valores de string para inteiro
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
        
            // criando a variável soma e somando os valores
            int SOMA = A + B;

            // escrevendo resultado na tela com interpolação de string
            Console.WriteLine($"SOMA = {SOMA}");
        }
    }
}
