using System;
using System.Globalization;
namespace Lista_2___Exercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            10. Ler 02 números reais do teclado (A e B), verificar e imprimir qual deles é o maior, ou a
                mensagem "A = B" caso sejam iguais.
            */
            Console.Write("Programa para ver qual número digitado é maior");
            double a, b;
            Console.Write("\n\nDigite o primeiro número: ");
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("\n\nDigite o segundo número: ");
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (a > b)
            {
                Console.Write("\n\nO número " + a.ToString("F2", CultureInfo.InvariantCulture) + " é maior que o número " + b.ToString("F2", CultureInfo.InvariantCulture) + "!");
            }
            else if (b > a)
            {
                Console.Write("\n\nO número " + b.ToString("F2", CultureInfo.InvariantCulture) + " é maior que o número " + a.ToString("F2", CultureInfo.InvariantCulture) + "!");
            }
            else
            {
                Console.Write("\n\nOs dois números digitados são iguais: " + a.ToString("F2", CultureInfo.InvariantCulture) + " = " + b.ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.ReadLine();
        }
    }
}
