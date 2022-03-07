using System;

namespace CircleArea
{
    public class CircleArea
    {
        public static void Main(string[] args)
        {
            /// <summary>
            /// 3) Faça um algoritmo que leia o valor do raio de um círculo e calcule sua área.
            /// </summary>

            double radius;

            Console.WriteLine("Digite o raio do círculo");
            radius = double.Parse(Console.ReadLine());

            Console.WriteLine("A área do circulo é: " + (3.14159265359 * (radius * radius)));

            Console.ReadKey();
        }
    }
}
