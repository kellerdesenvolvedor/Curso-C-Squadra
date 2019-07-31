using System;
using System.Globalization;

namespace Lista_1___Exercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            double prova1 = 0;
            double prova2 = 0;
            double media = 0;

            Console.Write("Digite a nota da prova do primeiro trimestre: ");
            prova1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("\nDigite a nota da prova do segundo trimestre: ");
            prova2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (prova1 + prova2) / 2;
            Console.WriteLine("\n\nA média do aluno no semestre foi: " + media.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
