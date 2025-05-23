﻿//Below we import the Car class from the car.cs file
using System;
using System.Reflection.Metadata.Ecma335;

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
        Car newCar = new Car("Toyota", "Corolla", 2020, "Gas");
        newCar.DisplayInfo();
        
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

        Console.WriteLine($"myRoute specifies a direction of {myRoute.Direction} and a distance of {myRoute.Distance}");
        Console.ReadKey();
    }
}


