using System;

namespace MathematicalOperation
{
    internal class MathematicalOperation
    {
        static void Main(string[] args)
        {

            /// <summary>
            /// 2) Faça um algoritmo que leia dois números. Peça ao usuário selecionar a operação matemática
            /// que deseja fazer, execute a operação e mostre o resultado
            /// </summary>

            double number1, number2;
            char operation;

            Console.WriteLine("Digite o primeiro número ");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Operação");
            operation = char.Parse(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    Console.WriteLine("o resultado da soma é: " + (number1 + number2));
                    break;
                case '-':
                    Console.WriteLine("o resultado da subtração é: " + (number1 - number2));
                    break;

                case '*':
                    Console.WriteLine("o resultado da multiplicação é: " + (number1 * number2));
                    break;

                case '%':
                    Console.WriteLine("o resultado da porcentagem é: " + (number1 % number2));
                    break;

                case '/':                    
                    Console.WriteLine(
                        number2 != 0 ? "o resultado da divisão é: " + (number1 / number2) : "A divisão não pode ser feita");
                    break;
                default: 
                    Console.WriteLine("Caracter inválido"); 
                    break;

            }


            Console.ReadKey();
        }
    }
}
