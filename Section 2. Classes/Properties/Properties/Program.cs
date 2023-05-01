namespace Properties;
public class Program
{
    static void Main()
    {
        var person = new Person(new DateTime(1980, 3, 26)); // passes in the birthDate to the Person constructor
        Console.WriteLine($"Luke is {person.Age} years old.");        
    }
}