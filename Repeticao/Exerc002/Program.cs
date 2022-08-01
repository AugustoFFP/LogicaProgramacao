/* Realizando cálculos em laços.
 * Exerc033 - Fazer um programa que pergunte quantos números quer sortear
 * ao final somar todos esses números.*/
using System;

class program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        Console.WriteLine("Quantos números você quer que eu sorteie?");
        int contador = int.Parse(Console.ReadLine());

        int contador2 = 1;

        int soma = 0;

        while (contador2 <= contador)
        {
            Console.WriteLine($"Sorteando o {contador2} número: ");
            int valor = random.Next(1, 10);
            soma = valor + soma;
            Console.WriteLine($"{valor}");


            contador2++;
        }

        Console.WriteLine("-----------------");
        Console.WriteLine($"O resultado foi {soma}");

        

    }
}