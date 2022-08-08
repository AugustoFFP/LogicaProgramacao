using System;

class program
{
    static void Main(string[] args)
    {
        Tecnica5();
    }

    static void Tecnica1()
    {
        char sexo = ' ';
        int idade = 0;
        int contador = 1;
        while (contador <= 4)
        {
            do
            {
                Console.WriteLine("Digite o sexo: ");
                sexo = char.Parse(Console.ReadLine());
            } while (!(sexo == 'M' || sexo == 'F'));

            do
            {
                Console.WriteLine("Digite a idade: ");
                idade = int.Parse(Console.ReadLine());
            } while (!(idade >= 0 && idade <= 130));

            Console.WriteLine($"Sexo: {sexo}, Idade: {idade}");
            contador++;
        }
    }

    static void Tecnica2()
    {
        string nome = "";

        do
        {
            Console.WriteLine("Digite um nome");
            nome = Console.ReadLine();
        } while (!(nome.Length >= 3));

        Console.WriteLine(nome.Length);
    }

    static void Tecnica3()
    {
        string nome = " ";

        while (true)
        {
            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

        }
    }

    static void Tecnica4()
    {
        string nome = "";

        while (true)
        {
            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            if(nome.Length >= 3)
            {
                break;
            } else
            {
                Console.WriteLine("<<ERRO>> O nome deve ter pelo menos 3 letras\n");
            }
        }
    }

    static void Tecnica5()
    {
        
        string teclado = "";
        int idade;
        bool resultado = true;
        while (true)
        {
            Console.WriteLine("Digite a idade ");
            teclado = Console.ReadLine();
            //int.TryParse(Console.ReadLine(), out idade); 
            //out é para jogar a string na variável idade.
            resultado = int.TryParse(teclado, out idade);


            if (resultado == true)
            {
               if(idade >= 0 && idade <= 130)
                {
                    Console.WriteLine($"A idade é {idade}!");
                    break;
                } else
                {
                    Console.WriteLine("<<Erro>> A idade deve estar entre 0 e 130 anos.");
                }
            } else
            {
                Console.WriteLine("<<Erro>> a idade deve ser um número!\n");
            }

        }
    }
}