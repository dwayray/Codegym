using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhap b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        // Giải phương trình
        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine("Pt co vo so nghiem");
            }
            else
            {
                Console.WriteLine("Pt trinh vo nghiem");
            }
        }
        else
        {
            double x = -b / a;
            Console.WriteLine($"Nghiem cua pt la x = {x}");
        }
    }
}
