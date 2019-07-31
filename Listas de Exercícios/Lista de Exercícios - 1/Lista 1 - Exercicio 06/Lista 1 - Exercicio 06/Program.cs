using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1___Exercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;

            Console.Write("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Os números digitados foram respectivamente: " + num1 + " e " + num2);
            Console.ReadLine();
        }
    }
}
