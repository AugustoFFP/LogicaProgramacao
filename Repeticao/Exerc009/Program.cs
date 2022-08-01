/* Repetição com Interrupção
 * Exerc041 - Escreva um programa que leia nome e idade de vários amigos.
 * O programa deve ser encerrado se o usuário digitar acabou no nome.
 * Ao final mostrar: 
  * - Quantos amigos foram cadastrados.
  * - Qual é o amigo mais velho.
  * - Qual o amigo mais novo.
  * - A média de idade dos seus amigos.*/
   
   using System;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite acabou no nome para parar");

        int idade = 0;
        string nome = "";

        int maior = 0;
        int menor = 0;

        string nomeMaior = "";
        string nomeMenor = "";

        int contador = 0;

        int soma = 0;

        Console.WriteLine("================================");

        while (nome != "acabou")
        {
            
            Console.WriteLine("\nNome: ");
            nome = Console.ReadLine().ToLower();

            if (nome == "acabou")
            {
                Console.WriteLine("***************INTERROMPIDO***************");
                Thread.Sleep(400);
                break;
            }

            Console.WriteLine("Idade: ");
            idade = int.Parse(Console.ReadLine());

            soma = soma + idade;

            if (contador == 0)
            {
                nomeMaior = nome;
                maior = idade;
                nomeMenor = nome;
                menor = idade;
            } else if(idade > maior)
            {
                maior = idade;
                nomeMaior = nome;
            } else if (idade < menor)
            {
                menor = idade;
                nomeMenor = nome;
            }
            contador++; 

        }

        double media = soma / contador;

        Console.WriteLine($"total de amigos: {contador}");
        Thread.Sleep(400);
        Console.WriteLine($"A média das idades: {media}");

        Console.WriteLine($"O mais jovem é o {nomeMenor} com {menor} anos.");

        Console.WriteLine($"Seu amigo mais velho é {nomeMaior} com {maior} anos.");

    }
}