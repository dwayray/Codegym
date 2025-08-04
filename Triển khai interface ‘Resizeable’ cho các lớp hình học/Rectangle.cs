using System;

namespace Geometry
{
    public class Rectangle : Resizeable
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double GetArea()
        {
            return Width * Height;
        }

        public void Resize(double percent)
        {
            Width += Width * percent / 100;
            Height += Height * percent / 100;
        }

        public override string ToString()
        {
            return $"Rectangle (width = {Width:F2}, height = {Height:F2})";
        }
    }
}
