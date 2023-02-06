using System;

namespace _02._Summer_Outfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int grade = int.Parse(Console.ReadLine());
            string partOfDay = Console.ReadLine();

            string outfit = "";
            string shoes = "";

            switch (partOfDay)
            {

                case "Morning":
                    if (grade >= 10 &&  grade <= 18)
                    {
                        outfit = "Sweatshirt";
                        shoes = "Sneakers";
                    }
                    else if (grade > 18 && grade <= 24 )
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    break;
                case "Afternoon":
                    if (grade >= 10 && grade <= 18)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (grade > 18 && grade <= 24)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    else
                    {
                        outfit = "Swim Suit";
                        shoes = "Barefoot";
                    }
                    break;
                case "Evening":
                    if (grade >= 10 && grade <= 18)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (grade > 18 && grade <= 24)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    break;











            }


            Console.WriteLine($"It's {grade} degrees, get your {outfit} and {shoes}.");
        }
    }
}
