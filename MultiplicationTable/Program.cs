using System;

namespace MultiplicationTable
{
    internal class MultiplicationTable
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// 2. Escreva  um  programa  que  leia  um  número  de  1  a  9  e  imprima  sua  respectiva tabuada.
            /// </summary>

            int number;

            Console.WriteLine("Digite um número entre 1 e 9 que deseja saber a tabuada");
            number = int.Parse(Console.ReadLine());

            if (number < 1 || number > 9)
                Console.WriteLine("o número deve ser entre 1 e 9");

            else
            {
                for (int i = 1; i <= 10; i++)
                    Console.WriteLine($"{number} x {i} = {number * i}");
            }
            Console.ReadKey();
        }
    }
}
