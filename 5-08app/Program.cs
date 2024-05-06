using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string input = Console.ReadLine();

        int[] wordLengthCounts = CountWordLengths(input);

        PrintWordLengthCounts(wordLengthCounts);
    }

    static int[] CountWordLengths(string input)
    {
        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int[] wordLengthCounts = new int[10]; // برای ذخیره تعداد کلمات 1 تا 10 حرفی

        foreach (string word in words)
        {
            int length = word.Length;
            if (length <= 9) // فقط تا 9 حرف
            {
                wordLengthCounts[length - 1]++;
            }
        }

        return wordLengthCounts;
    }

    static void PrintWordLengthCounts(int[] counts)
    {
        for (int i = 0; i < counts.Length; i++)
        {
            if (counts[i] > 0)
            {
                Console.WriteLine($"Number of {i + 1}-letter words: {counts[i]}");
            }
        }
    }
}
