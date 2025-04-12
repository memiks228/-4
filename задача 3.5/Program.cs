namespace задача_3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());

            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += (i % 2 == 0 ? -1 : 1) / (double)i;
            }

            Console.WriteLine($"Сумма: {sum}");
        }
    }
}
