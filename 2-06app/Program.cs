using System;

class Program
{
    static void Main()
    {
        int[] householdExpenses = new int[1000]; // تعداد خانوارها    
        int minExpense = householdExpenses[0];
        int maxExpense = householdExpenses[0];
        for (int i = 0; i < householdExpenses.Length; i++)
        {
            Console.Write($"Enter expense for household {i + 1}: ");
            string readline = Console.ReadLine();
            string input = "";
            if (readline == "-99")
            {
                break;
            }else{
                input = readline;
      if (int.TryParse(input, out int expense))
            {
                householdExpenses[i] = expense;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                i--;
            }
        }

        int totalAnnualExpense = 0;
        foreach (int expense in householdExpenses)
        {
            totalAnnualExpense += expense * 12;
        }

        Console.WriteLine($"Total annual expenses for all households: {totalAnnualExpense}");

         minExpense = householdExpenses[0];
         maxExpense = householdExpenses[0];

        foreach (int expense in householdExpenses)
        {
            if (expense < minExpense)
            {
                minExpense = expense;
            }

            if (expense > maxExpense)
            {
                maxExpense = expense;
            }
  
                
            }


            }

        Console.WriteLine($"Household with minimum expense: {Array.IndexOf(householdExpenses, minExpense) + 1}");
        Console.WriteLine($"Household with maximum expense: {Array.IndexOf(householdExpenses, maxExpense) + 1}");
    }
}