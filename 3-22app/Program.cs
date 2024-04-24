using System;

class Program
{
    static void Main()
    {
        double x = 2; // مقدار x را می‌توانید تغییر دهید
        double sum = 0;
        double term = 0;

        for (int i = 1; i <= 10; i++)
        {
            term = 1 / Math.Pow(x, i);

            if (i % 3 == 2)
            {
                sum -= term;
            }
            else
            {
                sum += term;
            }

            x += i * Math.Pow(x, i);
        }

        Console.WriteLine($"Sum of the first 10 terms of the sequence: {sum}");
    }
}
