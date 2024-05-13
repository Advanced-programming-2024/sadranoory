using System;

namespace Name
{
    class Program
    {
         public static void Main()
        {
            
            Date date1 = new Date(1403 , 5 , 31);
            Date date2 = new Date(1400 , 6 , 31);
            Console.WriteLine(Date.sumDate(date1 , date2).Tostring());

        }
        
    }

    class Date{
        int year , month , day;
        public Date(int y , int  m , int d){
            year = (y > 0) ? y : year = 1;
            month = (m > 0 && m <= 12) ? m : month =1;
            if (month <= 6){
                day = (d <=31 && d>0 ) ? d : day =1 ;
            }
            else if(month > 6 && month != 12){
                day = (d <=30 && d>0 ) ? d : day =1 ;
            }
            else if(month == 12){
             day = (d <=29 && d>0 ) ? d : day =1 ;   
            }
             }
          public  int Y {

                get{
                    return year;
                }
                set{
                     if(value > 0){
                year = value;
            }
                }
            }
           public int M{
                get{
                    return month;
                }
                set{
                     if(value > 0){
                month = value;
            }
                }
            }
         public int D{
                get{
                    return day;
                }
                set{
                     if(value > 0){
                day = value;
            }
                }
            }

       
        public  String Tostring(){
        String result = year.ToString()+"/"+month.ToString()+"/"+day.ToString();
        return result;
        }
        public static bool Equals(Date first , Date second){
            if(first.Y == second.Y && first.M == second.M && first.D == second.D){
                return true;
            }else{
                return false;
            }
        }
        public void nextDay(){
            if(month <= 6 && day < 31) ++day ;
            else if ( month >= 6 && day ==31){ ++month ; day =1 ; }
            else if (month > 6 && month != 12 && day <30 ) ++day;
            else if (month > 6 && month != 12 && day ==30){ ++month ; day = 1; }
            else if (month == 12 && day <29) ++day;
            else if (month == 12 && day ==29){++year ; month =1 ; day =1; }
        }
        public static Date sumDate(Date first , Date second){
            
            first = Date.sumYear(first , second);
            first = Date.summonth(first , second);
            first = Date.sumday(first , second);
            first.cleanDate();
            return first;

            
        }
        public static Date sumYear(Date first , Date second){
           int nyear = 0;
           int oyear = 0;
           if(first.Y > second.Y){nyear = first.Y; oyear = second.Y;} 
           else if(second.Y > first.Y){ nyear = second.Y;oyear = first.Y;}
            first.Y= nyear+(nyear-oyear); 
            return first;
        }
        public static Date summonth(Date first , Date second){
            int summonth = first.M+second.M;
            Console.WriteLine(summonth.ToString());
            if(summonth > 12){
                ++first.Y;
                first.M -= 12;
                Console.WriteLine(first.M.ToString());
                return first;
            }else{
                first.M = summonth;
                Console.WriteLine(first.M.ToString());
                return first;
            }
            
        }

        public static Date sumday(Date first , Date second){
            int sumday = first.D + second.D;
            if(first.M <= 6 && sumday > 31){
                Console.WriteLine("d1");
                ++first.M ;
                first.D = sumday-31;

            }else if(first.M>6 && first.M != 12 && sumday > 30){
                ++first.M;
                first.D = sumday-30;
                Console.WriteLine("d2");
            }else if(first.M ==12 && sumday >29  ){
                ++first.Y;
                first.M = 1;
                first.D = sumday - 29;
                Console.WriteLine("d3");
            }else{
                first.D = sumday;
            }
            return first;
             
        }
        public void cleanDate(){

            if(month <= 6 && day > 31){
                Console.WriteLine("d1");
                ++month ;
                day = day-31;

            }else if(month>6 && month != 12 && day > 30){
                ++month;
                day = day-30;
                Console.WriteLine("d2");
            }else if(month ==12 && day >29  ){
                ++year;
                month = 1;
                day = day - 29;
                Console.WriteLine("d3");
            }
        }
    }

}