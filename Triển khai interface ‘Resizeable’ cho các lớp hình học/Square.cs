using System;

namespace Geometry
{
    public class Square : Resizeable
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

        public void Resize(double percent)
        {
            Side += Side * percent / 100;
        }

        public override string ToString()
        {
            return $"Square (side = {Side:F2})";
        }
    }
}
