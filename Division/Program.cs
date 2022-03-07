using System;

namespace Division
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double number1, number2, result = 0;

            Console.WriteLine("Digite o primeiro número:");
            number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            number2 = double.Parse(Console.ReadLine());


            while (number1 >= number2)
            {
                result++;
                number1 -= number2;
            }
            Console.WriteLine("resultado: " + result+" e a sobra é: "+ number1);

            Console.ReadKey();
        }
    }
}
