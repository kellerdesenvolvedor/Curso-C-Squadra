using System;
using System.Globalization;

namespace Calculadora_Financeira_Renda_Fixa
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
           Complementando o exercício anterior, vamos considerar também o cálculo a partir de
           aplicação na modalidade Renda Fixa. Para isso, altere o sistema para passar a receber também
           mais a seguinte informação:
           % de rendimento mensal em renda fixa
           O sistema deverá retornar para o usuário tanto a projeção para poupança, como também para
           renda fixa. Além disso, mostrar uma mensagem indicando qual opção seria a mais indicada, ou
           seja, a que ele teria maior rendimento
           */


            string nome;
            double capital = 0;
            int meses = 0;
            double rendimento = 0;
            double percentual = 0;
            double r_Fixa = 0;



            Console.WriteLine("\n\n" + ">>>>>>>>>>> Calculadora Financeira <<<<<<<<<<<<<<<<<<");
            Console.Write("\nDigite seu nome: ");
            nome = Console.ReadLine();
            Console.Write("\nDigite o valor que será aplicado mensalmente: ");
            capital = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("\nDigite a quantiade de meses que o dinheiro ficará aplicado: ");
            meses = int.Parse(Console.ReadLine());
            Console.Write("Digite o percentual mensal de renda fixa: ");
            percentual = double.Parse(Console.ReadLine());


            r_Fixa = capital;
            percentual = percentual / 100;

            for (int cont = 1; cont <= meses; cont++)
            {
                capital = capital * 0.0037 + capital;
                rendimento = capital;
            }
            for(int i = 1; i <= meses; i++)
            {
                r_Fixa = (r_Fixa * percentual) + r_Fixa;
                
            }

            Console.Write("\n\n" + nome + " você investiu em poupança. Abaixo está uma descrição do seu investimento.");
            Console.Write("\n\nValor Investido: " + "R$" + capital.ToString("F2", CultureInfo.InvariantCulture));
            Console.Write("\n\nQuantidade de Meses da Aplicação: " + meses);
            Console.Write("\n\nO valor a receber após o términa da aplicação em poupança é: " + "R$" + rendimento.ToString("F2", CultureInfo.InvariantCulture));
            Console.Write("\n\nO valor a receber após o términa da aplicação em renda fixa é: " + "R$" + r_Fixa.ToString("F2", CultureInfo.InvariantCulture));


            Console.ReadLine();

        }
    }
}
