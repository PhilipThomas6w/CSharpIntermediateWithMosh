using System.Reflection.Metadata;

namespace AbstractClasses;

public class Program
{
    static void Main()
    {
        //var shape = new Shape();  // Cannot create an instance of the abstract class 'AbstractClasses.Shape'
        
        
        
        var circle = new Circle();
        circle.Draw();

        var rectangle = new Rectangle();
        rectangle.Draw();


    }
}