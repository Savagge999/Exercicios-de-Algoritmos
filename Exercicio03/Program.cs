using System.Globalization;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Enunciado
            /* 3.Crie um programa que leia o nome e o salário de um funcionário, mostrando no
            final uma mensagem.
            Ex:
            Nome do Funcionário: Maria do Carmo
            Salário: 1850,45
            O funcionário Maria do Carmo tem um salário de R$1850,45 em Junho. */
            #endregion

            Console.Write("Nome do Funcionário: ");
            string nome = Console.ReadLine().TrimStart().TrimEnd();

            Console.Write("Salário: ");
            decimal salario = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine($"O funcionário " +
                $"{nome} tem um salário de R$" +
                $"{salario.ToString("F2", CultureInfo.InvariantCulture)} em " +
                $"{MesAtual(DateTime.Now.Month)}.");

            Console.ReadKey();
        }
        public static string MesAtual(int mes)
        {
            string mesAtual = "";
            switch (mes)
            {
                case 1:
                    mesAtual = "Janeiro";
                    break;
                case 2:
                    mesAtual = "Fevereiro";
                    break;
                case 3:
                    mesAtual = "Março";
                    break;
                case 4:
                    mesAtual = "Abril";
                    break;
                case 5:
                    mesAtual = "Maio";
                    break;
                case 6:
                    mesAtual = "Junho";
                    break;
                case 7:
                    mesAtual = "Julho";
                    break;
                case 8:
                    mesAtual = "Agosto";
                    break;
                case 9:
                    mesAtual = "Setembro";
                    break;
                case 10:
                    mesAtual = "Outubro";
                    break;
                case 11:
                    mesAtual = "Novembro";
                    break;
                case 12:
                    mesAtual = "Dezembro";
                    break;
            }
            return mesAtual;
        }
    }
}