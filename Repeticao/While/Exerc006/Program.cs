/* Maior e Menor Valores
 * Exerc038 - Cadastrar 5 pessoas e informar quantos homens e quantas mulheres
 * foram cadastrados, mostrar o mais velho e o mais novo entre homens e também entre as mulheres.*/
using System;

class program
{
    static void Main()
    {
        int contador = 1;

        int maiorMasc = 0;
        int menorMasc = 0;

        int maiorFem = 0;
        int menorFem = 0;

        string velhoMasc = "";
        string novoMasc = "";

        string velhoFem = "";
        string novoFem = "";

        int masc = 0;
        int fem = 0;

        while (contador <= 5)
        {
            Console.WriteLine($"{contador}a PESSOA");
            Console.WriteLine("------------------");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("SEXO [M/F]: ");
            char sexo = char.Parse(Console.ReadLine().ToLower());
            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------");

            if (sexo == 'm')
            {
                if(masc == 0)
                {
                    velhoMasc = nome;
                    maiorMasc = idade;
                    novoMasc = nome;
                    menorMasc = idade;

                } else if (idade > maiorMasc)
                {
                    velhoMasc = nome;
                    maiorMasc = idade;
                } else if (idade < menorMasc)
                {
                    novoMasc = nome;
                    menorMasc = idade;
                }
                masc++;
            }
            else if (sexo == 'f')
            {
                if (fem == 0)
                {
                    velhoFem = nome;
                    maiorFem = idade;
                    novoFem = nome;
                    menorFem = idade;

                }
                else if (idade > maiorFem)
                {
                    velhoFem = nome;
                    maiorFem = idade;
                }
                else if (idade < menorFem)
                {
                    novoFem = nome;
                    menorFem = idade;
                }
                fem++;
            }

            contador++;
        }
        Console.WriteLine("=======================");
        Console.WriteLine($"Ao todo tivemos {masc} homens e {fem} mulheres cadastrados.");
        Console.WriteLine();
        Console.WriteLine($"O homem mais velho é {velhoMasc} que tem {maiorMasc} anos.");
        Console.WriteLine($"O homem mais jovem é {novoMasc} que tem {menorMasc} anos.");
        Console.WriteLine();
        Console.WriteLine($"A mulher mais velho é {velhoFem} que tem {maiorFem} anos.");
        Console.WriteLine($"A mulher mais jovem é {novoFem} que tem {menorFem} anos.");
    }
}
