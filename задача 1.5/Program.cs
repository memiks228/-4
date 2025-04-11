namespace задача_1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите двоичное число: ");
            string binary = Console.ReadLine();
            int decimalValue = 0;
            int index = binary.Length - 1;

            while (index >= 0)
            {
                if (binary[index] == '1')
                {
                    decimalValue += (int)Math.Pow(2, binary.Length - index - 1);
                }
                index--;
            }

            Console.WriteLine($"Десятичное представление числа {binary} равно {decimalValue}");
        }
    }
}

