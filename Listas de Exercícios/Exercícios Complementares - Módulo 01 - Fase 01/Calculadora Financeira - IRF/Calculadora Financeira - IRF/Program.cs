using System;
using System.Globalization;

/*
 Exercício 03 – Calculadora Financeira (Imposto de Renda
para Renda Fixa)
Uma nova regra deve ser incluída para o sistema abaixo: Para aplicações feitas em Renda Fixa,
o Governo cobra Imposto de Renda sobre o rendimento (não sobre o montante final),
conforme a seguinte tabela:
Meses % de Imposto de Renda
Até 12 meses 25%
De 13 a 24 meses 15%
De 25 a 36 meses 5%
Acima de 36 meses 1%
Dado esta regra, atualize o sistema para que o usuário possa ter a visão real da melhor
aplicação (Poupança ou Renda Fixa)
*/

namespace Calculadora_Financeira___IRF
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double capital = 0;
            int meses = 0;
            double investimento = 0;
            double percentual_poup = 0;
            double percentual_fixa = 0;
            double r_Fixa = 0;
            double juros = 0;
            double imposto = 0;      
            string opcao;


            do
            {
                Console.Clear();
                Console.WriteLine("\n\n" + ">>>>>>>>>>> Calculadora Financeira <<<<<<<<<<<<<<<<<<");
                Console.Write("\nDigite seu nome: ");
                nome = Console.ReadLine();
                Console.Write("\nDigite o valor que será aplicado mensalmente: ");
                capital = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("\nDigite a quantiade de meses que o dinheiro ficará aplicado: ");
                meses = int.Parse(Console.ReadLine());
                Console.Write("Digite o percentual mensal de rendimento da poupança: ");
                percentual_poup = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Digite o percentual mensal de rendimento da renda fixa: ");
                percentual_fixa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                investimento = capital;
                r_Fixa = capital;
                percentual_poup = percentual_poup / 100;
                percentual_fixa = percentual_fixa / 100;

                for (int cont = 1; cont <= meses; cont++)
                {
                    capital = (capital * percentual_poup) + capital;

                }
                for (int i = 1; i <= meses; i++)
                {
                    r_Fixa = (r_Fixa * percentual_fixa) + r_Fixa;

                }

                //Cálculo do Imposto de renda

                if (meses <= 12)
                {
                    juros = r_Fixa - investimento;
                    imposto = juros * 0.25;
                    r_Fixa = r_Fixa - imposto;
                }
                if (meses >= 13 && meses <= 24)
                {
                    juros = r_Fixa - investimento;
                    imposto = juros * 0.15;
                    r_Fixa = r_Fixa - imposto;
                }
                if (meses >= 25 && meses <= 36)
                {
                    juros = r_Fixa - investimento;
                    imposto = juros * 0.05;
                    r_Fixa = r_Fixa - imposto;
                }
                if (meses > 36)
                {
                    juros = r_Fixa - investimento;
                    imposto = juros * 0.01;
                    r_Fixa = r_Fixa - imposto;
                }

                Console.Clear();
                Console.Write("\n\n" + nome + " Abaixo está uma descrição do seu investimento.");
                Console.Write("\n\nValor Investido: " + "R$" + investimento.ToString("F2", CultureInfo.InvariantCulture));
                Console.Write("\n\nQuantidade de Meses da Aplicação: " + meses);
                Console.Write("\n\nO valor a receber após o términa da aplicação em poupança é: " + "R$" + capital.ToString("F2", CultureInfo.InvariantCulture));
                Console.Write("\n\nO valor a receber após o términa da aplicação em renda fixa é: " + "R$" + r_Fixa.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("\n\nSegundo o cálculo realizado pelo programa o melhor investimento para seu dinheiro é: ");

                if (capital == r_Fixa)
                {
                    Console.Write("\n\nTanto a 'Poupança' quanto a 'Renda Fixa' estão entregando os mesmos rendimentos.");
                }
                if (capital > r_Fixa)
                {
                    Console.Write("\n\nPOUPANÇA!");
                }
                else
                {
                    Console.Write("\n\nRENDA FIXA!");
                }

                Console.Write("\n\nDeseja realizar o programa novamente?\n\nSe sim digite 'S' ou digite 'N' para encerrar o programa: ");
                opcao = Console.ReadLine();
                opcao = opcao.ToUpper();
            }
            while (opcao != "N");
            

        }
    }
}
