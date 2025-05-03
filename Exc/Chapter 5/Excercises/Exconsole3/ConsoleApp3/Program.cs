using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Give me a sentence, and I will identify each word: ");
        string input = Console.ReadLine() ?? string.Empty; // Handle possible null input

        string[] words = SplitWords(input);

        Console.WriteLine("Here is the list of the words:");
        for (int i = 0; i < words.Length; i++)
        {
            Console.WriteLine(words[i]); // Print each word
        }

        Console.ReadKey();
    }

    static string[] SplitWords(string sentence)
    {
        return sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries); // Split and remove empty entries
    }
}
