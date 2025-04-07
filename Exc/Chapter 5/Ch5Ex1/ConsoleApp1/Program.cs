class Program
{
    static void Main(string[] args)
    {
        short shortResult, shortVal = 4;
        int integerVal = 67;
        long longResult;
        float floatVal = 10.5F;
        double doubleResult, doubleVal = 99.999;
        string stringResult, stringVal = "17";
        
        bool boolResult, boolVal = true;
        Console.WriteLine("Variable Conversion Examples\n");
        doubleResult = floatVal * shortVal;
        Console.WriteLine($"Implicit, -> double: {floatVal} * {shortVal} -> {doubleResult}");
        shortResult = (short)floatVal;
        Console.WriteLine($"Explicit, -> short: {floatVal} -> {shortResult}");
        stringResult = Convert.ToString(doubleVal);
        Console.WriteLine($"Explicit, -> string: \"{boolVal}\" + \"{doubleVal}\" -> " + $"{stringResult}");
        longResult = integerVal + Convert.ToInt64(stringVal);
        Console.WriteLine($"Mixed, -> long: {integerVal} + {stringVal} -> {longResult}");
        Console.ReadKey();
    }
}

// The code above demonstrates various types of variable conversions in C#.
// It includes implicit conversion from float to double, explicit conversion from float to short,
// explicit conversion from double to string, and mixed conversion from int to long.
// The program uses the Console class to output the results of these conversions to the console.
// The use of Convert.ToString and Convert.ToInt64 methods allows for safe conversion between types.
// The program also includes a boolean variable to demonstrate that not all types are converted.
// The use of Console.ReadKey() at the end allows the user to see the output before the console window closes.
// The program is structured with a Main method inside a Program class, which is the entry point of the application.
// The code is well-organized and easy to read, making it a good example of variable conversion in C#.