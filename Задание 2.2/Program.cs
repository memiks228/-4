namespace Задание_2._2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int c;
            int number = 0;
            int count = 0;
            do
            {
                c = int.Parse(Console.ReadLine());
                Console.WriteLine("введите цифру 0");
                count++;
                number += c;
                

            } while (c != 0);
            int  result = number / count;
            Console.WriteLine($"среднее арифмитическое {result}" );
        }
    }
}

