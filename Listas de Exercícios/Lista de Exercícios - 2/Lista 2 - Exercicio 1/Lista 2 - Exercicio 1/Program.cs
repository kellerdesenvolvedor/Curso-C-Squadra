using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_2___Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine(">>>>>>>>>Programa para saber o sucessor de um número<<<<<<<<<");
            Console.Write("\n\nDigite o número que você deseja saber o sucessor dele: ");
            num = int.Parse(Console.ReadLine());
            Console.Write("\n\n O sucessor do número:" + num +   " é:"+ (num + 1));
            Console.ReadLine();
        }
    }
}
