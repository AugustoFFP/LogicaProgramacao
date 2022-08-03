/* Estrutura de Variável de Controle 
 * Exerc016 - Escreva um programa que lido um número, calcule e informe seu fatorial.
 * Exemplo.: 5! = 5 . 4 . 3 . 2 . 1 = 120*/

class program
{
    static void Main(string[] args)
    {
        int fatorial = 1;
        int contador = 0;

        Console.WriteLine("Digite um número de 1 a 10: ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine($"Fatoração de {num}: ");

        
        


        for (contador = num; contador >= 1; contador--)
        {
            fatorial = fatorial * contador;
             

            if (contador >= 2)
            {
                Console.Write($"{contador} x ");
            }
            else
            {
                Console.WriteLine($"{contador} = {fatorial}");
            }
        }
    }
}