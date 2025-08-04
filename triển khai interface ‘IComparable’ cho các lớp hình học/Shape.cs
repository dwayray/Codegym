public abstract class Shape
{
    public abstract double GetArea();
    public override string ToString()
    {
        return $"Area = {GetArea():F2}";
    }
}
