using System;

class Program
{
    static int SumVals (params int[] vals)
    {
        int sum = 0;
        foreach (int val in vals)
        {
            sum +=val;
        }
        return sum;
    }

    static void Main(string[] args)
    {
        int sum = SumVals (1,5,2,9,8,12,40);
        Console.WriteLine($"Summed Values = {sum}");
        Console.ReadKey();
    }
}