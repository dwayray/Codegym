using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong can in ");
            int numbers = Convert.ToInt32(Console.ReadLine());

            int count = 0;

            int N = 2;

            while (count < numbers)
            {
                if (IsPrime(N))
                {
                    Console.Write(N + " ");
                    count++;
                }
                N++;
            }

            Console.WriteLine();
        }

        static bool IsPrime(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
