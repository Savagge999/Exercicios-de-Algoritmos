using System.Globalization;

namespace Exercicio10;

internal class Program
{
    static void Main(string[] args)
    {
        #region Enunciado
        /* 10.Faça um algoritmo que leia a largura e altura de uma parede, calcule e
        mostre a área a ser pintada e a quantidade de tinta necessária para o serviço,
        sabendo que cada litro de tinta pinta uma área de 2metros quadrados. */
        #endregion

        Console.Write("Digite a altura em metros: ");
        double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Digite a largura em metros: ");
        double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double metroQuadrado = altura * largura;
        double consumoTinta = metroQuadrado / 2.0;

        Console.WriteLine($"\nÁrea total: " +
            $"{metroQuadrado.ToString("F2", CultureInfo.InvariantCulture)} metros quadrado.");
        Console.WriteLine($"Quantidade necessária: " +
            $"{consumoTinta.ToString("F2", CultureInfo.InvariantCulture)} litros de tinta.");

        Console.ReadKey();
    }
}