using System.Security.Cryptography.X509Certificates;

namespace IntroToClassesApp;

public class Program
{
    public class Person
    {
        public string? Name;
        public void Introduce(string to)
        {
            Console.WriteLine($"Hi, {Name}, I am {to}!");
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }

    }
    
    static void Main()
    {
        var person = Person.Parse("Mosh");
        person.Introduce("Luke");

    }
    
}