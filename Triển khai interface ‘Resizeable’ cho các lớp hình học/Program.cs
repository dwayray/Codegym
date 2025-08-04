using System;
using Geometry;

class Program
{
    static void Main(string[] args)
    {
        Resizeable[] shapes = new Resizeable[]
        {
            new Circle(5),
            new Rectangle(4, 6),
            new Square(3)
        };

        Random rand = new Random();

        Console.WriteLine("Thay doi kich thuoc hinh dang va phan tram ngau nhien:\n");

        foreach (var shape in shapes)
        {
            double percent = rand.Next(1, 101);
            double areaBefore = GetArea(shape);

            shape.Resize(percent);

            double areaAfter = GetArea(shape);

            Console.WriteLine(shape);
            Console.WriteLine($"Resized by: {percent}%");
            Console.WriteLine($"Area before: {areaBefore:F2}");
            Console.WriteLine($"Area after:  {areaAfter:F2}\n");
        }
    }

    static double GetArea(Resizeable shape)
    {
        if (shape is Circle c)
            return c.GetArea();
        else if (shape is Rectangle r)
            return r.GetArea();
        else if (shape is Square s)
            return s.GetArea();
        else
            return 0;
    }
}
