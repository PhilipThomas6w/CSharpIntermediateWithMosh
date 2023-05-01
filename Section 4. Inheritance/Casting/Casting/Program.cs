using System.Collections;

namespace Casting;

public class Program
{
    static void Main()
    {
        #region UpCasting

        //Text text = new Text();
        //Shape shape = text;

        //text.Width = 200;
        //shape.Width = 100;

        //Console.WriteLine(text.Width);

        //StreamReader reader = new StreamReader(new MemoryStream());

        //var list = new ArrayList();
        //list.Add(1);
        //list.Add("Luke");
        //list.Add(new Text());

        //var anotherList = new List<Shape>();

        #endregion

        Shape shape = new Text();

        Text text = (Text)shape;    // downcast

    }
}