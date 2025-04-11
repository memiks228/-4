namespace задание2._1
{
    internal class Program
    {
        static void Main(string[] args)
                                            
        {
            int c;
            int number = 0;
            do
            {
                c = int.Parse(Console.ReadLine());
                Console.WriteLine("введите цифру 0");
                number += c;

            } while (c != 0);
            Console.WriteLine(number);
        }
    }
}
