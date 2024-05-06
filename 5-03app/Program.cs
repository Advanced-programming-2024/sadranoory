using System;

class Program
{
    static void Main()
    {
        int[] numbers = ReadNumbers();
        int primeSum = CalculatePrimeSum(numbers);
        Console.WriteLine("Sum of prime numbers between the given numbers: " + primeSum);

        PrintNumbersGreaterThanSum(numbers, primeSum);
    }

    static int[] ReadNumbers()
    {
        Console.Write("Enter the number of elements: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number " + (i + 1) + ": ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        return numbers;
    }

    static bool IsPrime(int num)
    {
        if (num <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }

    static int CalculatePrimeSum(int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            if (IsPrime(num))
            {
                sum += num;
            }
        }
        return sum;
    }

    static void PrintNumbersGreaterThanSum(int[] numbers, int sum)
    {
        Console.WriteLine("Numbers greater than the sum of prime numbers: ");
        foreach (int num in numbers)
        {
            if (num > sum)
            {
                Console.WriteLine(num);
            }
        }
    }
}
