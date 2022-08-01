/* Repetição com Flag
 * Exerc040 - Faça um programa que leia dois operandos de uma expressão e
 * mostre um menu que permita o usuário escolher que operação quer realizar.
 * */

using System;

class program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Operando 1: ");
            double operandoUm = double.Parse(Console.ReadLine());

            Console.WriteLine("Operando 2: ");
            double operandoDois = double.Parse(Console.ReadLine());

            Console.WriteLine("--Escolha uma opção--");
            Console.WriteLine("[ 1 ] Adição.");
            Console.WriteLine("[ 2 ] Subtração.");
            Console.WriteLine("[ 3 ] Multiplicação.");
            Console.WriteLine("[ 4 ] sair");
            byte escolha = byte.Parse(Console.ReadLine());

            double adicao = operandoUm + operandoDois;
            double subtracao = operandoUm - operandoDois;
            double multiplicacao = operandoUm * operandoDois;

            Thread.Sleep(300);
            switch (escolha)
            {
                case 1: Console.WriteLine($"A soma é {adicao}"); break;
                case 2: Console.WriteLine($"A subtração é {subtracao}"); break;
                case 3: Console.WriteLine($"A multiplicação é {multiplicacao}"); break;
                case 4:
                    Console.WriteLine("Volte sempre!");

                    System.Environment.Exit(0); 
                    break;
                default: Console.WriteLine("Opção inválida! Digite novamente."); break;
            }
        }
    }
}