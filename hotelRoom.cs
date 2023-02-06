using System;

namespace _07._Hotel_Room
{
    internal class hotelRoom
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numberOfNights = int.Parse(Console.ReadLine());

            double priceStudio = 0;
            double priceApartment = 0;

            switch (month)
            {
                case "May":
                case "October":

                    if (numberOfNights > 7 && numberOfNights <= 14)
                    {
                        priceApartment = numberOfNights * 65;
                        priceStudio = (numberOfNights * 50) * 0.95;
                    }
                    else if (numberOfNights > 14)
                    {
                        priceApartment = (numberOfNights * 65) * 0.90;
                        priceStudio = (numberOfNights * 50) * 0.70;
                    }
                    else
                    {
                        priceApartment = numberOfNights * 65;
                        priceStudio = numberOfNights * 50;
                    }
                    break;

                case "June":
                case "September":
                    if (numberOfNights > 14)
                    {
                        priceApartment = (numberOfNights * 68.70) * 0.90;
                        priceStudio = (numberOfNights * 75.20) * 0.80;
                    }
                    else
                    {
                        priceApartment = numberOfNights * 68.70;
                        priceStudio = numberOfNights * 75.20;
                    }
                    break;
                case "July":
                case "August":
                    if (numberOfNights > 14)
                    {
                        priceApartment = (numberOfNights * 77) * 0.90;
                        
                    }
                    else
                    {
                        priceApartment = numberOfNights * 77;
                        
                        
                    }
                    priceStudio = numberOfNights * 76;
                    break;
            }


            Console.WriteLine($"Apartment: {priceApartment:F2} lv.");
            Console.WriteLine($"Studio: {priceStudio:F2} lv.");


            //OUTPUT 	•	На първия ред: “Apartment: {цена за целият престой} lv.
            //”На втория ред: “Studio: { цена за целият престой}
            //lv.“


        }
    }
}
