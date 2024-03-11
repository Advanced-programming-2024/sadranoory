using System;

class Program
{
    static void Main()
    {
        int count = 0;

        for (int num = 1000; num < 10000; num++)
        {
            int temp = num;
            int zeroCount = 0;

            while (temp > 0)
            {
                if (temp % 10 == 0)
                {
                    zeroCount++;
                }
                temp /= 10;
            }

            if (zeroCount > 0)
            {
                count += zeroCount;
            }
        }

        Console.WriteLine("Total number of zeros in four-digit numbers: " + count);
    }
}