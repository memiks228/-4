namespace Задача_3._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            double x = double.Parse(Console.ReadLine());

            double sum = 0;

            for (int i = 1; i <= 11; i += 2)
            {
                double term = Math.Pow(x, i) / i;
                sum += term;
            }

            Console.WriteLine($"Сумма: {sum}");
        }
    }
}
