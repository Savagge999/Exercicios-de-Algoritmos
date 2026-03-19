using System.Globalization;

namespace Exercicio15;

internal class Program
{
    static void Main(string[] args)
    {
        #region Enunciado
        /* 15.Crie um programa que leia o número de dias trabalhados em um mês e mostre o
        salário de um funcionário, sabendo que ele trabalha 8 horas por dia e ganha R$25
        por hora trabalhada. */
        #endregion

        Console.Write("Dias trabalhados no mês: ");
        if (!VerificacaoSegura(out int valor))
        {
            Console.WriteLine("\nERRO! Valor inválido! Por favor, digite um número inteiro positivo!\n");
            return;
        }

        decimal salario = Trabalho(valor);

        Console.WriteLine($"Seu sálario mensal é de: R$" +
            $"{salario.ToString("F2", CultureInfo.InvariantCulture)}");

        Console.ReadKey();
    }

    static bool VerificacaoSegura(out int dias)
    {
        string? diasTrabalhados = Console.ReadLine();

        return int.TryParse(diasTrabalhados, out dias);
    }

    static decimal Trabalho(int dias)
    {
        return dias * 8m * 25m;
    }
}