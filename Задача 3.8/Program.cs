namespace Задача_3._8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int count = int.Parse(Console.ReadLine());
            double total = 0;
            for (int i = 1; i <= count; i++)
            {
                total += double.Parse(Console.ReadLine());
            }
            double res = total / count;
            Console.WriteLine(res);
        }
    }
}

