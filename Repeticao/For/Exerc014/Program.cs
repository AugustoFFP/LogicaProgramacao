/* Estrutura de Variável de Controle 
 * Exerc046 - Fazer uma tabuada comum.*/

using System;

class program
{
    static void Main(string[] args)
    {
        for (int i = 0; i <= 10; i++)
        {
            int valor = 9;
            int soma = valor * i; 

            Console.WriteLine($"9 x {i} = {soma}");
        }

    }
}