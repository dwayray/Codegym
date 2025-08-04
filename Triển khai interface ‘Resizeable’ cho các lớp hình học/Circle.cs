using System;

namespace Geometry
{
    public class Circle : Resizeable
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public void Resize(double percent)
        {
            Radius += Radius * percent / 100;
        }

        public override string ToString()
        {
            return $"Circle (radius = {Radius:F2})";
        }
    }
}
