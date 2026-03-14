namespace Exercicio06;

internal class Program
{
    static void Main(string[] args)
    {
        #region Enunciado
        /* 6.Faça um programa que leia um número inteiro e mostre o seu antecessor e seu
        sucessor.
        Ex:
        Digite um número: 9
        O antecessor de 9 é 8
        O sucessor de 9 é 10 */
        #endregion

        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        int antecessor = numero - 1;
        int sucessor = numero + 1;

        Console.WriteLine($"O antecessor de {numero} é {antecessor}");
        Console.WriteLine($"O sucessor de {numero} é {sucessor}");

        Console.ReadKey();
    }
}