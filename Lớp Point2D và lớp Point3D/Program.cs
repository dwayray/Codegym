using System;

// class Program
// {
//     static void Main()
//     {
//         Point3D p3d = new Point3D(1.1f, 2.2f);
//         Console.WriteLine(p3d.ToString()); 
//         p3d.SetZ(3.3f);
//         Console.WriteLine($"Z: {p3d.GetZ()}"); 
//         p3d.SetXYZ(4, 5, 6);
//         var coords = p3d.GetXYZ();
//         Console.WriteLine($"X: {coords[0]}, Y: {coords[1]}, Z: {coords[2]}"); 
//     }
// }
class Program
{
    static void Main()
    {
        Point2D p2d = new Point2D(3.5f, 7.2f);
        Console.WriteLine(p2d.ToString());

        p2d.SetX(10);
        p2d.SetY(20);
        Console.WriteLine($"X: {p2d.GetX()}, Y: {p2d.GetY()}");

        p2d.SetXY(5, 6);
        var coords = p2d.GetXY();
        Console.WriteLine($"X: {coords[0]}, Y: {coords[1]}"); 
    }
}
