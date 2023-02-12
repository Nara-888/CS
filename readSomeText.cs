using System;

namespace _01._Read_Text
{
    internal class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Stop") { break; }
                Console.WriteLine(command);

            }
        }
    }
}
