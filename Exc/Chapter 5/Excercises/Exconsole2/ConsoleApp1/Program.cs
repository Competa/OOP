class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write me a sentence, whith a lot of negatives 'NO': ");
        string input = Console.ReadLine();

        string output = input.Replace("No", "Yes");
        Console.WriteLine($"Here is the modified sentence: {output}");
        Console.ReadKey();        
    }
}
