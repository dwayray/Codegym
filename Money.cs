using System;

class Program
{
    static void Main(string[] args)
    {

        double rate = 23000;

        Console.Write("Nhap sso tien: ");
        string input = Console.ReadLine();
        double usd;

        if (double.TryParse(input, out usd))
        {

            double vnd = usd * rate;
            Console.WriteLine($"{usd} USD = {vnd:N0} VND");
        }
        else
        {
            Console.WriteLine("Gia tri khong hop le!");
        }

        Console.ReadLine();
    }
}