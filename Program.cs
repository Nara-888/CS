using System;

namespace _08._On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMins = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivelMins = int.Parse(Console.ReadLine());

            int examTimeInMins = examHour * 60 + examMins;
            int arrivalTimeInMins = arrivalHour * 60 + arrivelMins;

            int difference = examTimeInMins- arrivalTimeInMins;

            int differenceHours = Math.Abs(difference / 60);
            int differenceMins = Math.Abs(difference % 60);

            if (difference == 0)
            {
                Console.WriteLine("On time");
            }
            else if (difference > 0)
            {
                // on time OR much earlier
                //On time
                //30 minutes before the start
                if (difference <= 30)
                {
                    // on time
                    Console.WriteLine("On time");
                    Console.WriteLine($"{differenceMins} minutes before the start");

                }
                else
                {
                    if (differenceHours <= 0)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{differenceMins} minutes before the start");
                    }
                    else
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{differenceHours}:{differenceMins:d2} hours before the start");
                    }
                    
                }
            }
            else if (difference < 0)
            {
                Console.WriteLine("Late");
                if (differenceHours <= 0)
                {
                    Console.WriteLine($"{differenceMins} minutes after the start");
                }
                else
                {
                    Console.WriteLine($"{differenceHours}:{differenceMins:d2} hours after the start");
                }
                
            }

        }
    }
}
