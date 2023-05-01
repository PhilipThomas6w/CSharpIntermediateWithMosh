namespace Properties;

public class Person
{
    public Person(DateTime birthDate)
    {
        BirthDate = birthDate;  // sets BirthDate to the value of birthDate when the constructor is called
    }
    
    public DateTime BirthDate { get; private set; } // the private set is redundant i.e., is not required because it is set by the constructor

    public int Age
    {
        get
        {
            var timeSpan = DateTime.Today - BirthDate;
            var years = timeSpan.Days / 365;
            return years;
        }
    }
}
