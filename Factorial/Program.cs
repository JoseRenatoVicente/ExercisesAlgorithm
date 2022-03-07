using System;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long factorial, result = 1;

            Console.WriteLine("Digite o número que deseja saber o fatorial: ");
            factorial = uint.Parse(Console.ReadLine());

            if (factorial < 0)
                Console.WriteLine("Número invalido");
            else
            {
                Console.WriteLine($"Fatorial é {Factorial(factorial)}");

                while (factorial > 1)
                    result *= factorial--;

                Console.WriteLine($"Fatorial é {result}");
            }

            Console.ReadKey();
        }

        public static long Factorial(long number)
        {
            return number <= 1 ? 1 : number * Factorial(--number);
        }
    }
}
