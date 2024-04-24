using System;

class Program
{
    static void Main()
    {
        int excellent = 0;
        int good = 0;
        int moderate = 0;
        int weak = 0;
        int totalStudents = 0;

        while (true)
        {
            Console.Write("لطفا نمره دانشجو را وارد کنید (برای پایان، عدد منفی وارد کنید): ");
            int score = Convert.ToInt32(Console.ReadLine());

            if (score < 0)
            {
                break;
            }

            switch (score)
            {
                case int n when n >= 18:
                    excellent++;
                    break;
                case int n when n >= 15:
                    good++;
                    break;
                case int n when n >= 12:
                    moderate++;
                    break;
                default:
                    weak++;
                    break;
            }

            totalStudents++;
        }

        Console.WriteLine($"تعداد کل دانشجویان: {totalStudents}");
        Console.WriteLine($"تعداد دانشجویان ممتاز: {excellent} ({(double)excellent / totalStudents:P1})");
        Console.WriteLine($"تعداد دانشجویان خوب: {good} ({(double)good / totalStudents:P1})");
        Console.WriteLine($"تعداد دانشجویان معمولی: {moderate} ({(double)moderate / totalStudents:P1})");
        Console.WriteLine($"تعداد دانشجویان ضعیف: {weak} ({(double)weak / totalStudents:P1})");
    }
}