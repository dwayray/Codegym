using System;
using Geometry;

class Program
{
    static void Main(string[] args)
    {
        object[] shapes = new object[]
        {
            new Circle(5),
            new Rectangle(4, 6),
            new Square(3)
        };

        Console.WriteLine("Thong tin:\n");

        foreach (var shape in shapes)
        {
            double area = 0;

            if (shape is Circle c)
            {
                Console.WriteLine(c);
                area = c.GetArea();
            }
            else if (shape is Rectangle r)
            {
                Console.WriteLine(r);
                area = r.GetArea();
            }
            else if (shape is Square s)
            {
                Console.WriteLine(s);
                area = s.GetArea();
            }

            Console.WriteLine($"Area: {area:F2}");

            if (shape is IColorable colorable)
            {
                Console.Write("How to color: ");
                colorable.HowToColor();
            }

            Console.WriteLine();
        }
    }
}
