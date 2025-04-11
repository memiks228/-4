namespace Задание_2._3
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int c;

            do
            {
                Console.WriteLine("введите цифру с 1 до 100");
                c = int.Parse(Console.ReadLine());

            } while (c >= 101 && c >= 0);
            Console.WriteLine($"введенное число {c}");
        }
    }
}

