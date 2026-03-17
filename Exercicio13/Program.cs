using System.Globalization;

namespace Exercicio13;

internal class Program
{
    static void Main(string[] args)
    {
        #region Enunciado
        /* 13.Faça um algoritmo que leia o salário de um funcionário, calcule e mostre o
        seu novo salário, com 15% de aumento. */
        #endregion

        Console.Write("Salário do funcionário: ");

        if (!SalarioValido(out decimal valor))
        {
            Console.WriteLine($"Valor inválido!");
            return;
        }

        decimal salarioComAumento = AumentoSalarial(valor, 15);

        Console.WriteLine($"Salário com aumento de 15%: " +
            $"{salarioComAumento.ToString("F2", CultureInfo.InvariantCulture)}");

        Console.ReadKey();
    }

    static bool SalarioValido(out decimal salario)
    {
        string? SalarioFuncionario = Console.ReadLine();

        return decimal.TryParse(
            SalarioFuncionario,
            NumberStyles.Number,
            CultureInfo.InvariantCulture,
            out salario);
    }

    static decimal AumentoSalarial(decimal valor, decimal porcentagem)
    {
        return valor + (valor * porcentagem / 100);
    }
}