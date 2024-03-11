using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());
        
        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());
        
        Console.Write("Enter the third number: ");
        int num3 = int.Parse(Console.ReadLine());
        
        for (int num = num1; num <= num2; num++)
        {
            int sumOfDigits = 0;
            int temp = num;

            while (temp > 0)
            {
                sumOfDigits += temp % 10;
                temp /= 10;
            }

            if (sumOfDigits == num3)
            {
                Console.WriteLine(num);
            }
        }
    }
}