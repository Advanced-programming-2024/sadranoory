using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("لطفا نوع مصرف را انتخاب کنید (H برای خانگی، I برای صنعتی، F برای تجاری): ");
            char type = Char.ToUpper(Convert.ToChar(Console.ReadLine()));

            if (type == '-')
            {
                break;
            }

            Console.Write("لطفا مقدار مصرف به متر مکعب را وارد کنید: ");
            double consumption = Convert.ToDouble(Console.ReadLine());

            double bill = 0;

            switch (type)
            {
                case 'H':
                    bill = consumption / 100 * 500;
                    break;
                case 'I':
                    if (consumption <= 4000000)
                    {
                        bill = consumption / 1000 * 750;
                    }
                    else
                    {
                        bill = 4000 * 750 + (consumption - 4000000) * 0.00025;
                    }
                    break;
                case 'F':
                    if (consumption <= 2000000)
                    {
                        bill = consumption / 150 * 600;
                    }
                    else
                    {
                        bill = 2000 * 600 + (consumption - 2000000) * 0.00004;
                    }
                    break;
                default:
                    Console.WriteLine("نوع مصرف وارد شده معتبر نیست.");
                    continue;
            }

            Console.WriteLine($"مبلغ قبض آب برای مصرف {consumption} متر مکعب با نوع {type} برابر است با: {bill} ریال");
        }
    }
}