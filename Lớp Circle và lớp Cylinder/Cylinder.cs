public class Cylinder : Circle
{
    private double height;

    public Cylinder() : base()
    {
        height = 1.0;
    }

    public Cylinder(double radius, string color, double height) : base(radius, color)
    {
        this.height = height;
    }

    public double GetHeight()
    {
        return height;
    }

    public void SetHeight(double height)
    {
        this.height = height;
    }

    public double GetVolume()
    {
        return GetArea() * height;
    }

    public override string ToString()
    {
        return $"Cylinder[radius={GetRadius()}, color={GetColor()}, height={height}, volume={GetVolume():0.00}]";
    }
}
