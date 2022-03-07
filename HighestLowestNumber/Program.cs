using System;

namespace HighestLowestNumber
{
    internal class HighestLowestNumber
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// 1- Escreva  um  programa  que  leia  15  valores  reais  e  encontre  o  maior  e  o  menor 
            /// deles, mostrando o resultado
            /// </summary>

            double[] numbers = new double[15];

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Digite o {0}º número", i + 1);
                numbers[i] = double.Parse(Console.ReadLine());
            }

            Console.Clear();

            double bigNumber = 0, lowerNumber = 1;

            foreach (var number in numbers)
            {
                if (bigNumber <= number)
                    bigNumber = number;

                if(lowerNumber >= number)
                    lowerNumber = number;
            }

            Console.WriteLine($"O maior número é {bigNumber} e o menor número é {lowerNumber}");


            //Console.WriteLine("O maior número é {0} e o menor número é {1}", numbers.AsQueryable().Max(), numbers.AsQueryable().Min());

            Console.ReadKey();
        }
    }
}
