using System.Globalization;

namespace Exercicio11;

internal class Program
{
    static void Main(string[] args)
    {
        #region Enunciado
        /* 11.Desenvolva uma lógica que leia os valores de A, B e C de uma equação do
        segundo grau e mostre o valor de Delta. */
        #endregion

        Console.Write("Digite o valor de A: ");
        double valorA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if (valorA == 0)
        {
            Console.Beep();
            Console.WriteLine("\nERRO: O valor de A não pode ser 0!");
            Console.ReadKey();
            return;
        }

        Console.Write("Digite o valor de B: ");
        double valorB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Digite o valor de C: ");
        double valorC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        EquacaoSegundoGrau calculadora = new EquacaoSegundoGrau();

        double delta = calculadora.CalcularValorDelta(valorA, valorB, valorC);

        Console.WriteLine($"\nValor de Delta: " +
            $"{delta.ToString("F2", CultureInfo.InvariantCulture)}");

        calculadora.DeltaPossuiRaizes(valorA, valorB, delta);

        Console.ReadKey();
    }
}