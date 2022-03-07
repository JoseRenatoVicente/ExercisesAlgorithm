using System;

namespace SalaryReadjustment
{
    internal class SalaryReadjustment
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// 2- Faça um algortimo que leia o salário de uma pessoa e calcule o aumento de acordo com os seguintes critérios:
            /// a) de 0 a 200, nenhum reajuste
            /// b) de 200 a 400, 20 % de acréscimo
            /// c) de 400 a 600, 30 % de acréscimo
            /// d) acima de 600, 40 % de acréscimo
            /// </summary>

            double salary;

            Console.WriteLine("Informe o seu salário atual");
            salary = double.Parse(Console.ReadLine());

            if (salary <= 200)
                Console.WriteLine("Seu salário não teve nenhum reajuste");
            else if (salary <= 400)
                Console.WriteLine("Seu salário teve reajuste de 20% ficando no total de R$" + (salary * 1.2));
            else if (salary <= 600)
                Console.WriteLine("Seu salário teve reajuste de 30% ficando no total de " + (salary * 1.3));
            else
                Console.WriteLine("Seu salário teve reajuste de 40% ficando no total de " + (salary * 1.4));
            
            Console.ReadKey();
        }
    }
}
