namespace Задача_1ю2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int digit = N / 50;
            Console.WriteLine(digit);
            int mouth = 0;
            while (N <= 100000)

            {

                N += digit ;
                Console.WriteLine(N);
                mouth++;

            }
            Console.WriteLine($"Вы накопили сумму через {mouth} месяцев");

        }


    }
}

