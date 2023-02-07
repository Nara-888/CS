using System;

namespace _02._Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int maxNum = int.MinValue;

            for (int i = 1; i <= n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                sum += currentNum;
                if (currentNum > maxNum)
                {
                    maxNum = currentNum;
                }
                
            }
            int maxNumberSubtractedFromSum = sum - maxNum;

            if (maxNumberSubtractedFromSum == maxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = "+maxNumberSubtractedFromSum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(maxNumberSubtractedFromSum -maxNum));
            }
        }
    }
}
