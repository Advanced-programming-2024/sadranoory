using System;

class Program
{
    static void Main()
    {
        for (int num = 100; num < 1000; num++)
        {
            int digit1 = num / 100;
            int digit2 = (num / 10) % 10;
            int digit3 = num % 10;

            int product = digit1 * digit2 * digit3;

            if (product > num / 2)
            {
                Console.WriteLine(num);
            }
        }
    }
}