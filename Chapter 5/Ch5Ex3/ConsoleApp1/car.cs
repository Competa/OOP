public class Car

{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Fuel {get; set; }

    public Car(string make, string model, int year, string fuel)
    {
        Make = make;
        Model = model;
        Year = year;
        Fuel = fuel;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Car: {Year} {Make} {Model} {Fuel}");
    }
}
