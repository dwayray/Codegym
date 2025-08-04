using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "ten.csv";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File khong ton tai");
            return;
        }

        try
        {
            string[] lines = File.ReadAllLines(filePath);
            Console.WriteLine("Ds tat ca cac quoc gia: ");

            foreach (string line in lines)
            {
                string cleanedLine = line.Replace("\"", "");
                string[] parts = cleanedLine.Split(',');

                if (parts.Length >= 6)
                {
                    string countryCode = parts[4];
                    string countryName = parts[5];

                    Console.WriteLine($"🌍 {countryCode} - {countryName}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Loi khi doc file " + ex.Message);
        }
    }
}
