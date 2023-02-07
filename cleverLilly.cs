using System;

namespace _04._Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceWashingMachine = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int toysCounter = 0;
            int savedMoney = 0;
            int moneyTakenByLillysBrother = 0;
            int moneyAdded = 10;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 != 0)
                {
                    toysCounter++;
                }
                else
                {
                    
                    savedMoney += moneyAdded;
                    moneyAdded += 10;
                    moneyTakenByLillysBrother++;
                }
            }

            int finalAmountSaved = savedMoney + toysCounter * toyPrice - moneyTakenByLillysBrother;

            if (finalAmountSaved >= priceWashingMachine)
            {
                Console.WriteLine($"Yes! {(double)finalAmountSaved -priceWashingMachine:F2}");
            }
            else
            {
                Console.WriteLine($"No! {priceWashingMachine - (double)finalAmountSaved:F2}");
            }
        }
    }
}
