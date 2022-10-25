namespace Практическая_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var table = new int[11, 11];
            for (int b = 1; b < 11; ++b)
            {
                for (int a = 1; a < 11; ++a)
                {
                    table[b, a] = b * a;
                }
            }
            for (int b = 1; b < 11; ++b)
            {
                for (int a = 1; a < 11; ++a)
                {
                    Console.Write("{0, 3}", table[b, a]);
                }
                Console.WriteLine();
            }
        }
    }
}