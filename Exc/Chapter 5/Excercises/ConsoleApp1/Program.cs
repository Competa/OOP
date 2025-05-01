class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a String: ");
        string input = Console.ReadLine();

        string reversed = ReverseString(input);
        Console.WriteLine($"Reversed string: {reversed}");

        Console.ReadKey();
    }

    static string ReverseString(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
