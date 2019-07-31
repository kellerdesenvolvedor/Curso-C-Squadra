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
            Console.WriteLine("\nO nome digitado foi: " + nome);
            Console.WriteLine("\nA primeira letra do seu nome é: " + nome[0]);
            Console.WriteLine("\nO último caractere do seu nome é: " + nome[5]);
            Console.WriteLine("\nAs três primeiras letras do seu nome são: " + nome.Substring(0, 3));
            Console.WriteLine("\nO quarto caractere do seu nome é: " + nome[3]);
            Console.WriteLine("\nO seu primeiro nome sem a primeira letra é: " + nome.Substring(1, 5));
            Console.WriteLine("\nOs dois últimos caracteres do seu nome é: " + nome.Substring(nome.Length - 2, 2));
            Console.WriteLine("\nA quantidade de caracteres que seu nome tem é: " + nome.Length);
            Console.ReadLine();
        }
    }
}
