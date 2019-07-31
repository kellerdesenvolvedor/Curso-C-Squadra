using System;
using System.Globalization;

namespace Lista_1___Exercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;


            Console.Write("Digite o saldo da sua aplicação: ");
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = (a * 0.01) + a;

            Console.WriteLine("\n\nO valor atualizado da sua aplicação é: " + b.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
