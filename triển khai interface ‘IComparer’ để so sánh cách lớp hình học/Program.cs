using System;
using System.Collections.Generic;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle[] circles = new Circle[3];
            circles[0] = new Circle(3.6);
            circles[1] = new Circle();
            circles[2] = new Circle(3.5, "indigo", false);

            Console.WriteLine("Pre-sorted:");
            foreach (Circle circle in circles)
            {
                Console.WriteLine(circle);
            }

            IComparer<Circle> circleComparator = new CircleComparator();
            Array.Sort(circles, circleComparator);

            Console.WriteLine("\nAfter-sorted:");
            foreach (Circle circle in circles)
            {
                Console.WriteLine(circle);
            }
        }
    }
}
