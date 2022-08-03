/* Estrutura com interrupção no final
 * Exerc 044 - Programa que irá sortear números conforme o usuário responder se quer ou não.
 * Ao final mostrar: 
 * - Quantos valores foram sorteados.
 * - A soma deles todos.
 * - O maior valor e o menor.
 * - Quantas vezes um determinado valor foi sorteado e quantas vezes*/

using System;

class program
{
    static void Main(string[] args)
    {
        Random sorte = new Random();

        int contador = 0;
        int numero = 0;
        int soma = 0;
        int maior = 0;
        int menor = 0;

        int numero1 = 0;
        int numero2 = 0;
        int numero3 = 0;
        int numero4 = 0;
        int numero5 = 0;
        int numero6 = 0;
        int numero7 = 0;
        int numero8 = 0;
        int numero9 = 0;
        int numero10 = 0;

        string verificacao = "";



        do
        {
            Console.WriteLine("Você deseja parar de sortear?[Sim/Nao]");
            verificacao = Console.ReadLine().ToLower();

            contador++;

            if (verificacao == "nao")
            {
               numero = sorte.Next(1, 10);
            } else
            {
                break;
            }

            switch (numero)
            {
                case 1: numero1++;  break;
                case 2: numero2++; break;
                case 3: numero3++; break;
                case 4: numero4++; break;
                case 5: numero5++; break;
                case 6: numero6++; break;
                case 7: numero7++; break;
                case 8: numero8++; break;
                case 9: numero9++; break;
                case 10: numero10++; break;
            }

            soma = numero + soma;

            if(contador == 1)
            {
                maior = numero;
                menor = numero;
            } else if(numero > maior)
            {
                maior = numero;
            } else if(numero < menor)
            {
                menor = numero;
            }
            
        } while (verificacao != "não");

        Console.WriteLine("Qual valor você deseja ver quantas vezes ele foi sorteado?");
        byte valor = byte.Parse(Console.ReadLine());

        switch (valor)
        {
            case 1: Console.WriteLine($"O número {valor} foi sorteado {numero1} vezes.");  break;
            case 2: Console.WriteLine($"O número {valor} foi sorteado {numero2} vezes.");  break;
            case 3: Console.WriteLine($"O número {valor} foi sorteado {numero3} vezes.");  break;
            case 4: Console.WriteLine($"O número {valor} foi sorteado {numero4} vezes.");  break;
            case 5: Console.WriteLine($"O número {valor} foi sorteado {numero5} vezes.");  break;
            case 6: Console.WriteLine($"O número {valor} foi sorteado {numero6} vezes.");  break;
            case 7: Console.WriteLine($"O número {valor} foi sorteado {numero7} vezes.");  break;
            case 8: Console.WriteLine($"O número {valor} foi sorteado {numero8} vezes.");  break;
            case 9: Console.WriteLine($"O número {valor} foi sorteado {numero9} vezes.");  break;
            case 10: Console.WriteLine($"O número {valor} foi sorteado {numero10} vezes."); break;
            default: Console.WriteLine("Escolha um número de 1 a 10. Tente novamente."); break;
        }


        Console.WriteLine($"Foram sorteador {contador} valores.");
        Console.WriteLine($"A soma de todos os valores foram {soma}.");
        Console.WriteLine($"O maior  foi {maior} e o menor foi {menor}");
    }
}