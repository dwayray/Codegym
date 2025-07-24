using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine("Mang ban dau: ");
        PrintArray(array);

        Console.Write("Nhap gia tri can chen: ");
        int value = Convert.ToInt32(Console.ReadLine());

        Console.Write("Nhap vi tri chen: ");
        int position = Convert.ToInt32(Console.ReadLine());


        if (position < 0 || position > array.Length)
        {
            Console.WriteLine("Vi tri khong hop le");
            return;
        }

        int[] newArray = new int[array.Length + 1];

        for (int i = 0; i < position; i++)
        {
            newArray[i] = array[i];
        }

        newArray[position] = value;

        for (int i = position; i < array.Length; i++)
        {
            newArray[i + 1] = array[i];
        }

        Console.WriteLine("Mang sau khi chen: ");
        PrintArray(newArray);
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
