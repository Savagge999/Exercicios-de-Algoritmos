using System.Globalization;

namespace Exercicio09;

internal class Program
{
    static void Main(string[] args)
    {
        #region Enunciado
        /* 9.Faça um algoritmo que leia quanto dinheiro uma pessoa tem na carteira (em R$)
        e mostre quantos dólares ela pode comprar. Considere US$1,00 = R$3,45. */
        #endregion

        Console.Write("Quantos reais possui em sua carteira? ");
        decimal reais = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        decimal dolares = reais / 3.45m;

        string dollar = "dolares";
        string real = "reais";

        if (dolares == 1m)
        {
            dollar = "dollar";
        }
        else if (dolares < 1m)
        {
            dollar = "centavos de dolares";
        }

        if (reais == 1m)
        {
            real = "real";
        }
        else if (reais < 1m)
        {
            real = "centavos de reais";
        }

        Console.WriteLine($"Com a quantia de R$" +
            $"{reais.ToString("F2", CultureInfo.InvariantCulture)} {real}, você pode obter US$" +
            $"{dolares.ToString("F2", CultureInfo.InvariantCulture)} {dollar}.");

        Console.ReadKey();
    }
}