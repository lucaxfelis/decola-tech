using System;

namespace ConversaoTempo
{
    class ConversaoTempo 
    {
        static void Main(string[] args) 
        {
            // variável do tempo em segundos
            var tempoSegundos = int.Parse(Console.ReadLine());
            // variável do tempo em horas
            var horas = tempoSegundos / (60 * 60);
            // computa o tempo excluindo as horas
            tempoSegundos = tempoSegundos % (60 * 60);
            // calcula o tempo em minutos
            var minutos = tempoSegundos / 60;
            // o resto dos segundos será o tempo em segundos
            var segundos = tempoSegundos % 60;
            Console.WriteLine($"{horas}:{minutos}:{segundos}");
        }
    }
}
