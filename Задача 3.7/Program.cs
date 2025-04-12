namespace Задача_3._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
                total = double.Parse(Console.ReadLine());
            }
            double res = total / 10;
            Console.WriteLine(res);

        }
    }
}
