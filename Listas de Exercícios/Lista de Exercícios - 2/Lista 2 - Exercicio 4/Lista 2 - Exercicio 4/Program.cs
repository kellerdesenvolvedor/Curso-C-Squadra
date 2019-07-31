using System;
using System.Globalization;

namespace Lista_2___Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            4. Ler dois números inteiros, X e Y, e apresentar mensagem informando qual número é
               maior.
            */

            double x;
            double y;
            Console.Write(">>>>>>>>>>>>>>>>>>>>>Comparando Números<<<<<<<<<<<<<<<<<<<<<<<<");
            Console.Write("\n\nDigite o primeiro número: ");
            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("\n\nDigite o segundo número: ");
            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (x == y)
            {
                Console.Write("\n\nOs números digitados são iguais: " + x + " = " + y);
            }
            if (x > y)
            {
                Console.Write("\n\nO número " + x + " é maior que o número " + y + ".");
            }
            if(y > x)
            {
                Console.Write("\n\nO número " + y + " é maior que o número " + x + ".");
            }
            
            

            Console.ReadLine();   

        }
    }
}
