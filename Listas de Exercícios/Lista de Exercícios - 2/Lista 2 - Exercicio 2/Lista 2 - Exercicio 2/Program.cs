using System;
using System.Globalization;

namespace Lista_2___Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            2. Calcular a quantidade de dinheiro gasta por um fumante. Dados: o número de anos que
               ele fuma, o nº de cigarros fumados por dia e o preço de uma carteira. 
            */
            string nome;
            int cig_fumados = 0;
            int anos_cigarros = 0;
            double preco = 0;
            double custo_cigarro = 0;
            int consumo_anual = 0;
            int consumo_total = 0;

            
            // Entrada de dados
            Console.Write(">>>>>>>>>>>>>>>>>>Dinheiro gasto por um fumante!<<<<<<<<<<<<<<<<<");
            Console.Write("\n\nDigite seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite a quantidade de cigarros fumados por dia: ");
            cig_fumados = int.Parse(Console.ReadLine());
            Console.Write("Digite quantos anos você fuma: ");
            anos_cigarros = int.Parse(Console.ReadLine());
            Console.Write("Digite o preço da cartela de cigarro: ");
            preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Processamento

            custo_cigarro = preco / 20;
            consumo_anual = cig_fumados * 365;
            consumo_total = consumo_anual * anos_cigarros;
            custo_cigarro = (double)consumo_total * custo_cigarro;

            //Saída

            Console.Clear();
            Console.Write("\n\nRelatório de Gastos com Cigarros!" );
            Console.Write("\n\n" + nome + " você consumiu " + consumo_total + " cigarros.");
            Console.Write("\n\nSeu gasto total com cigarros foi de: R$"+ custo_cigarro,CultureInfo.InvariantCulture);
            Console.ReadLine();


        }
    }
}
