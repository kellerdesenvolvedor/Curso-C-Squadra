using System;
using System.Globalization;

namespace Lista_2___Exercicio_5_e_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            5.Fazer um algoritmo para ler dois valores reais do teclado, calcular e imprimir na tela:
            6.a) A soma destes valores b) A soma deles c) A divisão deles.

            */

            double x, y, soma, subtracao, divisao;
            Console.Write(">>>>>>>>>>>>>>>>>>>Calculadora Básica<<<<<<<<<<<<<<<<<<<<<");
            Console.Write("\n\nDigite o primeiro número: ");
            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("\n\nDigite o segundo número: ");
            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            soma = x + y;
            subtracao = x - y;
            divisao = x / y;

            Console.Clear();
            Console.Write(">>>>>>>>>>>>>>>>>>>Calculadora Básica<<<<<<<<<<<<<<<<<<<<<");
            Console.Write("\n\n(a) O resultado da soma dos dois números digitados é: " + soma);
            Console.Write("\n\n(b) O resultado da subtração dos dois números digitados é: " + subtracao);
            Console.Write("\n\n(c) O resultado da divisão dos dois números digitados é: " + divisao);

            Console.ReadLine();

        }
    }
}
