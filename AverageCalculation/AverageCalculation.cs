using System;

namespace AverageCalculation
{
    internal class AverageCalculation
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// 
            /// </summary>

            double number1, number2, number3, number4, average;

            Console.WriteLine("Digite a primeira nota");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");
            number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota");
            number3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quarta nota");
            number4 = int.Parse(Console.ReadLine());

            average = (number1 + number2 + number3 + number4) / 4;

            Console.WriteLine($"Sua média é {average} e o aluno " +
                (average < 5 ? "foi reprovado" : average < 7 ? "está de recuperação" : "foi aprovado"));

            Console.ReadKey();
        }
    }
}
