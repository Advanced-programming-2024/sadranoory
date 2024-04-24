using System;

class Program
{
    static void Main()
    {
        int num1, num2;

        while (true)
        {
            Console.Write("Enter the first integer (or 0 to exit): ");
            num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 == 0)
            {
                Console.WriteLine("Program terminated.");
                break;
            }

            Console.Write("Enter the second integer: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            int product = MultiplyWithoutOperator(num1, num2);
            Console.WriteLine($"Product of {num1} and {num2} is: {product}");
        }
    }

    static int MultiplyWithoutOperator(int a, int b)
    {
        int result = 0;
        for (int i = 0; i < Math.Abs(b); i++)
        {
            result += a;
        }

        if (b < 0)
        {
            result = -result;
        }

        return result;
    }
}
