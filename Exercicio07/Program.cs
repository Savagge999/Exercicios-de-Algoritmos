using System.Globalization;

namespace Exercicio07;

internal class Program
{
    static void Main(string[] args)
    {
        #region Enunciado
        /* 7.Crie um algoritmo que leia um número real e mostre na tela o seu dobro e a
        sua terça parte.
        Ex:
        Digite um número: 3.5
        O dobro de 3.5 é 7.0
        A terça parte de 3.5 é 1.16666 */
        #endregion

        Console.Write("Digite um número: ");
        decimal numero = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        decimal dobro = numero * 2m;
        Console.WriteLine($"O dobro de " +
            $"{numero.ToString(CultureInfo.InvariantCulture)} é " +
            $"{dobro.ToString(CultureInfo.InvariantCulture)}");

        decimal tercaParte = numero / 3m;
        Console.WriteLine($"A terça parde de " +
            $"{numero.ToString(CultureInfo.InvariantCulture)} é " +
            $"{tercaParte.ToString("F5", CultureInfo.InvariantCulture)}");

        Console.ReadKey();
    }
}