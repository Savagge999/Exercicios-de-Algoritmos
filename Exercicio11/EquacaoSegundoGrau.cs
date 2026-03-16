using System.Globalization;

namespace Exercicio11;

internal class EquacaoSegundoGrau
{

    public double CalcularValorDelta(double a, double b, double c)
    {
        return Math.Pow(b, 2) - (4.0 * a * c);
    }

    public void DeltaPossuiRaizes(double a, double b, double delta)
    {
        if (delta < 0)
        {
            Console.WriteLine("A equação não possui raízes reais.");
            return;
        }

        if (delta == 0)
        {
            double x = -b / (2.0 * a);
            Console.WriteLine($"A equação apresenta uma raiz real - x: " +
                $"{x.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        else
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine("A equação possui duas raízes reais:");
            Console.WriteLine($"x1: {x1.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"x2: {x2.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}