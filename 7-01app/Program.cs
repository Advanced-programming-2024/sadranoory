using System;
namespace Name
{
    class Program{
    static void Main(){
        FractionNum n = new FractionNum(8 , 100);
        FractionNum f = new FractionNum(5 , 100);
        FractionNum sum = FractionNum.SubFractions(n , f);
        Console.WriteLine(FractionNum.ToString(sum));
 }







}

public class FractionNum {
   int numerator;
   int denominator;
   public FractionNum(int n , int d){
    numerator = n;
    if(d == 0){
        denominator =1;
    }else
    {
        denominator = d;
    }
    }
    public int N{
        get{
            return numerator;
        }
        set{
            numerator = value;
        }        
    }
    public int D{
        get{
            return denominator;
        }
        set{
            if(value != 0){
                denominator = value;
            }
        }
    }

    public static FractionNum SumFractions(FractionNum first , FractionNum second){
       first.N  *= second.D;
        second.N *= first.D;
        first.D  *= second.D;

        first.N += second.N;
        first.simplifyFractionNum();
        return first;
    }
    public static FractionNum SubFractions(FractionNum first , FractionNum second){
        
        first.N  *= second.D;
        second.N *= first.D;
        first.D  *= second.D;

        first.N -= second.N;
        first.simplifyFractionNum();
        return first;

    }
    public static FractionNum multipyFractions(FractionNum first , FractionNum second){
        first.N *= second.N;
        first.D *= second.D;
        first.simplifyFractionNum();
        return first;
    }

    public void simplifyFractionNum(){

     for (int i = 2; i <= numerator || i <= denominator;i++)
     {
        if(numerator % i == 0 && denominator % i == 0){
            numerator /= i;
            denominator /= i;
            i = 1;
        }

     }         
        
    }

    public static string      ToString(FractionNum num){
        return num.N.ToString()+"/"+num.D.ToString();
    }



}

}
