namespace Indexers;

public class Program
{
    static void Main()
    {
        var cookie = new HttpCookie
        {
            ["name"] = "Luke"
        };
        Console.WriteLine(cookie["name"]);  // prints "Luke"
    }
}