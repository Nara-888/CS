using System;

namespace _03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int initialNum = int.Parse(Console.ReadLine());

            int sum = 0;

            while (sum <= initialNum)
            {
                int currentNum = int.Parse(Console.ReadLine());
                sum += currentNum;
                if (sum == initialNum)
                {
                    break;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
