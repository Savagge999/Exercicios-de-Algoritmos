namespace Exercicio02;

internal class Program
{
    static void Main(string[] args)
    {
        #region Enunciado
        /* 2.Faça um programa que leia o nome de uma pessoa e mostre uma mensagem de boasvindas para ela:
        Ex:
        Qual é o seu nome? João da Silva
        Olá João da Silva, é um prazer te conhecer!*/
        #endregion

        Console.Write("Qual é o seu nome? ");
        string nome = Console.ReadLine().TrimStart().TrimEnd();
        Console.WriteLine($"Olá {nome}, é um prazer te conhecer!");

        Console.ReadKey();
    }
}