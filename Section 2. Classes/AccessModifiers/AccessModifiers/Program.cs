namespace AccessModifiers;

public class Person
{
    private DateTime _birthDate;

    public DateTime GetBirthDate()
    {
        return _birthDate;
    }
    
    public void SetBirthDate(DateTime birthDate)
    {
        _birthDate = birthDate;
    }



}
public class Program
{
    static void Main()
    {
        Person person = new();
        person.SetBirthDate(new DateTime(1982, 1, 1));
        Console.WriteLine(person.GetBirthDate());
    }
}