using System;

class Program
{
    static void Main()
    {
        Console.Write("تعداد کارمندان را وارد کنید: ");
        int n = int.Parse(Console.ReadLine());

        string min1Name = "";
        int min1Hours = int.MaxValue;
        string min2Name = "";
        int min2Hours = int.MaxValue;
        string min3Name = "";
        int min3Hours = int.MaxValue;

        for (int i = 0; i < n; i++)
        {
            Console.Write("نام کارمند شماره " + (i + 1) + " را وارد کنید: ");
            string employeeName = Console.ReadLine();

            Console.Write("ساعات کاری کارمند " + employeeName + " را وارد کنید: ");
            int hoursWorked = int.Parse(Console.ReadLine());

            if (hoursWorked < min1Hours)
            {
                min3Hours = min2Hours;
                min3Name = min2Name;
                min2Hours = min1Hours;
                min2Name = min1Name;
                min1Hours = hoursWorked;
                min1Name = employeeName;
            }
            else if (hoursWorked < min2Hours)
            {
                min3Hours = min2Hours;
                min3Name = min2Name;
                min2Hours = hoursWorked;
                min2Name = employeeName;
            }
            else if (hoursWorked < min3Hours)
            {
                min3Hours = hoursWorked;
                min3Name = employeeName;
            }
        }

        Console.WriteLine("سه کارمند با کمترین ساعات کاری:");
        Console.WriteLine(min1Name + " - " + min1Hours + " ساعت");
        Console.WriteLine(min2Name + " - " + min2Hours + " ساعت");
        Console.WriteLine(min3Name + " - " + min3Hours + " ساعت");
    }
}