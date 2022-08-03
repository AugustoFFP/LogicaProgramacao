/* Contando Elementos por Categoria.
 * Exerc036 - Perguntar quantos números vou querer sortear, em seguida falar
 * quantos são maiores que 5 e quantos são divisíveis por três.*/

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        Console.WriteLine("Quantos números você quer sortear?");
        int numeros = int.Parse(Console.ReadLine());

        int contador = 0;
        int divisiveisPorTres = 0;
        int maiorQueCinco = 0;
        while (numeros > contador)
        {
            int valor = random.Next(1, 10);
            Console.Write(valor + " ");

            if(valor % 3 == 0)
            {
                divisiveisPorTres++;
            } 
            if(valor > 5)
            {
                maiorQueCinco++;
            }
            contador++;
        }
        Console.WriteLine($"Dos {numeros} sorteados \n" +
            $"{maiorQueCinco} são maiores que cinco \n" +
            $"{divisiveisPorTres} são divisíveis por três.");
    }
}