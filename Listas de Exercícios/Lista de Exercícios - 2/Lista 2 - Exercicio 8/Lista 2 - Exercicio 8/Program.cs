using System;
using System.Globalization;

namespace Lista_2___Exercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             8. Fazer um algoritmo para ler 03 números reais do teclado e verificar se o primeiro é maior
                que a soma dos outros dois.
            */

            double x, y, z, soma;
            Console.Write(">>>>>>>>>>>>>>>>>>>Comparando Valores<<<<<<<<<<<<<<<<<<<<<<<<<<");
            Console.Write("\n\nDigite o primeiro número: ");
            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("\n\nDigite o segundo número: ");
            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("\n\nDigite o terceiro número: ");
            z = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            soma = y + z;

            Console.Clear();
            Console.Write(">>>>>>>>>>>>>>>>>>>Comparando Valores<<<<<<<<<<<<<<<<<<<<<<<<<<");
            if (x > soma)
            {
                Console.Write("\n\nA soma de " + "( " + y + " + " + z + " ) é igual á: " + soma.ToString("F2", CultureInfo.InvariantCulture));
                Console.Write("\n\nO número " + x.ToString("F2", CultureInfo.InvariantCulture) + " é maior que: " + soma.ToString("F2", CultureInfo.InvariantCulture));
            }
            if (x < soma)
            {
                Console.Write("\n\nA soma de " + "( " + y + " + " + z + " ) é igual á: " + soma.ToString("F2", CultureInfo.InvariantCulture));
                Console.Write("\n\nO número " + x.ToString("F2", CultureInfo.InvariantCulture) + " é menor que: " + soma.ToString("F2", CultureInfo.InvariantCulture));
            }
            if (x == soma)
            {
                Console.Write("\n\nA soma de " + "( " + y + " + " + z + " ) é igual á: " + soma.ToString("F2", CultureInfo.InvariantCulture));
                Console.Write("\n\nO número " + x.ToString("F2", CultureInfo.InvariantCulture) + " é igual á: " + soma.ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.ReadLine();

        }
    }
}
