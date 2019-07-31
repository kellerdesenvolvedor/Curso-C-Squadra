using System;
using System.Globalization;

namespace Calculadora_Financeira___Poupança
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Exercício 01 – Calculadora Financeira(Poupança)
            Crie um programa(Console) que tem como objetivo realizar o cálculo de uma projeção
            financeira com base em uma aplicação em poupança.Esta calculadora deverá ter como
            entrada:
            Valor a ser aplicado de rendimento mensal na poupança
            Quantidade de meses que o dinheiro ficará aplicado
            Esta calculadora deverá calcular e retornar para o usuário quanto ele teria ao término dos
            meses que deseja aplicar. 
            */


            string nome;
            double capital = 0;
            int meses = 0;
            double rendimento = 0;
           
          
            
            Console.WriteLine("\n\n" + ">>>>>>>>>>>Calculadora Financeira - Poupança<<<<<<<<<<<<<<<<<<");
            Console.Write("\nDigite seu nome: ");
            nome = Console.ReadLine();
            Console.Write("\nDigite o valor que será aplicado mensalmente na poupança: ");
            capital = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("\nDigite a quantiade de meses que o dinheiro ficará aplicado: ");
            meses = int.Parse(Console.ReadLine());
            
            for(int cont = 0; cont <= meses; cont++)
            {
                capital = capital * 0.0037 + capital;
                rendimento = capital;
            }

            
            Console.Write("\n\n" + nome +  " você investiu em poupança. Abaixo está uma descrição do seu investimento.");
            Console.Write("\n\nValor Investido: " + "R$"+ capital.ToString("F2",CultureInfo.InvariantCulture));
            Console.Write("\n\nQuantidade de Meses da Aplicação: " + meses);
            Console.Write("\n\nO valor a receber após o términa da aplicação é: " + "R$" + rendimento.ToString("F2", CultureInfo.InvariantCulture));            
            Console.ReadLine();



        }
    }
}
