using System;

class Program
{
    static void Main(string[] args)
    {
        double balance, interestRate, targetBalance;
        Console.WriteLine("What is your currrent balance?");
        balance = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("What is your current annual interest rate? (in %)");
        interestRate = 1 + Convert.ToDouble(Console.ReadLine()) / 100.0;
        Console.WriteLine("What is your target balance?");
        targetBalance = Convert.ToDouble(Console.ReadLine());
        int totalYears = 0;
        do
        {
            balance *= interestRate;
            ++totalYears;
        }
        while (balance < targetBalance);
        Console.WriteLine($"It will take {totalYears} years to reach your target balance of {targetBalance}");
        Console.ReadKey();
    }
}