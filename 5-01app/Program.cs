using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine().ToLower(); // Convert the input to lowercase for consistency

        Console.Write("Enter a number k: ");
        int k = int.Parse(Console.ReadLine());

        string encryptedString = EncryptString(inputString, k);
        Console.WriteLine("Encrypted string: " + encryptedString);
    }

    static string EncryptString(string inputString, int k)
    {
        string encryptedString = "";
        foreach (char c in inputString)
        {
            if (char.IsLetter(c))
            {
                char encryptedChar = EncryptChar(c, k);
                encryptedString += encryptedChar;
            }
            else
            {
                encryptedString += c;
            }
        }
        return encryptedString;
    }

    static char EncryptChar(char c, int k)
    {
        char baseChar = char.IsUpper(c) ? 'A' : 'a';
        int offset = c - baseChar;
        int encryptedOffset = (offset + k) % 26; // Applying the encryption formula
        char encryptedChar = (char)(baseChar + encryptedOffset);
        return encryptedChar;
    }
}
