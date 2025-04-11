namespace задача_2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число ограничение ");
            int  border = int.Parse(Console.ReadLine());
            int count = 0;
            int result = 1;
            Console.Write(count + "");
            do
            {
                int buf = count + result;
                count = result;
                result = buf;
                Console.Write($" {result}");

            } while (result <= border);

        }
    }
}
