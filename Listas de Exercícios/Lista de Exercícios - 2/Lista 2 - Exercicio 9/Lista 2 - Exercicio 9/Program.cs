using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_2___Exercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            9. Ler um nome do teclado e verificar se é igual ao seu nome. Imprimir conforme o caso: "
               NOME CORRETO " ou " NOME INCORRETO ".
            */
            string nome, nome2;
            nome = "Marcos";
            nome = nome.ToUpper();
            Console.Write("Programa para Verificar o nome digitado");
            Console.Write("\n\nDigite um nome: ");
            nome2 = Console.ReadLine();
            nome2 = nome2.ToUpper();

            if (nome == nome2)
            {
                Console.Write("\n\nNOME CORRETO!");
            }
            else if (nome != nome2)
            {
                Console.Write("\n\nNOME INCORRETO!");
            }
            else
            {
                Console.Write("\n\nCaracteres digitados são inváldos!");
            }

            Console.ReadLine();

        }
    }
}
