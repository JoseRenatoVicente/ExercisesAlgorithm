using System;

namespace IdealWeight
{
    internal class IdealWeight
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// 1- Faça um algortimo que leia altura e o sexo de uma pessoa e calcule seu peso ideal seguindo a seguinte fórmula: 
            /// a) para homens: 72,7 x altura -58
            /// b) para mulheres: 62,1 x altura -44,7
            /// </summary>

            double height;
            char sex;

            Console.WriteLine("Informe seu sexo, m para masculino e f para feminino");
            sex = char.Parse(Console.ReadLine().ToLower());

            Console.WriteLine("Digite sua altura:");
            height = double.Parse(Console.ReadLine().Replace(",", ".").Replace(".", ",")) / 100;

            if (height < 1.0)
                Console.WriteLine("A altura deve ser no minímo 1 metro");
            else if (sex == 'm')
                Console.WriteLine("Seu peso ideal é: " + (72.7 * height - 58) + " kg");
            else if (sex == 'f')
                Console.WriteLine("Seu peso ideal é: " + (62.1 * height - 44.7) + " kg");
            else
                Console.WriteLine("Opção digitada é inválida");

            Console.ReadKey();

        }
    }
}
