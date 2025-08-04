using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static string filePath = "products.txt";

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Quan li sp ===");
            Console.WriteLine("1. Them sp");
            Console.WriteLine("2. Hien thi ds sp");
            Console.WriteLine("3. Tim kiem theo ten");
            Console.WriteLine("0. Thoat");
            Console.Write("Chon chuc nang: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddProduct();
                    break;
                case "2":
                    DisplayProducts();
                    break;
                case "3":
                    SearchProduct();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine(" Lua chon khong hop le");
                    break;
            }
        }
    }

    static void AddProduct()
    {
        Product p = new Product();

        Console.Write("Nhap ma sp ");
        p.ProductCode = Console.ReadLine();

        Console.Write("Nhap ten sp ");
        p.Name = Console.ReadLine();

        Console.Write("Nhap hang sx ");
        p.Manufacturer = Console.ReadLine();

        Console.Write("Nhap gia ");
        double.TryParse(Console.ReadLine(), out double price);
        p.Price = price;

        Console.Write("Nhap mo ta ");
        p.Description = Console.ReadLine();

        File.AppendAllText(filePath, p.ToString() + Environment.NewLine);
        Console.WriteLine("Da them sp ");
    }

    static void DisplayProducts()
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("Chua co sp nao ");
            return;
        }

        string[] lines = File.ReadAllLines(filePath);
        Console.WriteLine("DS sp");

        foreach (string line in lines)
        {
            Product p = Product.FromString(line);
            if (p != null)
            {
                Console.WriteLine($" {p.ProductCode} - {p.Name} - {p.Manufacturer} - {p.Price} - {p.Description}");
            }
        }
    }

    static void SearchProduct()
    {
        Console.Write("Nhhap ten sp can tim ");
        string keyword = Console.ReadLine()?.ToLower();

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File sp khong ton tai.");
            return;
        }

        string[] lines = File.ReadAllLines(filePath);
        bool found = false;

        foreach (string line in lines)
        {
            Product p = Product.FromString(line);
            if (p != null && p.Name.ToLower().Contains(keyword))
            {
                Console.WriteLine($"Tim thay {p.ProductCode} - {p.Name} - {p.Manufacturer} - {p.Price} - {p.Description}");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Khong tim thay sp ");
        }
    }
}
