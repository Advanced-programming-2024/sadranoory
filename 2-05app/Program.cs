using System;

namespace program05{
    public class program05{
        public static void Main(){
            List<int>   numbers2  = new List<int>{1 , 2, 4 , 8, 16 , 64};
            List<int>   numbers1 = new List<int>{1 , 2, 4 , 8, 16 , 64};
            numbers2.Reverse();
            for (int i = 0; i < numbers2.Count; i++)
            {
                Console.WriteLine(Convert.ToString(numbers1[i]) + '\t' + Convert.ToString(numbers2[i]) );
            }
        }
    }
}