public class Point2D
{
    private float x = 0.0f;
    private float y = 0.0f;

    public Point2D(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public Point2D()
    {
        
    }

    public float GetX() => x;
    public void SetX(float x) => this.x = x;

    public float GetY() => y;
    public void SetY(float y) => this.y = y;

    public void SetXY(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public float[] GetXY()
    {
        return new float[] { x, y };
    }

    public override string ToString()
    {
        return $"({x}, {y})";
    }
}
