using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1___Exercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;

            Console.Write("Digite o número que deseja saber seu antecessor e sucessor: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\nO antecessor do número " + a + " é " + (a - 1) + " e o seu sucessor é " + (a + 1));
            Console.ReadLine();
        }
    }
}
