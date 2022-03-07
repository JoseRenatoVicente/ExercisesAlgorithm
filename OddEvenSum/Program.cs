using System;

namespace OddEvenSum
{
    internal class OddEvenSum
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// 3. Escreva um programa que leia vários inteiros positivos e mostre, no final, a soma 
            /// dos números  pares e  a soma  dos números  ímpares.O programa  para quando
            /// entrar um número maior que 1000
            /// </summary>

            int[] numbers = new int[6];

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Digite o {0}º número", i);
                numbers[i] = int.Parse(Console.ReadLine());

                if (numbers[i] > 1000)
                    Environment.Exit(0);
            }

            int resultPair = 0, resultOdd = 0;

            for (int i = 0; i < 6; i++)
            {
                if (numbers[i] % 2 == 0)
                    resultPair += numbers[i];

                else
                    resultOdd += numbers[i];

            }

            Console.Clear();

            Console.WriteLine($"A soma dos números pares é {resultPair} e o dos ímpares é {resultOdd}");

            Console.WriteLine("A soma dos números pares é {0} e o dos ímpares é {1}",
                numbers.AsQueryable().Where(x => x % 2 == 0).Sum(),
                numbers.AsQueryable().Where(x => x % 2 != 0).Sum());

            Console.ReadKey();
        }
    }
}
