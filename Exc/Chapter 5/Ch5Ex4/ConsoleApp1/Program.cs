static void Main(string[] args)
{
string [] friendNames = {"Todd Anthony","John Doe","Jane Smith","Mary Johnson","James Brown"};
int i;
Console.WriteLine($"Here are {friendNames.Length} of my friends:");
for (i = 0; i < friendNames.Length; i++)
{
    Console.WriteLine(friendNames[i]);
}
Console.ReadKey();
}

