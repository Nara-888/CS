using System;

namespace _05._Account_Balance
{
    internal class accountBalance
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            double accountBalance = 0;

            while ((command = Console.ReadLine()) != "NoMoreMoney") 
            {
                double currentTransaction = double.Parse(command);
                if (currentTransaction < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Increase: {currentTransaction}");
                    accountBalance += currentTransaction;
                }
            }
            Console.WriteLine($"Total: {accountBalance:f2}");
        }
    }
}
