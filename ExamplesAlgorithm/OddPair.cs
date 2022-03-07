using System;

namespace ExamplesAlgorithm
{
    internal class OddPair
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// 1) Faça um algoritmo que leia dois numero inteiros e faça a soma dos dois,
            ///  informe se o resultado é par ou impar.
            /// </summary>

            int number1, number2;

            Console.WriteLine("Digite o primeiro número");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            number2 = int.Parse(Console.ReadLine());

            if (number1 + number2 == 0)
            {
                Console.WriteLine("Neutro!");
            }
            else
            {
                Console.WriteLine("O resultado da soma é " +
                    ((number1 + number2) % 2 == 0 ? "par" : "ímpar"));
            }
            Console.ReadKey();


        }

    }
}
