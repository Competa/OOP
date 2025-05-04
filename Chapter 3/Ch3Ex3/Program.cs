using System;
namespace ConsoleApp1
{
    class Program
    {
    static void Main(string[] args)
        {
        int firstNumber, secondNumber, thirdNumber, fourthNumber, finalNumber;
        Console.WriteLine("Enter the first number:");
        firstNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        secondNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the third number:");
        thirdNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the fourth number:");
        fourthNumber = Convert.ToInt32(Console.ReadLine());
        finalNumber = firstNumber * secondNumber * thirdNumber * fourthNumber;
        Console.WriteLine($"The final number is {finalNumber}.");
        }
  
    }
}
