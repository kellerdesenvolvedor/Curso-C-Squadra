using System;
using System.Globalization;

namespace Lista_2___Exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            7. Calcular a média final (nota bimestre 1 + bimestre 2 + bimestre3 dividido por 3 ) e a
            situação do aluno de acordo com o seguinte critério: média >=6, aprovado; média < 6,
            reprovado.

            */



            double bimestre_1, bimestre_2, bimestre_3, media;
            string nome;
            Console.Write(">>>>>>>>>>>>>>>>>>>Situação do Aluno<<<<<<<<<<<<<<<<<<<<<");
            Console.Write("\n\nDigite o nome do aluno: ");
            nome = Console.ReadLine();
            Console.Write("\n\nDigite a nota do primeiro bimestre: ");
            bimestre_1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("\n\nDigite a nota do segundo bimestre: ");
            bimestre_2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("\n\nDigite a nota do terceiro bimestre: ");
            bimestre_3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            
            media = (bimestre_1 + bimestre_2 + bimestre_3) / 3;

            Console.Clear();
            Console.Write(">>>>>>>>>>>>>>>>>>>Situação do Aluno<<<<<<<<<<<<<<<<<<<<<");
            if ( media >= 6)
            {
                Console.Write("\n\nA média do aluno " + nome + " é " + media.ToString("F2", CultureInfo.InvariantCulture) + "!" + "\n\nVocê foi aprovado!!!");
            }
            else
            {
                Console.Write("\n\nA média do aluno " + nome + " é " + media.ToString("F2", CultureInfo.InvariantCulture) + "!" + "\n\nVocê foi reprovado!!!");
            }

            
           

            Console.ReadLine();

        }
    }
}
