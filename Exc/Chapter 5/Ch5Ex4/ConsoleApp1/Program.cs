using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friendNames = { "Todd Anthony", "John Doe", "Jane Smith", "Mary Johnson", "James Brown" };
            Console.WriteLine($"Here are {friendNames.Length} of my friends:");
            for (int i = 0; i < friendNames.Length; i++)
            {
                Console.WriteLine(friendNames[i]);
            }
            Console.ReadKey();
            
        }
    }
}