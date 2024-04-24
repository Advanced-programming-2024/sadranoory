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

            int product = DivideWithoutOperator(num1, num2);
            Console.WriteLine($"Product of {num1} and {num2} is: {product}");
        }
    }

    static int DivideWithoutOperator(int num1, int num2)
    {
        int result = 0;
        int sign = 1;

        if ((num1 < 0 && num2 > 0) || (num1 > 0 && num2 < 0))
        {
            sign = -1;
        }

        num1 = Math.Abs(num1);
        num2 = Math.Abs(num2);

        while (num1 >= num2)
        {
            num1 -= num2;
            result++;
        }

        return result * sign;
    }
}
