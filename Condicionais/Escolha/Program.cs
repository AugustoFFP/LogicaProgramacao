/* Ex01: Mini calculadora com a estrutura Switch.*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("TABUADA");
        Console.WriteLine("Digite sua opção: +, -, /, *");
        char opcao = char.Parse(Console.ReadLine());
        Console.WriteLine("============================");
        System.Console.WriteLine("Digite um valor: ");
        int valor1 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Digite outro valor: ");
        int valor2 = int.Parse(Console.ReadLine());

        //VALIDANDO OPERADOR 

        switch (opcao)
        {
            case '+': System.Console.WriteLine($"A soma é {valor1 + valor2}"); break;
            case '-': System.Console.WriteLine($"A soma é {valor1 - valor2}"); break;
            case '*': System.Console.WriteLine($"A soma é {valor1 * valor2}"); break;
            case '/': System.Console.WriteLine($"A soma é {Convert.ToDouble(valor1) / Convert.ToDouble(valor2)}"); break;
            default: Console.WriteLine("Escolha novamente!"); break;
        }
    }
}