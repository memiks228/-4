namespace задача_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 20; N > 0; N--)
            {
                Console.Write(i + " ");
            }
        }
    }
}
