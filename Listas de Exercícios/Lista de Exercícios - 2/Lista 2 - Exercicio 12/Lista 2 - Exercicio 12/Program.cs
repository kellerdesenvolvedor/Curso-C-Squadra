using System;
using System.Globalization;

namespace Lista_2___Exercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            12. Ler 4 números inteiros e calcular a soma dos que forem par.
            */

            Console.Write("Programa para Dividir números Pares");

            int a, b, c, d;
            int soma;
            Console.Write("\n\nDigite o primeiro número: ");
            a = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("\n\nDigite o segundo número: ");
            b = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("\n\nDigite o terceiro número: ");
            c = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("\n\nDigite o quarto número: ");
            d = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            soma = 0;
          
            if (a % 2 == 0)
            {
                soma = soma + a;
            }
            if (b % 2 == 0)
            {
                soma = soma + b;
            }
            if (c % 2 == 0)
            {
                soma = soma + c;
            }
            if (d % 2 == 0)
            {
                soma = soma + d;
            }


            Console.Write("\n\nA soma dos números que são pares é: " + soma);

            Console.ReadLine();



        }    

    }
}
