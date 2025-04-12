namespace Задача_3._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A
            //double area = 100;
            //double yield = 20;

            //for (int year = 2; year <= 8; year++)
            //{
            //    area *= 1.05;
            //    yield *= 1.02;
            //    Console.WriteLine($"Урожайность в год {year}: {yield:F2} центнеров с гектара");
            {
                //b
                //double area = 100;

                //for (int year = 4; year <= 7; year++)
                //{
                //    area *= 1.05;
                //    Console.WriteLine($"Площадь участка в год {year}: {area:F2} гектаров");
                //}
                {
                    double area = 100;
                    double yield = 20;
                    double totalHarvest = yield * area;

                    for (int year = 2; year <= 6; year++)
                    {
                        area *= 1.05;
                        yield *= 1.02;
                        totalHarvest += yield * area;
                    }

                    Console.WriteLine($"Урожай за первые шесть лет: {totalHarvest:F2} центнеров");
                }
            }
        }
    }
}
