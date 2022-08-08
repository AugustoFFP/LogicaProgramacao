/* Exerc053 - Digitar um número de 1 a 10.
 * - Se o número for maior, informar ERRO.
 * - Se o número for menor, informar ERRO.*/
using System;

class program
{
    static void Main(string[] args)
    {
        int numero = 0;
        string numero2 = "";
        bool resultado = true;
        do
        {
            Console.WriteLine("Digite um número de 1 a 10: ");
            numero2 = Console.ReadLine();

            resultado = int.TryParse(numero2, out numero);



            if (numero > 10)
            {
                Console.WriteLine("Digite um número menor do que 10:");
                numero = int.Parse(Console.ReadLine());
            } else if (numero < 0)
            {
                Console.WriteLine("Digite um número maior do que zero: ");
                numero = int.Parse(Console.ReadLine());
            } else
            {
                Console.WriteLine($"Número: {numero}");
            }


        } while (resultado == true);
    }
}