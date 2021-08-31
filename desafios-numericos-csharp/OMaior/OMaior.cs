using System;

namespace OMaior
{
    class OMaior
    {
        static void Main(string[] args)
        {
          // recebendoo a entrada e separando por espaços
          string[] vet = Console.ReadLine().Split(' ');

          // criando as variáveis auxiliares
          int a = int.Parse(vet[0]);
          int b = int.Parse(vet[1]);
          int c = int.Parse(vet[2]);

          // retorna o maior entre a e b
          int MAIORAB = (a+b+Math.Abs(a-b))/2;
          
          // retorna o maior entre todos
          int MAIOR = (MAIORAB+c+Math.Abs(MAIORAB-c)) / 2;

          // imprime o resultado
          Console.WriteLine($"{MAIOR} eh o maior");             
        }
    }
}
