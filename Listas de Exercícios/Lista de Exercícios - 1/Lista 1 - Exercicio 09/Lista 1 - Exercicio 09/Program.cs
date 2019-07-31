using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1___Exercicio_09
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

            Console.WriteLine("Soma:" + (a + b));
            Console.ReadLine();



        }
    }
}
