using System;
using System.Globalization;

namespace Lista_1___Exercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;


            Console.Write("Digite o primeiro número: ");
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
            Console.Write("Digite o segundo número: ");
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("\n\nMédia:" + ((a + b)/2).ToString("F2"), CultureInfo.InvariantCulture);
            Console.ReadLine();
        }
    }
}
