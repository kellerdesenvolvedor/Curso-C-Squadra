using System;


namespace Lista_1___Exercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;


            Console.Write("Digite o primeiro número: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\nO produto dos números digitados é: " + (a * b));
            Console.ReadLine();
        }
    }
}
