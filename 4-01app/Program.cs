using System;

class Program
{
    static int Function(int x, int y)
    {
        if (x < 0 || y < 0)
        {
            return x - y;
        }
        else
        {
            return Function(x - 1, y) + Function(x, y - 1);
        }
    }

    static void Main()
    {
        Console.Write("Enter the value of x: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Enter the value of y: ");
        int y = int.Parse(Console.ReadLine());

        int result = Function(x, y);
        Console.WriteLine($"f({x}, {y}) = {result}");
    }
}
