using SortNumbers.SortAlgorithm;
using System;
using System.Linq;

namespace SortNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Faça um programa que sortei 10 números inteiros e insira-os em um vetor de forma ordenada. Ex:5,7,8
            /// depois algorithm QuickSort, BubbleSort, HeapSort
            /// </summary>
            /// 

            int[] randomNumbers = new int[10];

            Random random = new Random();

            Console.WriteLine("[{0}]", string.Join(", ", randomNumbers));

            Console.WriteLine("[{0}]", string.Join(", ", randomNumbers.OrderBy(i => i).ToArray()));

            for (int left = 0; left < 12; left++)
            {
                int auxiliary = 0;
                for (int right = left + 1; right < randomNumbers.Length; right++)
                {
                    if (randomNumbers.Length < 10) randomNumbers[left] = random.Next(0, 11);


                    if (randomNumbers[left] > randomNumbers[right])
                    {
                        auxiliary = randomNumbers[left];
                        randomNumbers[left] = randomNumbers[right];
                        randomNumbers[right] = auxiliary;
                        Console.WriteLine("[{0}]", string.Join(", ", randomNumbers));
                    }
                }
            }


        }


    }
}
