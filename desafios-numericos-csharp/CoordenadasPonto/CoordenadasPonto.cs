using System;

namespace CoordenadasPonto
{
    class CoordenadasPonto
    {
        static void Main(string[] args)
        { 
            // recebe a entrada e separa por espaço
            string[] valores = Console.ReadLine().Split(' ');
            // convertendo as entradas para double
            double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double y = double.Parse(valores[1], CultureInfo.InvariantCulture);
        
            // origem: (0, 0)
            if (x == 0 && y == 0) 
            {
                Console.WriteLine("Origem");
            }
            // eixo y: (0, y)
            else if (x == 0) 
            {
                Console.WriteLine("Eixo Y");
            }
            // eixo x: (x, 0)
            else if (y == 0) 
            {
                Console.WriteLine("Eixo X");
            }
            // primeiro quadrante
            else if (x > 0 && y > 0) 
            {
                Console.WriteLine("Q1");
            }
            // segundo quadrante
            else if (x < 0.0 && y > 0.0) 
            {
                Console.WriteLine("Q2");
            }
            // terceiro quadrante
            else if (x < 0.0 && y < 0.0) 
            {
                Console.WriteLine("Q3");
            }
            // de resto, quarto quadrante
            else 
            {
                Console.WriteLine("Q4");
            }
        }
    }
}
