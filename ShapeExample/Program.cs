namespace ShapeExample;
using System;
using System.IO;

class Program
{ 
    static void Main(string[] args)
    {
        var square = Shape.Create("square", 2, 2);
        Console.WriteLine($"The area of a square is {square.Area()}. The length is {square.length} and the width is {square.width}.");
        var rectangle = Shape.Create("rectangle", 2, 3);
        Console.WriteLine($"The area of a rectangle is {rectangle.Area()}. The length is {rectangle.length} and the width is {rectangle.width}.");
        var notASquare = Shape.Create("square", 2, 3);

    }
}
