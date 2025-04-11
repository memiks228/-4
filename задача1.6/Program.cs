namespace задача1._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число в системе счисления с основанием 7: ");
            string base7Number = Console.ReadLine();
            int decimalValue = 0;
            int index = base7Number.Length - 1;

            while (index >= 0)
            {
                int digit = base7Number[index] - '0'; 
                decimalValue += digit * (int)Math.Pow(7, base7Number.Length - index - 1);
                index--;
            }

            Console.WriteLine($"Десятичное представление числа {base7Number} равно {decimalValue}");
        }
    }
    
}
