using System;

namespace _04._Sequence_2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int c = 1;

            while (c <= n)
            {
                Console.WriteLine(c);
                c = c * 2 + 1;
            }

        }
    }
}
