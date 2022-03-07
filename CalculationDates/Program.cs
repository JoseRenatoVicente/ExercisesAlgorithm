using System;

namespace CalculationDates
{
    internal class CalculationDates
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// 5. Escrever um programa em C que calcula a número de dias decorridos entre duas 
            /// datas lidas: a data mais antiga e a data mais recente. Considerar a ocorrência de
            /// anos bissextos.  Considerar o  seguinte intervalo  para o  valor  do ano fornecido: 
            /// 1950 - 1996(1952 foi um ano bissexto).
            /// 
            /// </summary>
            /// 

            Console.WriteLine("Digite a data mais antiga no formato dd/mm/aaaa: ");
            DateTime oldDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Digite a data mais recente: ");
            DateTime newDate = DateTime.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine(oldDate < newDate ?
                (newDate - oldDate).Days + " dias decorridos" : "A data inicial deve ser menor que a data final");

            /*Console.WriteLine("Digite a data mais antiga: ");
            int oldDate = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a data mais recente: ");
            int newDate = int.Parse(Console.ReadLine());

            int days = (newDate - oldDate) * 365;

            for (int i = 0; i <= (newDate - oldDate); i++)
            {
                int currentDate = oldDate + i;

                if (currentDate % 4 == 0 && currentDate % 400 == 0 && currentDate % 100 == 0)
                    days++;

                else if (currentDate % 4 == 0 && currentDate % 100 != 0)
                    days++;
            }

            Console.WriteLine(days + " dias decorridos");*/

            Console.ReadKey();
        }



    }
}

