using System;

class Program
{
    static void Main()
    {
        for (int num = 1000; num < 10000; num++)
        {
            int sum = 0;
            int temp = num;

            while (temp > 0)
            {
                sum += temp % 10;
                temp /= 10;
            }

            if (sum % 2 != 0)
            {
                Console.WriteLine(num);
            }
        }
    }
}