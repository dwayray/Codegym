using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string str = "trung tam lap trinh codegym";

            Console.Write("Nhap ki tu can dem: ");
            char c = Console.ReadKey().KeyChar; 
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                {
                    count++;
                }
            }
            Console.WriteLine($"Ky tu '{c}' xuat hien {count} lan trong chuoi: ");
        }
    }
}
