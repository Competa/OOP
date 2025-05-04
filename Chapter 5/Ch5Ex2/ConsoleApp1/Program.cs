namespace ConsoleApp1
{
    enum Orientation : byte
    {
        North = 1,
        East = 2,
        South = 3,
        West = 4
    }

    class Program
    {
        static void Main(string[] args)
        {
            byte directionByte;
            string directionString;
            Orientation myDirection = Orientation.North;
            Console.WriteLine($"myDirection = {myDirection}");
            directionByte = (byte)myDirection;
            directionString = Convert.ToString(myDirection);
            Console.WriteLine($"byte equivalent = {directionByte}");
            Console.WriteLine($"string equivalent = {directionString}");
            Console.ReadKey();
        }
    }
}

// The above code defines an enumeration called `Orientation` with four values: North, East, South, and West.
// The `Main` method creates a variable of type `Orientation`, assigns it the value `North`, and then converts it to both a byte and a string.
// The byte equivalent is printed as 1, and the string equivalent is printed as "North".
// The program demonstrates how to work with enumerations in C# and how to convert them to different types.
// The output of the program will be:
// myDirection = North
// byte equivalent = 1
// string equivalent = North
// The program waits for a key press before closing, allowing the user to see the output.
// The `Orientation` enum is defined with an underlying type of byte, which means each value will be stored as a byte.
// The `Main` method is the entry point of the program, where execution begins.
// The `Console.WriteLine` method is used to print messages to the console.