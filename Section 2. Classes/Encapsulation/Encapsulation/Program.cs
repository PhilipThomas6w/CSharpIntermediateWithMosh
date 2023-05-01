namespace Encapsulation;

public class Program
{
    public class Person
    {
        private string Name;                        // private field used to store data

        public void SetName(string name)            // setter
        {
            if (!string.IsNullOrEmpty(name))
            {
                this.Name = name;
            }
        }

        public string GetName()                     // getter
        {
            return Name;
        }
    }


    static void Main()
    {
        throw new NotImplementedException();
    }
}