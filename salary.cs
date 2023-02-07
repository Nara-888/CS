using System;
using System.Net.WebSockets;

namespace _05._Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int openTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 0; i < openTabs; i++)
            {
                string currentTab = Console.ReadLine();
                if (currentTab == "Facebook")
                {
                    salary -= 250;
                }
                else if ( currentTab == "Instagram")
                {
                    salary -= 110;
                }
                else if (currentTab == "Reddit")
                {
                    salary -= 50;
                }


                if (salary <=0 )
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }

            if (salary > 0)
            {
                Console.WriteLine(salary); 
            }
        }
    }
}
