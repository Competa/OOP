class Program
{
    static void Main(string[] args)
    {
        int var1, var2;
        Console.WriteLine("Lets play a game. Enter 2 numbers, where an instance of both numbers being above 10 is prohibited. Enter a number:");
        var1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter another number:");
        var2 = Convert.ToInt32(Console.ReadLine());
        
        do
        {
            if (var1 > 10 && var2 > 10)
            {
                Console.WriteLine("Both numbers are above 10... Fail");
                break;
            }
            else if (var1 < 10 && var2 < 10)
            {
                Console.WriteLine("Both numbers are below 10... Success");
            }
            else
            {
                Console.WriteLine("One number is above 10 and the other is below 10... Success");
            }
            Console.WriteLine("The first number is: " + var1 + " and the second number is: " + var2); ;
        } while (var1 < 10 && var2 < 10);        

    }
}