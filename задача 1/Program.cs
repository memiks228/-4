using System.Runtime.InteropServices;

namespace задача_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N =int.Parse(Console.ReadLine());
            
            while (N > 0)

            {
                int digit = N % 10;
                Console.WriteLine(digit + "");
                N  /= 10;


            }
            
        }
        
    }
}
