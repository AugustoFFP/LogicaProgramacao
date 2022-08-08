/* Exerc 050 - Perguntar a tabuada inicial e a final, em seguida fazer a sequência. */
using System;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Qual tabuada inicial?");
        int tabuadaInicial = int.Parse(Console.ReadLine());

        Console.WriteLine("Qual a tabuada final?");
        int tabuadaFinal = int.Parse(Console.ReadLine());

        int soma = 0;

        for(int contador = tabuadaInicial; contador <= tabuadaFinal; contador++)
        {
            Console.WriteLine($"TABUADA DE {contador}");

            for (int contador2 = 0; contador2 <= 10; contador2++)
            {
                soma = contador * contador2;
                Console.WriteLine($"{contador} x {contador2} = {soma}");
            }

        }

    }
}