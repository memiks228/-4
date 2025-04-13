namespace Задача_3._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A
            //double distanceFromHome = 0;

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 == 1) 
            //        distanceFromHome += (1.0 / i);
            //    else 
            //        distanceFromHome -= (1.0 / i);
            //}

            //Console.WriteLine(distanceFromHome);


            //B

            {
                double totalDistance = 0;

                for (int i = 1; i <= 100; i++)
                {
                    totalDistance += (1.0 / i);
                    if (i % 2 == 0)
                        totalDistance += (1.0 / (i - 1));
                }

                Console.WriteLine(totalDistance);
            }
        }
    }
}
