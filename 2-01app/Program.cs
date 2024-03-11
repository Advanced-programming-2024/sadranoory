using System;  
namespace Programm01; 
 
public static class Programm01  
{          
    public static void Main() 
    { 
        Console.WriteLine("please enter an odd number");
  int number = int.Parse( Console.ReadLine());
  int sum = 0;
  int sign = 1;
        for (int i = 1; number >= i; i+=2)
        {
            sum += i * sign;
   sign = -sign;
   Console.WriteLine(sum.ToString());
        } 
    } 
}