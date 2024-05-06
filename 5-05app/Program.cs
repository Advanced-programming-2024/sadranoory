using System;

class Program
{
    static void Main()
    {
        int[] array = new int[10];
        Console.WriteLine("Enter 10 elements of the array:");
        
        for (int i = 0; i < 10; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Enter a number between 0 and 8:");
        int rotateCount = Convert.ToInt32(Console.ReadLine());

        RotateArray(array, rotateCount);
        
        Console.WriteLine("Rotated array:");
        PrintArray(array);
    }

    static void RotateArray(int[] arr, int count)
    {
        int n = arr.Length;
        int[] temp = new int[n];
        
        for (int i = 0; i < n; i++)
        {
            temp[(i + count) % n] = arr[i];
        }
        
        for (int i = 0; i < n; i++)
        {
            arr[i] = temp[i];
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
