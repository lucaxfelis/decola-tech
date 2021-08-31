using System;

namespace ValidacaoNota
{
    class ValidacaoNota
    {
        public static void Main()
        {
    
            // define algumas variáveis
            double somaDasNotas = 0;
            int contador = 0;
            
            // laço do while que recebe notas até que duas delas sejam validadas
            do
            {
                // converte as entradas para double
                double notaEntradaConsole = double.Parse(Console.ReadLine());
                
                // testa se a entrada é válida 0 <= entrada <= 10
                if(notaEntradaConsole < 0 | notaEntradaConsole > 10)
                {
                    Console.WriteLine("nota invalida");
                } else 
                {
                    // valida a nota
                    contador++;
                    somaDasNotas += notaEntradaConsole; 
                }
                
            // enquanto duas notas foram validadas  
            } 
            while (contador < 2);
            
            // escreve o resultado
            Console.WriteLine("media = " + (somaDasNotas / 2).ToString("N2"));
        }
    }
}
