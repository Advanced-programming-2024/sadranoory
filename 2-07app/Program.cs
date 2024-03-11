using System;

class Program
{
    static void Main()
    {
        Console.Write("عدد مورد نظر را وارد کنید: ");
        int number = int.Parse(Console.ReadLine());

        int product = 1;
        int digit;

        while (number > 0)
        {
            digit = number % 10;
            if (digit != 0)
            {
                product *= digit;
            }
            number /= 10;
        }

        Console.WriteLine("حاصل ضرب ارقام عدد وارد شده بدون صفر : " + product);
    }
}