using System;
using SaveRian.UseCases;

namespace SaveRian
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Por favor, digite o número total de participantes dessa sadia brincadeira.");

          
            var totalParticipantes = Console.ReadLine();
            int intTotalParticipantes;
            if(!Int32.TryParse(totalParticipantes,out intTotalParticipantes))
            {
                Console.WriteLine("O valor deve ser um número inteiro.");
                return;
            }

            Console.WriteLine($" - - A posição segu ra para Rian é: {BrincadeiraMortal.RetornaPosicaoSegura(intTotalParticipantes)}");      
        }
    }
}
