namespace Задача_1._3
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
                int remainder = N % 2;
                binary = remainder + binary;
                N /= 2;
            }
            Console.WriteLine($"Число в двоичной системе: {binary}");
        }
    }
}
