using System;
using System.Globalization;

namespace Lista_2___Exercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
        /* 
         11. Ler 02 números inteiros do teclado. Se o segundo for diferente de zero, calcular e imprimir
             o quociente do primeiro pelo segundo. Caso contrário, imprimir a mensagem: "DIVISÃO
             POR ZERO".
        */



            Console.Write("Programa para ver se é possível dividir");
            double a, b, divisao;
            Console.Write("\n\nDigite o primeiro número: ");
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("\n\nDigite o segundo número: ");
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (b != 0)
            {
                divisao = a / b;
                Console.Write("\n\nO resultado da divisão de " + a.ToString("F2", CultureInfo.InvariantCulture) + " por " + b.ToString("F2", CultureInfo.InvariantCulture) + "  é: " + divisao.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (b == 0)
            {
                Console.Write("\n\nDivisão por Zero!");
            }
            
            

            Console.ReadLine();
        }
    }
}
