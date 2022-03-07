using System;

namespace TriangleType
{
    internal class TriangleType
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// 4) Faça um algoritmo e leia o valor dos três lados de um triângulo e informe qual o tipo dele.
            /// </summary>

            double side1, side2, side3;

            Console.WriteLine("Digite o lado 1 do triângulo:");
            side1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o lado 2 do triângulo:");
            side2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o lado 3 do triângulo:");
            side3 = int.Parse(Console.ReadLine());

            if (side1 == side2 && side2 == side3)
                Console.WriteLine("O tipo do triângulo é Equilátero");
            else if (side1 == side2 || side2 == side3 || side1 == side3)
                Console.WriteLine("O tipo do triângulo é Isósceles");
            else
                Console.WriteLine("O tipo do triângulo é Escaleno");

            Console.ReadKey();
        }
    }
}
