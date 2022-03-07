using System;

namespace FactorialCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int currentNumber;

            Console.Write("Digite o primeiro número: ");
            currentNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < 5; i++)
            {
                currentNumber += currentNumber + 1;
                Console.WriteLine(currentNumber);
            }
            Console.WriteLine("O resultado da 5ª soma é:" + currentNumber);

            Console.ReadKey();
        }
    }
}
