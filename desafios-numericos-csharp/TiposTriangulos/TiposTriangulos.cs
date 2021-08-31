using System;

namespace TiposTriangulos
{
    class TiposTriangulos
    {
        public static void Main()
        {
            // divide a entrada por espaços
            string[] s = Console.ReadLine().Split(' ');
            
            // método da classe Array que ordena (crescente) array
            Array.Sort(s);
            
            // atribuição de variáveis
            double c = double.Parse(s[0]);
            double b = double.Parse(s[1]);
            double a = double.Parse(s[2]);

            // bateria de testes solicitados
            if (a > (b + c))
                Console.WriteLine("NAO FORMA TRIANGULO");
            else if (a*a == (b*b + c*c))
                Console.WriteLine("TRIANGULO RETANGULO");
            else if (a*a > (b*b + c*c))
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            else if (a*a < (b*b + c*c))
                Console.WriteLine("TRIANGULO ACUTANGULO");
            if (a == b && b == c)
                Console.WriteLine("TRIANGULO EQUILATERO");
            // teste igualdade e desigualdade entre pares de lados
            if ((a == b & a != c) || (b == c & b != a) || (c == a & c != b))
                Console.WriteLine("TRIANGULO ISOSCELES");

            Console.ReadLine();
        }
    }
}
