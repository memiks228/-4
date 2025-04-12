namespace Задача_3._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double sumOfReciprocalFactorials = 1.0; 

            for (int k = 1; k <= n; k++)
            {
                long factorial = 1;
                for (int j = 1; j <= k; j++)
                {
                    factorial *= j;
                }

                sumOfReciprocalFactorials += (double)1 / factorial;
                Console.WriteLine(1.0 / factorial);
            }

            Console.WriteLine(sumOfReciprocalFactorials);
        }
    }
}
