using System;

namespace program03{
    public class program03{
        public static void Main(){

            Console.WriteLine("please enter number a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter number b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter number c");
            int c = int.Parse(Console.ReadLine());
            int result = 0;
            if(a%2 == 0){
            result = Convert.ToInt32(Math.Pow(a , 3) + Math.Pow(b , 3) + Math.Pow(c , 3));
                
            }else if (a %2 != 0){
                result = Convert.ToInt32(Math.Pow(a , 2) + Math.Pow(b , 2) + Math.Pow(c , 2));
            
            }
                Console.WriteLine("result = {0}" , result );
        }
    }
}