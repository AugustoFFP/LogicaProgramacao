/* Estrutura de Repetição com teste no Final.
 * Exerc043 - Criar um analisador de números que serão digitados pelo usuário e
 * após digitar o número perguntar se ele quer continuar.
 * Ao final mostrar:
 * - Quantos números foram digitados.
 * - Quantos desses são pares.
 * - Mostrar o menor número ímpar digitado.
 * */
using System;

class program
{
    static void Main(string[] args)
    {
        string continuar = "";
        int numerosDigitados = 0;
        int pares = 0;

        int menor = 0;


        do
        {
            Console.WriteLine("Deseja continuar? [s/n]");
            continuar = Console.ReadLine().ToLower();

            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            numerosDigitados++;

            if (numero % 2 == 0)
            {
                pares++;
            }
            else if (numero % 2 == 1)
            {
                if (numerosDigitados == 1)
                {
                    menor = numero;
                }
                else if (numero < menor)
                {
                    menor = numero;
                }
            }

        } while (continuar != "n");

        Console.WriteLine($"Ao todo foram digitados {numerosDigitados}.");
        Console.WriteLine($"Entre esses {pares} são pares.");
        Console.WriteLine($"O menor número ímpar digitado é o {menor}.");
    }
}