/* Estrutura de Variável de Controle 
 * Exerc015 - Contar de 0 até 100 mostrando todos os números ímpares.*/

using System;

class program
{
    static void Main(string[] args)
    {
        for (int contador = 0; contador <= 100; contador++)
        {
            if (contador % 2 == 1)
            {
                Console.WriteLine(contador + "  ");
            }
        }
    }
}