using System;

namespace Shape
{
    public class Circle
    {
        private double radius;
        private string color;
        private bool filled;

        public Circle()
        {
            radius = 1.0;
            color = "red";
            filled = true;
        }

        public Circle(double radius)
        {
            this.radius = radius;
            color = "red";
            filled = true;
        }

        public Circle(double radius, string color, bool filled)
        {
            this.radius = radius;
            this.color = color;
            this.filled = filled;
        }

        public double getRadius()
        {
            return radius;
        }

        public void setRadius(double radius)
        {
            this.radius = radius;
        }

        public double getArea()
        {
            return Math.PI * radius * radius;
        }

        public override string ToString()
        {
            return $"Circle(radius={radius}, color={color}, filled={filled}, area={getArea():F2})";
        }
    }
}
