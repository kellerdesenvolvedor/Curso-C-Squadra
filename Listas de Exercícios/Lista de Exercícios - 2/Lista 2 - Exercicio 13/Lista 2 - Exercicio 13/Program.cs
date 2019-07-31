using System;
using System.Globalization;

namespace Lista_2___Exercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            13. Ler três valores e determinar o maior dentre eles.
            */
            Console.Write("Programa para saber qual é o número maior");

            double a, b, c;
            
            Console.Write("\n\nDigite o primeiro número: ");
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("\n\nDigite o segundo número: ");
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("\n\nDigite o terceiro número: ");
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(a > b && a > c)
            {
                Console.Write("\n\nO maior número é: " + a);
            }
            if (b > a && b > c)
            {
                Console.Write("\n\nO maior número é: " + b);
            }
            if (c > a && c > b)
            {
                Console.Write("\n\nO maior número é: " + c);
            }
            if (a == b && a > c)
            {
                Console.Write("\n\nO maior número é: " + a);
            }
            if (b == c && b > a)
            {
                Console.Write("\n\nO maior número é: " + b);
            }
            
            if (a == b && a ==c)
            {
                Console.Write("\n\nOs números digitadis são iguais:  " + a + " = " + b + " = " + c);
            }

            Console.ReadLine();
        }
    }
}
