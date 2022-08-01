/* Realizando cálculos em Laços.
 * Exerc032 - Soma Par ou Ímpar.*/
using System;

class program
{
    static void Main(string[] args)
    {
        int contador = 1;
        int pares = 0;
        int impares = 0;

        int soma1 = 0;
        int soma2 = 0;


        while (contador <= 5)
        {
            Console.WriteLine($"Digite o {contador}º valor: ");
            int valor = int.Parse(Console.ReadLine());

            if(valor % 2 == 0)
            {
                pares++;
                soma1 = soma1 + valor;
            } else
            {
                impares++;
                soma2 = soma2 + valor;
            }
            contador++;
        }
        Console.WriteLine($"Ao todo temos {pares} números pares.");
        Console.WriteLine($"Ao todo temos {impares} números ímpares.");

        Console.WriteLine($"O resultado das soma dos pares é: {soma1}");
        Console.WriteLine($"O resultado das soma dos ímpares é: {soma2}");

    }
}