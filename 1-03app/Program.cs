using System;

namespace ShiftCalculation
{
  public  class Program
    {
     public   static void Main(){
        

          int insurance  = 0;  
		 Console.Write("please enter your salary");
          int salary         = int.Parse(Console.ReadLine());
		 Console.Write("please enter your insurance type");
         int insurancetype = Convert.ToInt32(Console.ReadLine());
		 Console.Write("please enter your tax percent");
          int taxpercent     = int.Parse(Console.ReadLine());
		 double type1  = Convert.ToDouble(salary * 0.07);
		 double type2  = Convert.ToDouble(salary * 0.05);
		  double type3  = Convert.ToDouble(salary * 0.1);
		 
		  insurance = (insurancetype == 1) ? Convert.ToInt32(type1): 
                         (insurancetype == 2) ? Convert.ToInt32(type2) : 
                         (insurancetype == 3) ? Convert.ToInt32(type3) : 
                          insurance;
		  
		  int finaltax    = salary*taxpercent/100;
          int finalsalary = salary-insurance-finaltax;
          Console.WriteLine("your solid salary is $salary".Replace("$salary" , finalsalary.ToString()));
        }
    }
}