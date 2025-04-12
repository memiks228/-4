namespace Задача_3._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A
            //double distance = 10;
            //for (int day = 1; day <= 10; day++)
            //{
            //    if (day > 1)
            //        distance *= 1.1;

            //    Console.WriteLine($"Пробег за день {day}: {distance:F2} км");
            //}
            //B
            double distance = 10;
            double totalDistance = distance;

            for (int day = 2; day <= 7; day++)
            {
                distance *= 1.1;
                totalDistance += distance;
            }

            Console.WriteLine($totalDistance);
        }
    }
}
