using System.Globalization;

namespace Exercicio05;

internal class Program
{
    static void Main(string[] args)
    {
        #region Enunciado
        /* 5.Faça um programa que leia as duas notas de um aluno em uma matéria e mostre
        na tela a sua média na disciplina.
        Ex:
        Nota 1: 4.5
        Nota 2: 8.5
        A média entre 4.5 e 8.5 é igual a 6.5 */
        #endregion

        Console.Write("Nota 1: ");
        double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Nota 2: ");
        double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double media = (nota1 + nota2) / 2.0;

        Console.WriteLine();

        Console.WriteLine($"A média entre " +
            $"{nota1.ToString("F1", CultureInfo.InvariantCulture)} e " +
            $"{nota2.ToString("F1", CultureInfo.InvariantCulture)} é igual a " +
            $"{media.ToString("F1", CultureInfo.InvariantCulture)}");

        Console.ReadKey();
    }
}