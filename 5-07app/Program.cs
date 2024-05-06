using System;

class Program
{
    static void Main()
    {
        int[] array1 = ReadArray("Enter the first array (15 elements):");
        int[] array2 = ReadArray("Enter the second array (15 elements):");

        int[] resultArray = MultiplyArrays(array1, array2);

        PrintArray("Result of multiplication:", resultArray);
    }

    static int[] ReadArray(string message)
    {
        Console.WriteLine(message);
        int[] array = new int[15];

        for (int i = 0; i < 15; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        return array;
    }

    static int[] MultiplyArrays(int[] array1, int[] array2)
    {
        int[] resultArray = new int[15];

        for (int i = 0; i < 15; i++)
        {
            resultArray[i] = array1[i] * array2[i];
        }

        return resultArray;
    }

    static void PrintArray(string message, int[] array)
    {
        Console.WriteLine(message);
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
    }
}
