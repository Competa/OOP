using System;

class Program
{
    static void Main(string[] args)
    {
        const string myName = "benjamin";
        const string niceName = "andrea";
        const string sillyName = "ploppy";
        Console.WriteLine("What is your name?");
        string? name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("You didn't enter a valid name.");
        }
        else
        {
            switch (name.ToLower())
            {
                case myName:
                    Console.WriteLine("You have the same name as me!");
                    break;
                case niceName:
                    Console.WriteLine("You have a nice name!");
                    break;
                case sillyName:
                    Console.WriteLine("You have a silly name!");
                    break;
                default:
                    Console.WriteLine($"Hello {name}!");
                    break;
            }
        }
        Console.ReadKey();
    }
}