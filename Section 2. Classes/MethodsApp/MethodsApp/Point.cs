namespace MethodsApp;

public class Point
{
    public int X;   // fields
    public int Y;

    public Point(int x, int y)  // constructor
    {
        this.X = x;
        this.Y = y;
    }

    public void Move(int x, int y)  // method
    {
        this.X = x;
        this.Y = y;
    }

    //public void Move(Point newLocation) // method overload
    //{
    //    this.X = newLocation.X;
    //    this.Y = newLocation.Y;
    //}

    // replace ^^ with 

    public void Move(Point newLocation) // method overload
    {
        
        // defensive programming
        if (newLocation == null)
        {
            throw new ArgumentNullException("newLocation");
        }
        
        Move(newLocation.X, newLocation.Y);
    }
}