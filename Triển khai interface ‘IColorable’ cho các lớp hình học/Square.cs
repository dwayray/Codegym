using System;

namespace Geometry
{
    public class Square : IColorable
    {
        public double Side { get; set; }

        public Square(double side)
        {
            Side = side;
        }

        public double GetArea()
        {
            return Side * Side;
        }

        public void HowToColor()
        {
            Console.WriteLine("Color all four sides.");
        }

        public override string ToString()
        {
            return $"Square (side = {Side:F2})";
        }
    }
}
