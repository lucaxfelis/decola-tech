using System;

namespace TipoCombustivel
{
    class TipoCombustivel
    {
        static void Main(string[] args) 
        { 
            // variáveis de contagem de votos
            int alcool = 0, gasolina = 0, diesel = 0;
            // variável de controle do laço while
            bool keep = true;
            do
            {
                // recebe a entrada e converte para inteiro  
                int entrada = Convert.ToInt32(Console.ReadLine());
                    
                // incrementa as variáveis de contagem de acordo com a entrada
                switch (entrada)
                {
                    case 1:
                        alcool++;
                        break;
                    case 2:
                        gasolina++;
                        break;
                    case 3:
                        diesel++;
                        break;
                    case 4:
                        // altera o controle para sair do looping
                        keep = false;
                        break;
                    default:                       
                        continue;
                }
            }
            while (keep);
            // imprime as mensagem de resultado na tela
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
        }
    }
}
