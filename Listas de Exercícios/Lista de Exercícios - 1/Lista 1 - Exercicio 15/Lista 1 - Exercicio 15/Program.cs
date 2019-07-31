using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1___Exercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            Console.Write("Digite seu primeiro nome: ");
            nome = Console.ReadLine();

            Console.Write("\n\nA primeira letra do seu nome é: " + nome);
            Console.Write("\n\nA primeira letra do seu nome é: " + nome[0]);
            Console.Write("\n\nA primeira letra do seu nome é: " + nome[5]);
            Console.Write("\n\nA primeira letra do seu nome é: " + nome.Substring(0, 3));
            Console.Write("\n\nA primeira letra do seu nome é: " + nome[3]);
            Console.ReadLine();
        }
    }
}
