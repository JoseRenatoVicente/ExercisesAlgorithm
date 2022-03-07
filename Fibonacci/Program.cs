using System;

namespace Fibonacci
{
    internal class Fibonacci
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// 6. Escreva  um  programa  que  leia  um  valor  e  imprima  a  sequência  de  Fibonacci 
            /// usando o valor digitado como posição de parada
            /// </summary>
            /// 

            Console.WriteLine("Digite o número de parada da sequência");
            int stopNumber = int.Parse(Console.ReadLine());
            
            Console.WriteLine(stopNumber == 0 ? "Nenhum número para mostrar" : "A sequência é:");

            for (int i = 0; i < stopNumber; i++)
            {
                int currentNumber;

                currentNumber = Fibo(i);
                Console.Write(currentNumber == 0 ? currentNumber : ", " + currentNumber);
            }

            /*int resultCurrent = 1, resultPreviousNumber = 0, previousNumber = 1;
            if (stopNumber >= 1)
                Console.Write("0");
            else
                Console.WriteLine("Nenhum número para mostrar");

            for (int i = 0; i <= stopNumber - 2; i++)
            {
                Console.Write(", " + resultCurrent);
                resultCurrent = resultPreviousNumber + previousNumber;
                resultPreviousNumber = previousNumber;
                previousNumber = resultCurrent;
            }*/

            Console.ReadKey();
        }

        public static int Fibo(int n)
        {
            return (n < 2) ? n : Fibo(n - 1) + Fibo(n - 2);
        }
    }
}
