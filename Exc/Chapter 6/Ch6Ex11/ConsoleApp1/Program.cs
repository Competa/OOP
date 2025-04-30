using System;

class Program
{
    static void Write()
    {
        string myString = "Stgring defined in Write()";
        Console.WriteLine("Now in Write()");
        Console.WriteLine($"myString = {myString}");
    }

    static void Main(string[] args)
    {
        string myString = "String defined in Main()";
        Write();
        Console.ReadKey();
    }
}