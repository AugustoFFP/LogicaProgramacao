/* Contando Elementos por categoria.
 * Exerc034 - Perguntar quantas pessoas vão ser cadastradas, em seguida informar quantas dessas
 * estão acima do peso de referência e se são homens ou mulheres. */

using System;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quantas pessoas vamos cadastrar? ");
        int pessoas = int.Parse(Console.ReadLine());

        Console.WriteLine("Qual o peso de referência (Kg)? ");
        int peso = int.Parse(Console.ReadLine());

        int contador = 0;

        int mulherAcima = 0;
        int homemAcima = 0;
        
        while(contador < pessoas)
        {
            Console.WriteLine($"PESSOA {contador} de {pessoas}!");
            Console.WriteLine("Peso: ");
            int kilos = int.Parse(Console.ReadLine());
            Console.WriteLine("Sexo: ");
            char sexo = char.Parse(Console.ReadLine().ToLower());

            if(sexo == 'm' && kilos > peso)
            {
                homemAcima++;
            } else if (sexo == 'f' && kilos > peso)
            {
                mulherAcima++;
            }
            contador++;
        }
        Console.WriteLine($"Ao todo temos {mulherAcima + homemAcima} acima do peso de {peso}KG.");
        Console.WriteLine($"E dessas pessoas, {homemAcima} são homens, {mulherAcima} são mulheres!");

    }
}
