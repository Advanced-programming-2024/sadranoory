using System;

class Program
{
    static void Main()
    {
        double totalTax = 0;
        double totalNetCost = 0;

        while (true)
        {
            Console.Write("لطفا ساعت شروع مکالمه را وارد کنید (از 0 تا 23): ");
            int startHour = Convert.ToInt32(Console.ReadLine());

            if (startHour == -99)
            {
                break;
            }

            Console.Write("لطفا تعداد پالس‌های مکالمه را وارد کنید: ");
            int pulses = Convert.ToInt32(Console.ReadLine());

            Console.Write("لطفا روز انجام مکالمه را وارد کنید (1 تا 7): ");
            int day = Convert.ToInt32(Console.ReadLine());

            double rate = 0;
            if (startHour >= 23 || startHour < 8)
            {
                rate = 50.0 / 100;
            }
            else if (day == 7)
            {
                rate = 76.0 / 100;
            }
            else
            {
                rate = 1.0;
            }

            double pulseRate = 46;
            double grossCost = pulses * pulseRate * rate;
            double tax = grossCost * 4 / 100;
            double netCost = grossCost + tax;

            totalTax += tax;
            totalNetCost += netCost;

            Console.WriteLine($"مبلغ ناخالص مکالمه: {grossCost} ریال");
            Console.WriteLine($"مالیات: {tax} ریال");
            Console.WriteLine($"مبلغ خالص: {netCost} ریال");
        }

        Console.WriteLine($"مجموع مالیات: {totalTax} ریال");
        Console.WriteLine($"مجموع مبلغ خالص: {totalNetCost} ریال");
    }
}