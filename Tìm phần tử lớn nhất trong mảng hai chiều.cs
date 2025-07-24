using System;
namespace Program
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so dong: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap so cot: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            double[,] matrix = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Nhap phan tu [{i},{j}]: ");
                    matrix[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            double max = matrix[0, 0];
            int maxRow = 0;
            int maxCol = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                        maxRow = i;
                        maxCol = j;
                    }
                }
            }

            Console.WriteLine($"\nPhan tu lon nhat {max}");
            Console.WriteLine($"Toa do lon nhat: hang {maxRow}, cot {maxCol}");
        }
    }
}
