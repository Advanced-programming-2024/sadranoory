using System;


public class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("لطفاً عدد اول را وارد کنید:");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("لطفاً عدد دوم را وارد کنید:");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("اعداد اول بین " + number1 + " و " + number2 + " عبارتند از:");

        for (int i = number1; i <= number2; i++)
        {
            bool isPrime = true;
            if (i <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        
                        break;
                    }
                }
            }

            if (isPrime)
            {
                Console.WriteLine(i);
            }
        }
    }
}
