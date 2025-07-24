using System;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap kich thuoc: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double[,] matrix = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Nhap phan tu [{i},{j}]: ");
                    matrix[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += matrix[i, i];
            }


            Console.WriteLine($"\nTong cac phan tu: {sum}");
        }
    }
}