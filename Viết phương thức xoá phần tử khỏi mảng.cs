using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n ");
            int N = int.Parse(Console.ReadLine());

            int[] array = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write($"Phan tu thu {i}: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Nhap phan tu xoa (X): ");
            int X = int.Parse(Console.ReadLine());
            int index_del = -1;
            for (int i = 0; i < N; i++)
            {
                if (array[i] == X)
                {
                    index_del = i;
                    break;
                }
            }

            if (index_del == -1)
            {
                Console.WriteLine("Phan tu khong ton tai");
            }
            else
            {
                for (int i = index_del; i < N - 1; i++)
                {
                    array[i] = array[i + 1];
                }

                N--;
                Console.WriteLine("Mang sau khi xoa:");
                for (int i = 0; i < N; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
