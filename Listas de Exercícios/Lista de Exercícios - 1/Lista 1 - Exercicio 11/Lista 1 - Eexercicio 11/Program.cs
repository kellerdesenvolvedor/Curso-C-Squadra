using System;
using System.Globalization;

namespace Lista_1___Eexercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            int b = 0;


            Console.Write("Digite número que deseja saber qual é a terça parte: ");
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
         

            Console.WriteLine("\n\nA terça parte do número " + a + " é: " + (a / 3).ToString("F4"));
            Console.ReadLine();
        }
    }
}
