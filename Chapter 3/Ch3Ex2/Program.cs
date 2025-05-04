using System;

class Program
{
    static void Main(string[] args)
    {
        double firstNumber, secondNumber;
        string? userName;

        //The below coe asks the user for a name, then reads the input.
        Console.WriteLine("Enter your name:"); 
        userName = Console.ReadLine();

        //Here, if the string userName, is null or empty, the program will stop and exit.
        if (string.IsNullOrEmpty(userName))
        {
            Console.WriteLine("Name cannot be empty. Exiting program.");
            return;
        }
        //The below code will print the name of the user.
        //The $ sign before the string allows us to use the variable userName inside the string.
        Console.WriteLine($"Welcome {userName}!");
        //The below code will ask the user for two numbers, then read the input.
        //The first number will be stored in the variable firstNumber, and the second number will be stored in the variable secondNumber.
        Console.WriteLine("Now give me a number:");
        if (!double.TryParse(Console.ReadLine(), out firstNumber))
        {
            Console.WriteLine("Invalid input for the first number. Exiting program.");
            return;
        }
        //The below code will ask the user for a second number, then read the input.
        //The second number will be stored in the variable secondNumber.
        //The first number will be stored in the variable firstNumber, and the second number will be stored in the variable secondNumber.
        Console.WriteLine("Now give me another number:");
        if (!double.TryParse(Console.ReadLine(), out secondNumber))
        {
            Console.WriteLine("Invalid input for the second number. Exiting program.");
            return;
        }
        //The below code will print the result of the operations on the two numbers.
        Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is {firstNumber + secondNumber}.");
        Console.WriteLine($"The result of subtracting {secondNumber} from {firstNumber} is {firstNumber - secondNumber}.");
        Console.WriteLine($"The product of {firstNumber} and {secondNumber} is {firstNumber * secondNumber}.");
        Console.WriteLine($"The result of dividing {firstNumber} by {secondNumber} is {firstNumber / secondNumber}.");
        Console.WriteLine($"The remainder after dividing {firstNumber} by {secondNumber} is {firstNumber % secondNumber}.");
        //The below code will print the result of the operations on the two numbers.
        Console.ReadKey();
    }
}
