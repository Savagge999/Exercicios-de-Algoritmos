using System.Globalization;

namespace Exercicio14;

internal class Program
{
    static void Main(string[] args)
    {
        #region Enunciado
        /* 14.A locadora de carros precisa da sua ajuda para cobrar seus serviços. Escreva
        um programa que pergunte a quantidade de Km percorridos por um carro alugado e a
        quantidade de dias pelos quais ele foi alugado. Calcule o preço total a pagar,
        sabendo que o carro custa R$90 por dia e R$0,20 por Km rodado. */
        #endregion

        Console.Write("Quantos kilometros foi percorrido: ");

        if (!TryReadDecimal(out decimal kms))
        {
            Console.WriteLine("Valor de KM inválido!");
            return;
        }

        Console.Write("Dias alugado: ");

        if (!TryReadDecimal(out decimal dias))
        {
            Console.WriteLine("Valor de DIAS inválido!");
            return;
        }

        decimal valorTotal = CalcularValorAluguel(kms, dias);

        Console.WriteLine($"Valor total a ser pago: R$" +
            $"{valorTotal.ToString("F2", CultureInfo.InvariantCulture)}");

        Console.ReadKey();
    }

    static bool TryReadDecimal(out decimal valor)
    {
        string? kmTotal = Console.ReadLine();

        return decimal.TryParse(
            kmTotal,
            NumberStyles.Number,
            CultureInfo.InvariantCulture,
            out valor);
    }

    static decimal CalcularValorAluguel(decimal kms, decimal dias)
    {
        const decimal VALOR_POR_DIA = 90m;
        const decimal VALOR_POR_KM = 0.20m;

        return (dias * VALOR_POR_DIA) + (kms * VALOR_POR_KM);
    }
}