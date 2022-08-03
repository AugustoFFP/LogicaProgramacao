/* Estrutura de Variável de Controle 
 * Exerc017 - Mostrar se um número é primo.
 * */
using System;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        int soma = 0;


        for (int contador = 1; contador <= numero; contador++)
        {

            if (contador > 2)
            {
                Console.Write($"{contador} - ");
            }


            if (numero % contador == 0)
            {
                Console.Write($"[{contador}] - ");
                soma++;
            }


        }
        if (soma <= 2)
        {
            Console.WriteLine("O número é Primo!");
        }
        else
        {
            Console.WriteLine("O número não é Primo!");
        }
    }
}


