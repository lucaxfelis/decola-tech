using System;

namespace NumerosImpares
{
    class minhaClasse 
    {
        public static void Main()
        {
            // criação de variável e conversão em inteiro
            int n;
            n = int.Parse(Console.ReadLine());
            // laço for que inicia em 1 e tem passo 2
            for (int i = 1; i <= n; i+=2) //complete seu codigo
            {
                Console.WriteLine(i);
            }
            
            Console.ReadLine();
        }
    }
}
