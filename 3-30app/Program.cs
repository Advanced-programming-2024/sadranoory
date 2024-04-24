using System;

class Program
{
    static void Main()
    {
        for (int number = 1000; number <= 1100; number++)
        {
            int sumOfDigits = CalculateSumOfDigits(number);

            if (sumOfDigits % 9 == 0)
            {
                Console.WriteLine(number);
            }
        }
    }

    static int CalculateSumOfDigits(int num)
    {
        int sum = 0;
        while (num != 0)
        {
            sum += num % 10;
            num /= 10;
        }
        return sum;
    }
}