using System;

namespace program03{
    public class program04{
        public static void Main(){
        for (;;)
        {
            
           Console.WriteLine("please enter a number");
        String number = Console.ReadLine();
        if(int.Parse(number) ==  -1){
            break;
        }
        if(number.Contains('0')){
            Console.WriteLine("number contains 0");
        }   
        }
      
        
        }
    }
}