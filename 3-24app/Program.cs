class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int reversedNumber = ReverseNumber(number);
        if(number == reversedNumber){
            Console.WriteLine("The number is palindrome.");
        }
        else
        {
            Console.WriteLine("The number is not palindrome.");
        }
       
    }

    static int ReverseNumber(int number)
    {
        int reversedNumber = 0;
        while (number > 0)
        {
            int digit = number % 10;
            reversedNumber = reversedNumber * 10 + digit;
            number = number / 10;
        }
        return reversedNumber;
    }
}