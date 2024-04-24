using System;

class Program
{
    static void Main()
    {
        char input;
        
        do
        {
            Console.WriteLine("لطفا یک حرف وارد کنید (برای خروج از برنامه e یا E را وارد کنید): ");
            input = Char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (input == 'r')
            {
                Console.WriteLine("دوست دارید رنگ قرمز (Red) را انتخاب کنید.");
            }
    else   if (input == 'g')
            {
                Console.WriteLine("دوست دارید رنگ سبز (Green) را انتخاب کنید.");
            }
    else if (input == 'b')
            {
                Console.WriteLine("دوست دارید رنگ آبی (Blue) را انتخاب کنید.");
            }
            
            else if (input != 'e')
            {
                Console.WriteLine("ورودی نامعتبر!");
            }

        } while (input != 'e');
    }
}