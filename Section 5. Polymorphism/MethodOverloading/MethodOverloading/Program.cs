﻿namespace MethodOverloading;

public class Program
{
    static void Main()
    {
        var shapes = new List<Shape>();

        shapes.Add(new Circle());
        shapes.Add(new Rectangle());
        shapes.Add(new Triangle());

        var canvas = new Canvas();
        canvas.DrawShapes(shapes);




    }
}