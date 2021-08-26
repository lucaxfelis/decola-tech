using System;

namespace Multiplos
{
     class minhaClasse 
     {
        static void Main(string[] args) 
        {            
            // criando array de strings
            // separando a string de entrada por espaços
            string[] valores = Console.ReadLine().Split(' ');
            
            // convertendo as strings de entrada em inteiros
            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]);

            // testando se B é divisor de A ou vice e versa
            if (A % B == 0  || B  % A == 0) 
            {
                Console.WriteLine("Sao Multiplos");
            }
            else 
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
