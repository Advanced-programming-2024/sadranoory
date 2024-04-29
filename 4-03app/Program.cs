using System;

class Program
{
    static void PrintOddNumbers(int start, int end)
    {
        if (start > end)
        {
            return;
        }

        if (start % 2 != 0)
        {
            Console.WriteLine(start);
        }

        PrintOddNumbers(start + 1, end);
    }

    static void Main()
    {
        Console.Write("Enter the start number: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Enter the end number: ");
        int end = int.Parse(Console.ReadLine());

        Console.WriteLine($"Odd numbers between {start} and {end}:");
        PrintOddNumbers(start, end);
    }
}
