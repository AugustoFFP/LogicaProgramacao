/* Variável de Controle
 * Exerc049 - Fazer a sequência de fibonacci. */

using System;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quantos elementos você quer exibir? ");
        int elementos = int.Parse(Console.ReadLine());

        int somaAnterior = 0;

        int somaSucessor = 1;

        int soma = 0;

        Console.WriteLine(somaAnterior);

        soma = somaAnterior + somaSucessor;
        Console.WriteLine(soma);

        for (int contador = 0; contador <= elementos; contador++)
        {
            soma = somaAnterior + somaSucessor;
            somaAnterior = somaSucessor;
            somaSucessor = soma;
            Console.WriteLine($"{somaSucessor}");


        }
        Console.WriteLine("FIM!");
    }
}