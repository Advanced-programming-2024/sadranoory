using System;

class Program
{
    static void Main()
    {
        Console.Write("لطفاً مقدار سرمایه گذاری خود را وارد کنید: ");
        double initialInvestment = double.Parse(Console.ReadLine());

        double annualInterestRate = 45.0 / 1000.0;
        double totalInvestment = initialInvestment;

        for (int i = 1; i <= 8; i++)
        {
            double annualProfit = totalInvestment * annualInterestRate;
            totalInvestment += annualProfit;
            Console.WriteLine("سرمایه بعد از سال " + i + ": " + totalInvestment);
        }

        Console.WriteLine("سرمایه نهایی پس از ۸ سال: " + totalInvestment);
    }
}