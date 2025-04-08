using System;

class Program
{
    enum Orientation : byte
    {
        North = 1,
        East = 2,
        South = 3,
        West = 4
    }

    struct Route
    {
        public Orientation Direction;
        public double Distance;
    }

    static void Main(string[] args)
    {
        Route myRoute;
        int myDirection = -1;
        double myDistance;

        Console.WriteLine("1) North\n2) East\n3) South\n4) West");
        do
        {
            Console.WriteLine("Select a direction:");
            myDirection = Convert.ToInt32(Console.ReadLine());
        } while (myDirection < 1 || myDirection > 4);

        Console.WriteLine("Input a distance:");
        myDistance = Convert.ToDouble(Console.ReadLine());

        myRoute.Direction = (Orientation)myDirection;
        myRoute.Distance = myDistance;

        Console.WriteLine($"myRoute specifies a direction of {myRoute.Direction} and a distance of {myRoute.Distance}"2);
        Console.ReadKey();
    }
}