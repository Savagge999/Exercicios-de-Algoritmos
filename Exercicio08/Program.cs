using System.Globalization;

namespace Exercicio08;

internal class Program
{
    static void Main(string[] args)
    {
        #region Enunciado
        /* 8.Desenvolva um programa que leia uma distância em metros e mostre os valores
        relativos em outras medidas.
        Ex:
        Digite uma distância em metros: 185.72
        A distância de 85.7m corresponde a:
        0.18572Km
        1.8572Hm
        18.572Dam
        1857.2dm
        18572.0cm
        185720.0mm */

        // Obs: No PDF está exatamente igual acima, mas reconheço que é apenas um erro comum
        // e que na verdade deveria estar assim: "A distância de 185.72m corresponde a:"
        #endregion

        Console.Write("Digite uma distância em metros: ");
        double metros = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine($"A distância de " +
            $"{metros.ToString(CultureInfo.InvariantCulture)}m corresponte a:");

        double kilometros = metros / 1000.0;
        Console.WriteLine($"{kilometros.ToString("F5", CultureInfo.InvariantCulture)}Km");

        double hectometros = metros / 100.0;
        Console.WriteLine($"{hectometros.ToString("F4", CultureInfo.InvariantCulture)}Hm");

        double decametros = metros / 10.0;
        Console.WriteLine($"{decametros.ToString("F3", CultureInfo.InvariantCulture)}Dam");

        double decimetros = metros * 10.0;
        Console.WriteLine($"{decimetros.ToString("F1", CultureInfo.InvariantCulture)}dm");

        double centimetros = metros * 100.0;
        Console.WriteLine($"{centimetros.ToString("F1", CultureInfo.InvariantCulture)}cm");

        double milimetros = metros * 1000.0;
        Console.WriteLine($"{milimetros.ToString("F1", CultureInfo.InvariantCulture)}mm");

        Console.ReadKey();
    }
}