using System;
using System.Globalization;

namespace Lista_2___Exercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            14. Ler três valores e colocá-los em ordem decrescente.
            */

            Console.Write("Programa para colocar os números em ordem decrescente");

            double a, b, c;

            Console.Write("\n\nDigite o primeiro número: ");
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("\n\nDigite o segundo número: ");
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("\n\nDigite o terceiro número: ");
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (a == b  && b == c)
            {
                Console.Write("\n\nOs números são iguais: " + a + " = " + b + " = " + c);
            }
            if (a == b && b > c)
            {
                Console.Write("\n\nExistem números iguais, favor digitar números diferentes " + b + " = " + a + " > " + c);
            }
            if (a == b && b < c)
            {
                Console.Write("\n\nExistem números iguais, favor digitar números diferentes " + a + " = " + b + " < " + c);
            }
            if (a > b && b == c)
            {
                Console.Write("\n\nExistem números iguais, favor digitar números diferentes " + a + " > " + b + " = " + c);
            }
            if (a < b && b == c)
            {
                Console.Write("\n\nExistem números iguais, favor digitar números diferentes " + c + " = " + b + " > " + a);
            }
            if (a > b && a > c && b > c)
            {
                Console.Write("\n\nOs números em ordem descrescente é: " + a + " > " + b + " > " + c);
            }
           if (a > b && a > c && b < c)
            {
                Console.Write("\n\nOs números em ordem descrescente é: " + a + " > " + c + " > " + b);
            }

            if (b > a && b > c && c > a)
            {
                Console.Write("\n\nOs números em ordem descrescente é: " + b + " > " + c + " > " + a);
            }
            if (b > a && b > c && c < a)
            {
                Console.Write("\n\nOs números em ordem descrescente é: " + b + " > " + a + " > " + c);
            }
            
            if(a<b && b<c && a<c)
            {
                Console.Write("\n\nOs números em ordem descrescente é: " + c + " > " + b + " > " + a);
            }
            if(a>b && b<c && a<c)
            {
                Console.Write("\n\nOs números em ordem descrescente é: " + c + " > " + a + " > " + b);
            }


            Console.ReadLine();

        }
    }
}
