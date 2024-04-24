using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the current price of the item:");
        double price = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the inflation rate (as a percentage):");
        double inflationRate = Convert.ToDouble(Console.ReadLine()) / 100;

        Console.WriteLine("Enter the number of years for price prediction:");
        int years = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= years; i++)
        {
            price += price * inflationRate;
            Console.WriteLine($"Predicted price for year {i}: {price:C}");
        }
    }
}
