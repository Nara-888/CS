using System;
using System.Threading;

namespace _07._Min_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minNum = int.MaxValue;

            string command = "";

            while (command != "Stop")
            {
                command= Console.ReadLine();
                if (command == "Stop")
                {
                    break;
                }
                else
                {
                    int currentNum = int.Parse(command);
                    if (currentNum < minNum) { minNum= currentNum; }
                }
            }
            Console.WriteLine(minNum);
        }
    }
}
