namespace Задача_2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double count;
            Random rnd = new Random();
            do
            {
                count = rnd.Next(1, 10);
                Console.WriteLine(count);
            } while (count != 7);

        }
    }
}
