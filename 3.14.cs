namespace Задача_3._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long factorialSum = 0;

            for (int k = 1; k <= n; k++)
            {
                long factorial = 1;
                for (int j = 1; j <= k; j++)
                {
                    factorial *= j;
                }
                factorialSum += factorial;
                Console.WriteLine(factorial);

            }

            Console.WriteLine(factorialSum);

        }
    }
}
