namespace KeyboardKey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// Faça um programa que leia uma tecla e diga se seu código unicode é par ou impar

            Console.Write("Digite um tecla: ");
            int key = Console.Read();

            Console.WriteLine("A tecla digitada representa o número {0} e portanto é {1}", key,
                    (key % 2 == 0 ? "par" : "impar"));            

            Console.ReadKey();
        }
    }
}
