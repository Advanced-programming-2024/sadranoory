using System;

class Program
{
    static void Main()
    {
        int maleCount = 0;
        int femaleCount = 0;
        int maleTotalSalary = 0;
        int femaleTotalSalary = 0;

        while (true)
        {
            Console.WriteLine("Enter employee information or enter '00' to exit:");

            Console.Write("Employee Number: ");
            int employeeNumber = Convert.ToInt32(Console.ReadLine());
            if (employeeNumber == 0)
            {
                break;
            }

            Console.Write("Hiring Year: ");
            int hiringYear = Convert.ToInt32(Console.ReadLine());

            Console.Write("Gender Code (0 for Female, 1 for Male): ");
            int gender = Convert.ToInt32(Console.ReadLine());

            Console.Write("Salary: ");
            int salary = Convert.ToInt32(Console.ReadLine());

            if (gender == 1)
            {
                maleCount++;
                maleTotalSalary += salary;
            }
            else
            {
                femaleCount++;
                femaleTotalSalary += salary;
            }
        }

        double maleAverageSalary = maleCount > 0 ? (double)maleTotalSalary / maleCount : 0;
        double femaleAverageSalary = femaleCount > 0 ? (double)femaleTotalSalary / femaleCount : 0;

        Console.WriteLine($"Number of Male Employees: {maleCount}");
        Console.WriteLine($"Number of Female Employees: {femaleCount}");
        Console.WriteLine($"Average Salary for Male Employees: {maleAverageSalary}");
        Console.WriteLine($"Average Salary for Female Employees: {femaleAverageSalary}");
    }
}