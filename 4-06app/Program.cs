using System;

class Program
{
    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    static int CountPrimesBetween(int start, int end)
    {
        int count = 0;
        for (int i = start; i <= end; i++)
        {
            if (IsPrime(i))
            {
                count++;
            }
        }
        return count;
    }

    static void Main()
    {
        Console.Write("Enter the starting number: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Enter the ending number: ");
        int end = int.Parse(Console.ReadLine());

        int primeCount = CountPrimesBetween(start, end);
        Console.WriteLine($"The number of prime numbers between {start} and {end} is: {primeCount}");
    }
}
