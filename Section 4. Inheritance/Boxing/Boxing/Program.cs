using System.Collections;

namespace Boxing;

public class Program
{
    static void Main()
    {
        #region Boxing

        //var list = new ArrayList();
        //list.Add(1); // boxing will occur because arg is a value type
        //list.Add("a string");  // invalid cast because arg is a reference type
        //list.Add(DateTime.Today);  // boxing will occur because arg is a value type
        //var number = (int)list[1];

        #endregion

        // To avoid boxing, use a generic type list if one is available e.g., List<int>, List<string>, List<myObject>

        var anotherList = new List<int>();
        anotherList.Add(2);

        foreach (var num in anotherList)
        {
            Console.WriteLine(num);
        }

        var names = new List<string>();
        names.Add("a string");
        foreach (var letter in names)
        {
            Console.WriteLine(letter);
        }
    }
}