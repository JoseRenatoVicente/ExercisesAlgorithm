using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CountVowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Faça um código que leia o seu nome completo e conte quantas vogais tem no nome

            string name ="";
            int vowels = 0;

            Console.WriteLine("Digite o primeiro número:");
            name = Console.ReadLine().ToLower().Replace(" ", "");

            //vowels = name.Count(c => (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'));

            foreach (var sub in name.Split('a', 'e', 'i', 'o', 'u'))
            {
                Console.WriteLine($"Substring: {sub}");
            }

            vowels = name.Split('a', 'e', 'i', 'o', 'u').Length;

            Console.WriteLine("O nome possui {0} vogais e {1} consoante", vowels, name.Length - vowels);

            Console.ReadKey();
            /*Console.WriteLine("O nome possui {0} vogais",
                name.Count(c => 
            (c == 'a' || c=='e' || c == 'i' || c == 'o' || c == 'u')));

            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == 'a' || name[i] == 'e' || name[i] == 'i' || name[i] == 'o' || name[i] == 'u')
                    vowels++;
            }

            Console.WriteLine(vowels);*/

        }
    }
}
