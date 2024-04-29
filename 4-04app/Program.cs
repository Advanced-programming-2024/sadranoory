using System;

class Program
{
    static double CalculateNewSalary(double currentSalary, double increasePercentage)
    {
        return currentSalary * (1 + increasePercentage / 100);
    }

    static void Main()
    {
        Console.Write("Enter the number of employees: ");
        int numberOfEmployees = int.Parse(Console.ReadLine());

        Console.Write("Enter the increase percentage: ");
        double increasePercentage = double.Parse(Console.ReadLine());

        for (int i = 1; i <= numberOfEmployees; i++)
        {
            Console.Write($"Enter the current salary of employee {i}: ");
            double currentSalary = double.Parse(Console.ReadLine());

            double newSalary = CalculateNewSalary(currentSalary, increasePercentage);
            Console.WriteLine($"New salary of employee {i}: {newSalary}");
        }
    }
}
