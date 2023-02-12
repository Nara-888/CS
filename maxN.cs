using System;

namespace _06._Max_Number
{
    internal class maxN
    {
        static void Main(string[] args)
        {
            int maxNum = int.MinValue;

            string command = string.Empty;

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
                    if (currentNum > maxNum) { maxNum= currentNum; }
                    
                }
            }
            Console.WriteLine(maxNum);
        }
    }
}
