/* Repetição com Flag
 * Exerc039 - Ler vários números e digitar 9999 para parar.
 *  - Quantos valores foram digitados.
 *  - A soma entre eles
 *  - A média dos valores.
 *  - Qual foi o maior valor digitado.*/
using System;

class program
{
    static void Main(string[] args)
    {
        int contador = 0;

        double soma = 0;

        int maior = 0;
        int menor = 0;

        while (true)
        {
            Console.WriteLine($"{contador}º valor [digite 9999 para encerrar]");
            Console.WriteLine("----------------------------------------------");
          

            Console.WriteLine("NÚMERO: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero == 9999)
            {
                break;
            }

            soma = soma + numero;

            if (contador == 0)
            {
                maior = numero;
                menor = numero;
            } else if (numero > maior)
            {
                maior = numero;
            } else if(numero < menor)
            {
                menor = numero;
            }
            contador++;
        }
        Console.WriteLine(contador);
        Console.WriteLine(soma);

        double media = soma / contador;

        Console.WriteLine("=======================");
        Console.WriteLine($"A soma entre eles é: {soma}");
        Console.WriteLine($"A média entre eles é: {media}");
        Console.WriteLine($"O maior é o {maior} e o menor é o {menor}");

    }
}