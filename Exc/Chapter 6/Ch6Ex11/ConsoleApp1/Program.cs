using System;

class Program
{
    static void Write()
    {
        string myString = "Stgring defined in Write()";
        Console.WriteLine("new test");
        Console.WriteLine($"myString = {myString}");
    }

    static void Main(string[] args)
    {
        string myString = "String defined in Main()";
        Write();
        Console.ReadKey();
    }
}