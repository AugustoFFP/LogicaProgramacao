/* Todas as técnicas
 * Exerc042 - Um programa que leia o nome, sexo e salário dos funcionários de uma empresa.
 * ao final informar:
 * - Total de pessoas cadastradas.
 * - Total de homens e Total de mulheres.
 * - Média salarial de Homens e Média salarial de mulheres.
 * - Total de mulheres que ganhem mais de mil reais.
 * - Maior salário entre os homens. */
using System;

class program
{
    static void Main(string[] args)
    {

        int totPessoas = 0;
        int totHomens = 0;
        int totMulheres = 0;

        int totMulheresMil = 0;

        int somaSalarioHomens = 0;
        int somaSalarioMulheres = 0;

        int maiorSalarioHomens = 0;

        int contador = 0;

        while (true)
        {
            System.Console.WriteLine("SISTEMA DE MANUNTEÇÃO DE FUNCIONÁRIOS");
            System.Console.WriteLine("Deseja sair? [Sim/Nao]");
            string sair = Console.ReadLine().ToLower();

            Console.WriteLine("\n");

            if (sair == "sim")
            {
                break;
            }
            System.Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            System.Console.WriteLine("\nQual o sexo? [m/f]");
            char sexo = char.Parse(Console.ReadLine().ToLower());
            System.Console.WriteLine("\nQual o salário?");
            int salario = int.Parse(Console.ReadLine());

            totPessoas++;

            if (sexo == 'f')
            {
                totMulheres++;
                somaSalarioMulheres += salario;
                if (salario > 1000)
                {
                    totMulheresMil++;
                }
            }

            if (sexo == 'm')
            {
                totHomens++;
                somaSalarioHomens += salario;
                if (totHomens == 0)
                {
                    salario = maiorSalarioHomens;
                }
                else if (maiorSalarioHomens < salario)
                {
                    maiorSalarioHomens = salario;
                }
            }


        }
        double mediaSalarialHomens = Convert.ToDouble(somaSalarioHomens) / Convert.ToDouble(totHomens);
        double mediaSalarialMulheres = Convert.ToDouble(somaSalarioMulheres) / Convert.ToDouble(totMulheres);

        Console.WriteLine($"\nO total de Pessoas cadastradas é {totPessoas}");
        Console.WriteLine($"\nDesse total os homens são {totHomens} e as mulheres {totMulheres}!");
        Console.WriteLine($"\nA média salarial de homens é R${mediaSalarialHomens} e a das mulheres é R${mediaSalarialMulheres}.");
        System.Console.WriteLine($"\nO total de mulheres que ganham mais de R$1000 são {totMulheresMil}!");
        System.Console.WriteLine($"\nO maior salário entre os homens é {maiorSalarioHomens}!");
    }
}

