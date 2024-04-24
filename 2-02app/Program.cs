using System; 
using System.Linq; 
using System.Collections.Generic; 
 
namespace Second; 
 
public class program02 {          
  static  void Main(){
        Console.Write("please enter first number");
  int first = int.Parse(Console.ReadLine());
 Console.Write("please enter second number");
 int second = int.Parse(Console.ReadLine());
     int sum = 1;
        for (int i = 1; i <= second; i++)
        {
            sum *= first;
        }
  Console.WriteLine(sum.ToString());
    } 
}