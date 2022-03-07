using System;

namespace PrimeNumberCalculator
{
    internal class PrimeNumberCalculator
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// 4. Faça um programa que leia um número n e imprima se ele é primo ou não.
            /// 
            /// Condições para um número ser primo
            /// 
            /// 1- O número 1 não é primo
            /// 2- é maior que 1
            /// 3- Possui apenas 2 divisores, si próprio e por 1 
            /// 4- Com execeção do 2 todos os números primos são ímpares
            /// 
            /// </summary>
            /// 

            Console.WriteLine("Digite o número");
            float number = float.Parse(Console.ReadLine());

            //Console.Clear();
            Console.WriteLine(IsPrime(number) ? "O número é primo" : "Não é um número primo");
            Console.ReadKey();
        }

        public static bool IsPrime(float number)
        {
            int dividers = 0;

            if (number == 2) return true;
            if (number <= 1 || number % 2 == 0) return false;

            for (float i = 1; i <= number; i++)
            {
                if (number % i == 0 || dividers > 2)
                    dividers++;
            }

            if (dividers == 2)
                return true;

            return false;
        }


        public static bool IsPrimeMath(float number)
        {
            if (number == 2) return true;
            if (number <= 1 || number % 2 == 0) return false;

            for (float i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

    }
}
