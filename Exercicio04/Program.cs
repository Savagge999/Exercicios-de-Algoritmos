namespace Exercicio04;

internal class Program
{
    static void Main(string[] args)
    {
        #region Enunciado
        /* 4.Desenvolva um algoritmo que leia dois números inteiros e mostre o somatório
        entre eles.
        Ex:
        Digite um valor: 8
        Digite outro valor: 5
        A soma entre 8 e 5 é igual a 13.*/
        #endregion

        Console.Write("Digite um valor: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("Digite outro valor: ");
        int numero2 = int.Parse(Console.ReadLine());

        int total = numero1 + numero2;

        Console.WriteLine($"A soma entre " +
            $"{numero1} e {numero2} é igual a " +
            $"{total}");

        Console.ReadKey();
    }
}