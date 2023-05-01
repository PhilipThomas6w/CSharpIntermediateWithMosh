namespace MethodsApp;

public class Program
{
    static void Main()
    {
        
    }

    static void Parsing()
    {
        try
        {
            var number1 = int.Parse("abc");
        }
        catch (Exception)
        {
            Console.WriteLine("Conversion failed.");
        }

        int number2;
        var result = int.TryParse("abc", out number2); // if the input can be parsed, will return true and send the value to number
        if (result) Console.WriteLine(number2);
        else Console.WriteLine("Conversion failed.");
    }

    static void UseParams()
    {
        Calculator calculator = new();
        Console.WriteLine(calculator.Add(1, 2));
        Console.WriteLine(calculator.Add(1, 2, 3));
        Console.WriteLine(calculator.Add(1, 2, 3, 4));
        Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4 }));
    }

    static void UsePoints()
    {
        try
        {
            var point = new Point(10, 20);
            point.Move(new Point(40, 60));
            Console.WriteLine($"Point is at ({point.X}, {point.Y})");

            point.Move(100, 200);
            Console.WriteLine($"Point is at ({point.X}, {point.Y})");

            point.Move(null);
            Console.WriteLine($"Point is at ({point.X}, {point.Y})");
        }
        catch (Exception)
        {

            Console.WriteLine("An unexpected error occurred.");
        }
    }

}