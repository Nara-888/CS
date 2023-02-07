using System;

namespace _03._Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counterP1 = 0;
            int counterP2 = 0;
            int counterP3 = 0;
            int counterP4 = 0;
            int counterP5 = 0;

            

            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (currentNum < 200)
                {
                    counterP1++;

                }
                else if (currentNum >= 200 && currentNum < 400)
                {
                    counterP2++;
                }
                else if (currentNum >= 400 && currentNum < 600)
                {
                    counterP3++;
                }
                else if (currentNum >= 600 && currentNum < 800)
                {
                    counterP4++;
                }
                else if (currentNum >= 800)
                {
                    counterP5++;
                }
            }

            double p1 = (double)counterP1/(double)n * 100;
            double p2 = (double)counterP2 / (double)n * 100;
            double p3 = (double)counterP3 / (double)n * 100;
            double p4 = (double)counterP4 / (double)n * 100;
            double p5 = (double)counterP5 / (double)n * 100;

            Console.WriteLine($"{p1:F2}%");
            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");
            Console.WriteLine($"{p4:F2}%");
            Console.WriteLine($"{p5:F2}%");
          
        }
    }
}
