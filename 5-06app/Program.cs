using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        string result = RemoveTwoLetterWords(input);
        
        Console.WriteLine("Result: " + result);
    }

    static string RemoveTwoLetterWords(string input)
    {
        string[] words = input.Split(' ');
        string result = "";

        foreach (string word in words)
        {
            if (word.Length != 2)
            {
                result += word + " ";
            }
        }

        return result.Trim();
    }
}
