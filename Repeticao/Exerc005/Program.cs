/* Maior e Menor Valores.
 * Exerc037 - Mostrar os mais velhos e os mais novos entre as 5 pessoas.*/

using System;

class program
{
    static void Main(string[] args)
    {
        int contador = 1;

        int maior = 0;
        int menor = 0;
        string velho = "";
        string novo = "";

        while(contador <= 5)
        {
            Console.WriteLine($"{contador}a PESSOA");
            Console.WriteLine("------------------");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------");
            
            if(contador == 1)
            {
                maior = idade;
                velho = nome;
                menor = idade;
                novo = nome;
            } else
            {
                if(idade > maior)
                {
                    maior = idade;
                    velho = nome;
                }
                if(idade < menor)
                {
                    menor = idade;
                    novo = nome;
                }
            }

            contador++;
        }
        Console.WriteLine("=======================");
        Console.WriteLine($"A pessoa mais jovem é {novo}");
        Console.WriteLine($"A pessoa mais velha é {velho}");
    }
}
