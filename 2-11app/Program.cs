using System;

class Program
{
    static void Main()
    {
        int count = 0;
        int maleCount = 0;

        while (true)
        {
            Console.Write("لطفاً سن فرد را وارد کنید (برای پایان وارد کردن -1 را وارد کنید): ");
            int age = int.Parse(Console.ReadLine());

            if (age == -1)
            {
                break;
            }

            Console.Write("لطفاً جنسیت فرد را وارد کنید (M یا F): ");
            char gender = char.Parse(Console.ReadLine());

            if (gender == 'M' || gender == 'm')
            {
                if (age >= 18 && age <= 20)
                {
                    maleCount++;
                }
            }

            count++;
        }

        double malePercentage = (double)maleCount / count * 100;

        Console.WriteLine("تعداد مردان با سن بین ۱۸ تا ۲۰: " + maleCount);
        Console.WriteLine("درصد مردان با سن بین ۱۸ تا ۲۰: " + malePercentage + "%");
    }
}