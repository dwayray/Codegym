using System;

class Program
{
    static void Main()
    {
        Circle[] circles = {
            new Circle(2.0),
            new Circle(1.5),
            new Circle(3.0)
        };

        Console.WriteLine("Before sorting circles:");
        foreach (var c in circles)
        {
            Console.WriteLine(c);
        }

        Array.Sort(circles);

        Console.WriteLine("\nAfter sorting circles:");
        foreach (var c in circles)
        {
            Console.WriteLine(c);
        }

        Rectangle[] rectangles = {
            new Rectangle(3, 4),
            new Rectangle(2, 2),
            new Rectangle(5, 1)
        };

        Console.WriteLine("\nBefore sorting rectangles:");
        foreach (var r in rectangles)
        {
            Console.WriteLine(r);
        }

        Array.Sort(rectangles);

        Console.WriteLine("\nAfter sorting rectangles:");
        foreach (var r in rectangles)
        {
            Console.WriteLine(r);
        }
    }
}
