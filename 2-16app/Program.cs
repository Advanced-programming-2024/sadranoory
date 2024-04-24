using System;

class Program
{
    static void Main()
    {
        for (int num = 1000; num < 10000; num++)
        {
            int product = 1;
            int temp = num;

            while (temp > 0)
            {
                int digit = temp % 10;
                if (digit == 0 || num % digit != 0)
                {
                    product = 0;
                    Console.
                    break;
                }
                product *= digit;
            
                temp /= 10;
            }

            if (product == num)
            {
                Console.WriteLine(num);
            }
        }
    }
}
