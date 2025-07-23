using System;

class Program
{
    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("1.In hinh chu nhat");
            Console.WriteLine("2. In hinh tam giac vuong");
            Console.WriteLine("3. In tam giac cac");
            Console.WriteLine("0. Thoat");
            Console.Write("Nhap lua chon: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    DrawRectangle();
                    break;
                case 2:
                    DrawRightTriangles();
                    break;
                case 3:
                    DrawIsoscelesTriangle();
                    break;
                case 0:
                    Console.WriteLine("Da thoat chuong trinh");
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    break;
            }

        } while (choice != 0);
    }

    static void DrawRectangle()
    {
        Console.Write("Nhap chieu dai: ");
        int height = int.Parse(Console.ReadLine());
        Console.Write("Nhap chieu rong: ");
        int width = int.Parse(Console.ReadLine());

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    static void DrawRightTriangles()
    {
        Console.Write("Nhap chieu cao tam giac: ");
        int height = int.Parse(Console.ReadLine());

        Console.WriteLine("\nGoc vuong duoi trai:");
        for (int i = 1; i <= height; i++)
        {
            for (int j = 1; j <= i; j++)
                Console.Write("* ");
            Console.WriteLine();
        }

        Console.WriteLine("\nGoc vuong tren trai:");
        for (int i = height; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
                Console.Write("* ");
            Console.WriteLine();
        }

        Console.WriteLine("\nGoc vuong duoi phai:");
        for (int i = 1; i <= height; i++)
        {
            for (int j = 1; j <= height - i; j++)
                Console.Write("  ");
            for (int k = 1; k <= i; k++)
                Console.Write("* ");
            Console.WriteLine();
        }

        Console.WriteLine("\nGoc vuong tren phai:");
        for (int i = height; i >= 1; i--)
        {
            for (int j = 1; j <= height - i; j++)
                Console.Write("  ");
            for (int k = 1; k <= i; k++)
                Console.Write("* ");
            Console.WriteLine();
        }
    }

    static void DrawIsoscelesTriangle()
    {
        Console.Write("Nhap chieu cao tam giac can: ");
        int height = int.Parse(Console.ReadLine());

        for (int i = 1; i <= height; i++)
        {
            for (int j = 1; j <= height - i; j++)
                Console.Write("  ");

            for (int k = 1; k <= 2 * i - 1; k++)
                Console.Write("* ");

            Console.WriteLine();
        }
    }
}
