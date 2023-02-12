using System;

namespace _08._Graduation
{
    internal class graduation
    {
        static void Main(string[] args)
        {
            int gradeCounter = 0;
            double sumOfGrades = 0;
            
            string name = Console.ReadLine();

            int failsCount = 0;
            bool graduated = true;

            while (gradeCounter <12)
            {
                double currenGrade = double.Parse(Console.ReadLine());
                if (currenGrade < 4)
                {
                    failsCount++;
                    sumOfGrades+= currenGrade;
                    if (failsCount > 1)
                    {
                        graduated = false;
                        Console.WriteLine($"{name} has been excluded at {gradeCounter+1} grade");
                            
                             break;
                    }
                }
                else
                {
                    sumOfGrades += currenGrade;
                    gradeCounter++;
                }
            }
            double averageScore = sumOfGrades / gradeCounter;

            if (graduated)
            {
                Console.WriteLine($"{name} graduated. Average grade: {averageScore:f2}");
            }
            

            
        }
    }
}
