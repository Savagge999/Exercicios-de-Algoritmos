using System.Globalization;
namespace Exercicio12;

internal class Program
{
    /* Nesse Exercício, busquei estudar como fazer uma verificação masi rigida.
       Então ao invés do Convert e do Parse, usei o TryParse que é mais seguro e
       que também é bastante utilizado em sistemas web e API's. Nisso reforçando
       o conhecimento e mantendo um padrão para futuros projetos. */
    static void Main(string[] args)
    {
        #region Enunciado
        /* 12.Crie um programa que leia o preço de um produto, calcule e mostre o seu
        PREÇO PROMOCIONAL, com 5% de desconto. */
        #endregion

        Console.Write("Valor do produto: ");

        if (!VerificarValor(out decimal valor))
        {
            Console.WriteLine("Valor do produto inválido!");
            return;
        }

        decimal valorComDesconto = CalculoParaDesconto(valor, 5);

        Console.WriteLine($"Valor final com 5% de desconto: " +
            $"{valorComDesconto.ToString("F2", CultureInfo.InvariantCulture)}");

        Console.ReadKey();
    }

    //Método para verificar se o valor digitado é válido.
    static bool VerificarValor(out decimal valor)
    {
        string? valorDoProduto = Console.ReadLine();

        return decimal.TryParse(
            valorDoProduto,
            NumberStyles.Number,
            CultureInfo.InvariantCulture,
            out valor);
    }

    // Método para calcular desconto.
    static decimal CalculoParaDesconto(decimal valor, decimal porcentagem)
    {
        return valor - (valor * porcentagem / 100);
    }
}