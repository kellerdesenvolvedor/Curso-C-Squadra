using System;
using System.Globalization;


namespace Lista_2___Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             3. Ler dois números inteiros, X e Y, e imprimir a divisão entre eles.
            */

            double x = 0;
            double y = 0;
            double resultado = 0;
            double resto = 0;

            Console.Write("Resultado da Divisão!");
            Console.Write("\n\nDigite o número que será dividido: ");
            x = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture );
            Console.Write("\n\nDigite o número divisor: ");
            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            resultado = x / y;
            resto = y / x;

            Console.Clear();
            Console.Write(">>>>>>>>>>>>>>>>>>>>>Resultado da Divisão!<<<<<<<<<<<<<<<<<<<<");
            Console.Write("\n\nO resultad da divisão de "+ x + " por " + y + " é: "+ resultado.ToString("F2", CultureInfo.InvariantCulture));
            Console.Write("\n\nO resultado da divisão de " + y + " por " + x + " é: " + resto.ToString("F2", CultureInfo.InvariantCulture));
            

            Console.ReadLine();



        }
    }
}
