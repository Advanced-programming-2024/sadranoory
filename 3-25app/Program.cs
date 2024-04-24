using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the value of m: ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the value of n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int result = 1;
        for (int i = 0; i < n; i++)
        {
            result *= m;
        }

        Console.WriteLine($"{m}^{n} = {result}");
    }
}
