using System;
using TimerApp;

class Program
{
    static void Main(string[] args)
    {
        const int SIZE = 100000;
        int[] numbers = new int[SIZE];
        Random rand = new Random();

        for (int i = 0; i < SIZE; i++)
        {
            numbers[i] = rand.Next(0, 1000000);
        }

        StopWatch sw = new StopWatch();
        sw.Start();

        SelectionSort(numbers);

        sw.Stop();

        Console.WriteLine($"Selection sort on {SIZE} elements took {sw.GetElapsedTime()} milliseconds.");
    }

    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                    minIndex = j;
            }

            if (minIndex != i)
            {
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
        }
    }
}
