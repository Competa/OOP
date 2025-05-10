partial class Program
{
    public static void EnjoyDrink(object cup)
    {
        if (cup is HotDrink drink && cup is ICup washable)
        {
            drink.AddMilk();
            drink.Drink();
            washable.Wash();
        }
        else
        {
            throw new ArgumentException("Object must be a HotDrink and implement ICup.");
        }
    }

    static void Main(string[] args)
    {
        // Example usage
        var myCup = new MyHotDrinkCup();
        EnjoyDrink(myCup);
    }
}

interface ICup
{
    void Wash();
}

class HotDrink
{
    public void AddMilk() { /* Implementation */ }
    public void Drink() { /* Implementation */ }
}

class MyHotDrinkCup : HotDrink, ICup
{
    public void Wash() { /* Implementation */ }
}