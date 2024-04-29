using System;

class Program
{
    static char GetSign(int number)
    {
        if (number > 0)
        {
            return '+';
        }
        else if (number < 0)
        {
            return '-';
        }
        else
        {
            return '0';
        }
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        char sign = GetSign(number);
        Console.WriteLine($"The sign of the number is: {sign}");
    }
}
