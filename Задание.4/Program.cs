namespace Задание1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число N для перевода в двоичную систему: ");
            int N = int.Parse(Console.ReadLine());
            string binary = ("");


            while (N > 0)
            {
                int remainder = N % 5;
                binary = remainder + binary;
                N /= 5;
            }
            Console.WriteLine($"Число в пятиричной системе: {binary}");
        }
    }
}
