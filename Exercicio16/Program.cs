namespace Exercicio16;

internal class Program
{
    static void Main(string[] args)
    {
        #region Enunciado
        /* 16) [DESAFIO] Escreva um programa para calcular a redução do tempo de vida de um
        fumante. Pergunte a quantidade de cigarros fumados por dias e quantos anos ele
        já fumou. Considere que um fumante perde 10 min de vida a cada cigarro. Calcule
        quantos dias de vida um fumante perderá e exiba o total em dias. */
        #endregion

        Console.Title = "Calculadora de Vida Perdida";

        int cigarrosPorDia = LerNumeroPositivo
            ("Quantos cigarros você fuma por dia? ");

        int anosFumando = LerNumeroPositivo
            ("Quantos anos você já fumou? ");

        double diasPerdidos = CalcularDiasPerdidos
            (cigarrosPorDia, anosFumando);

        Console.Clear();

        Console.WriteLine("===== RESULTADO =====\n");

        Console.WriteLine(
            $"Você perderá aproximadamente " +
            $"{diasPerdidos:F1} dias de vida por fumar.");

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }

    static int LerNumeroPositivo(string mensagem)
    {
        while (true)
        {
            Console.Write(mensagem);

            string? entrada = Console.ReadLine();

            bool numeroValido = int.TryParse(
                entrada,
                out int valor);

            if (numeroValido && valor > 0)
            {
                return valor;
            }

            Console.WriteLine(
                "\nERRO! Digite um número inteiro positivo.\n");
            Console.Beep();
        }
    }

    static double CalcularDiasPerdidos
        (int cigarrosPorDia, int anosFumando)
    {
        int totalCigarros =
            cigarrosPorDia * 365 * anosFumando;

        int minutosPerdidos =
            totalCigarros * 10;

        double diasPerdidos =
            minutosPerdidos / 1440.0;

        return diasPerdidos;
    }
}