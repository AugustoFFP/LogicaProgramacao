/* Exerc047 - Contar de um número até o outro com dois valores informados pelo usuário.*/

using System;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Qual número inicial?");
        int numeroInicial = int.Parse(Console.ReadLine());

        Console.WriteLine("Qual o número final?");
        int numeroFinal = int.Parse(Console.ReadLine());

        Console.WriteLine("De quantos em quantos você quer pular?");
        int pular = int.Parse(Console.ReadLine());

        int soma = 0;

        for (int contador = numeroInicial; contador <= numeroFinal; contador = contador + pular )
        {

            if (contador == numeroInicial)
            {
                Console.WriteLine($"Contar do número {numeroInicial} até {numeroFinal} pulando de {pular} em {pular}.");
            }

            Console.WriteLine(" ");
            Console.WriteLine(contador);

        }
    }
}
