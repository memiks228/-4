namespace Задача_3._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumOfSquares = 0;

            for (int i = 1; i <= 10; i++)
            {
                sumOfSquares += (2 * i - 1); 
                Console.WriteLine(sumOfSquares);
            }
        }
    }
}
