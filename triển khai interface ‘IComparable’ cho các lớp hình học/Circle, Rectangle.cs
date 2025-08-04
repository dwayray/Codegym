public class Circle : Shape, IComparable<Circle>
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    public int CompareTo(Circle other)
    {
        if (other == null) return 1;
        return GetArea().CompareTo(other.GetArea());
    }

    public override string ToString()
    {
        return $"Circle: Radius = {Radius}, {base.ToString()}";
    }
}

public class Rectangle : Shape, IComparable<Rectangle>
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double GetArea()
    {
        return Width * Height;
    }

    public int CompareTo(Rectangle other)
    {
        if (other == null) return 1;
        return GetArea().CompareTo(other.GetArea());
    }

    public override string ToString()
    {
        return $"Rectangle: {Width} x {Height}, {base.ToString()}";
    }
}
