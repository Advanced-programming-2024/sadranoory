using System;

class Program
{
    static void Main()
    {
        int[] array1 = GenerateRandomNumbers(10, 1, 40);
        int[] array2 = GenerateRandomNumbers(10, 1, 50);

        PrintArrayDifference(array1, array2);
    }

    static int[] GenerateRandomNumbers(int count, int min, int max)
    {
        Random random = new Random();
        int[] numbers = new int[count];
        for (int i = 0; i < count; i++)
        {
            numbers[i] = random.Next(min, max + 1);
        }
        return numbers;
    }

    static void PrintArrayDifference(int[] array1, int[] array2)
    {
        Console.WriteLine("Elements in the first array that are not in the second array:");
        foreach (int num in array1)
        {
            if (Array.IndexOf(array2, num) == -1)
            {
                Console.WriteLine(num);
            }
        }
    }
}
