namespace Constructors;

public class Vehicle
{
    private readonly string _regNum;

    //public Vehicle()
    //{
    //    Console.WriteLine("Vehicle is being initialized.");
    //}

    public Vehicle(string regNum)
    {
        _regNum = regNum;

        Console.WriteLine($"Vehicle is being initialized. {regNum}");
    }
}