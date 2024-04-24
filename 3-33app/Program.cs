using System;

class Program
{
    static double CalculateSeries(int n)
    {
        double result = 0;
        double factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            result += 1.0 / factorial;
        }

        return result;
    }

    static void Main()
    {
        Console.Write("Enter a number (n): ");
        int n = int.Parse(Console.ReadLine());

        double seriesResult = CalculateSeries(n);
        Console.WriteLine($"The result of the series is: {seriesResult}");
    }
}