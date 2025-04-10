static void Main(string[] args)
{
    string[] friendNames = { "Todd Anthony", "John Doe", "Jane Smith", "Mary Johnson", "James Brown" };
    foreach (var friendNames in friendNames)
    {
        switch (friendNames)
        {
            case string t when t.StartsWith("T"):
                Console.WriteLine($"{friendNames} starts with a 'T': "+ $""
        }
    }
}