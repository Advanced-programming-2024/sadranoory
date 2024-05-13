using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("لطفا تعداد محصولات را مشخص کنید");
        int count = Int32.Parse(Console.ReadLine());
        int [,] items = new int [ count,2 ];

           for (int i = 0; i < items.GetLength((0)) ; i++)
        {
            Console.WriteLine( "کد محصول {0} را وارد کنید" ,i+1 );
            items[i, 0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( "تعداد موجودی محصول {0} را وارد کنید" ,i+1 );
            items[i,1] = Int32.Parse(Console.ReadLine());
        }
        

        
        for (;;)
        {
            Console.WriteLine("کد محصول مورد نظر را وارد کنید");

            int code = Int32.Parse(Console.ReadLine());
            if (code == -1)
            {
             break;   
            }

            
                try
                {
                    for (int i = 0; i < items.GetLength(0); i++){
                    if (items[i , 0] == code)
                    {
                        Console.WriteLine("موجودی: {0}" , items[i,1]);
                        break;
                    }
                     }
                }
                catch (Exception e)
                {
                    Console.WriteLine("این کد وجود ندارد");
                    continue;
                }
             
           
            
        }
        
    }

}