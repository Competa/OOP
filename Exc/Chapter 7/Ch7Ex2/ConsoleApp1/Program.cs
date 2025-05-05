using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input age and gender to complete the sentence: ");
        Console.WriteLine("Hi, I am [X] years old and I identify as [Y]!");
        string age = Console.ReadLine();
        string gender=Console.ReadLine();

        Console.WriteLine($"Hi, I am {age} years old and I identify as {gender}");
    }
}