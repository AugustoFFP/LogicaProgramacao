/* Estrutura com repetição no Final 
 * Exerc045 - Você vai ter 3 chances de acertar um número sorteado.
 * Caso erre o programa deverá mostrar se é maior ou menor que o valor informado.*/

using System;

class program
{
    static void Main(string[] args)
    {
        Random numero = new Random();
        int num = numero.Next(1, 10);

        int maior = 0;
        int menor = 0;

        int contador = 1;

        do
        {
            Console.WriteLine("Qual número você acha que é? ");
            int tentativa1 = int.Parse(Console.ReadLine());

            if(tentativa1 == num)
            {
                Console.WriteLine("Parabéns você acertou!");
                break;
            } else if (contador == 1)
            {
                contador++;
                maior = num;
                menor = num;
                if(tentativa1 > num)
                {
                    Console.WriteLine("O número é menor!");
                } else if (tentativa1 < num)
                {
                    Console.WriteLine("O número é maior!");
                }
            }
            Console.WriteLine("2 Tentativa - Qual número você acha que é? ");
            int tentativa2 = int.Parse(Console.ReadLine());
            if (tentativa2 == num)
            {
                Console.WriteLine("Parabéns você acertou!");
                break;
            }
            else if (contador == 2)
            {
                contador++;
                maior = num;
                menor = num;
                if (tentativa2 > num)
                {
                    Console.WriteLine("O número é menor!");
                }
                else if (tentativa2 < num)
                {
                    Console.WriteLine("O número é maior!");
                }
            }

            Console.WriteLine("3 Tentativa - Qual número você acha que é? ");
            int tentativa3 = int.Parse(Console.ReadLine());
            if (tentativa3 == num)
            {
                Console.WriteLine("Parabéns você acertou!");
                break;
            }
            else if (contador == 3)
            {
                contador++;
                maior = num;
                menor = num;
                if (tentativa3 > num)
                {
                    Console.WriteLine("O número é menor!");
                }
                else if (tentativa3 < num)
                {
                    Console.WriteLine("O número é maior!");
                }
            }
        } while (contador <= 3);
    }
}