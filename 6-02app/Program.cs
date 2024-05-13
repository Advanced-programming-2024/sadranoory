using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("لطفا زمان توقف را وارد کنید:");
        Console.Write("ساعت: ");
        int hours = Convert.ToInt32(Console.ReadLine());
        Console.Write("دقیقه: ");
        int minutes = Convert.ToInt32(Console.ReadLine());

        
        double payment = CalculatePayment(hours, minutes);

        
        Console.WriteLine($"مبلغ پرداختی: {payment} دلار");

        Console.ReadLine();
    }

    
    static double CalculatePayment(int hours, int minutes)
    {
        
        int totalMinutes = hours * 60 + minutes;

        
        double totalPayment = 2.0; 
        int extraMinutes = totalMinutes - 180; 
        if (extraMinutes > 0)
        {
            
            double extraPayment = Math.Ceiling(extraMinutes / 30.0) * 0.5;
            totalPayment += extraPayment;

            
            totalPayment = Math.Min(totalPayment, 10.0);
        }

        return totalPayment;
    }
}
