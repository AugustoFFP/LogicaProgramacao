/* Ex01: Programa que leia 3 números inteiros e mostre-os em ordem crescente.
Se por acaso eles forem iguais, informe que não existe a necessidade de colocá-los em ordem.
Estrutura Aninhada*/
using System;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Primeiro valor: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor: ");
        int numero2 = int.Parse(Console.ReadLine());

        Console.WriteLine("terceiro valor: ");
        int numero3 = int.Parse(Console.ReadLine());

        int maior = 0, menor = 0, meio = 0;

        if (numero1 > numero2 && numero1 > numero3)
        {
            if (numero2 > numero3)
            {
                maior = numero1;
                meio = numero2;
                menor = numero3;
            }
            else if (numero3 > numero2)
            {
                maior = numero1;
                meio = numero3;
                menor = numero2;
            }
        }
        else if (numero2 > numero1 && numero2 > numero3)
        {
            if (numero1 > numero3)
            {
                maior = numero2;
                meio = numero1;
                menor = numero3;
            }
            else if (numero3 > numero1)
            {
                maior = numero2;
                meio = numero3;
                menor = numero1;
            }
        }
        else if (numero3 > numero2 && numero3 > numero1)
        {
            if (numero1 > numero2)
            {
                maior = numero3;
                meio = numero1;
                menor = numero2;
            }
            else if (numero2 > numero1)
            {
                maior = numero3;
                meio = numero2;
                menor = numero1;
            }
        } else
        {
            Console.WriteLine("Os números são iguais!");
            
        }
        Console.WriteLine($"O maior é o {maior}, meio {meio}, e o menor {menor}.");
    }
}