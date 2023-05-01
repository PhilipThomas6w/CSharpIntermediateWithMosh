namespace Constructors;

public class Car : Vehicle
{
    public Car(string regNum)
        : base(regNum)
    {
        Console.WriteLine($"Car is being initialized. {regNum}");
    }
}