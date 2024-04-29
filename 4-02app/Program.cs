using System;

class Program
{
    static void PrintMultiplesOfThree(int n)
    {
        if (n <= 0)
        {
            return;
        }

        if (n % 3 == 0)
        {
            Console.WriteLine(n);
        }

        PrintMultiplesOfThree(n - 1);
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine($"Multiples of 3 smaller than {number}:");
        PrintMultiplesOfThree(number - 1);
    }
}
