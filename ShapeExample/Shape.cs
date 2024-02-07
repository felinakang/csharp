namespace ShapeExample;
using System;

public abstract class Shape
{
    public int length { get; set; }
    public int width { get; set; }
    public abstract int Area();

    public static Shape Create(string kind, int length, int width)
    {
        switch (kind)
        {
            case "square":
                Square square = new Square();
                square.length = length;
                square.width = width;
                return square;
            case "rectangle":
                Rectangle rectangle = new Rectangle();
                rectangle.length = length;
                rectangle.width = width;
                return rectangle;
            default:
                Console.WriteLine($"{kind} shape is not supported.");
                return null;
        }
    }
}


public class Rectangle: Shape
{
    public override int Area()
    {
        return length * width;
    }
}
public class Square: Rectangle
{
        public override int Area()
        {
            Console.WriteLine("I'm a square!");
            return base.Area();
        }
    }