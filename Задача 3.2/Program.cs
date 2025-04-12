namespace задача_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int z = int.Parse(Console.ReadLine());

            int N = int.Parse(Console.ReadLine());
            for (int i = z; N > 0; N--)
            {
                Console.Write(i + " ");
            }
        }
    }
}