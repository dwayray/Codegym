using System;
using System.IO;

namespace Codegym
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap duong dan file: ");
            string path = Console.ReadLine();

            try
            {
                if (!File.Exists(path))
                {
                    Console.WriteLine("File khong ton tai");
                    return;
                }

                string[] lines = File.ReadAllLines(path);
                int sum = 0;

                foreach (string line in lines)
                {
                    if (int.TryParse(line.Trim(), out int number))
                    {
                        sum += number;
                    }
                    else
                    {
                        throw new FormatException($"Khong hop le \"{line}\"");
                    }
                }

                Console.WriteLine($"Tong cac so trong file {sum}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Loi dinh dang");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Da xay ra loi");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
