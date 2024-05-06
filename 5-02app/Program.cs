using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an encrypted string: ");
        string encryptedString = Console.ReadLine().ToLower(); // Convert the input to lowercase for consistency

        Console.Write("Enter the decryption key k: ");
        int k = int.Parse(Console.ReadLine());

        string decryptedString = DecryptString(encryptedString, k);
        Console.WriteLine("Decrypted string: " + decryptedString);
    }

    static string DecryptString(string encryptedString, int k)
    {
        string decryptedString = "";
        foreach (char c in encryptedString)
        {
            if (char.IsLetter(c))
            {
                char decryptedChar = DecryptChar(c, k);
                decryptedString += decryptedChar;
            }
            else
            {
                decryptedString += c;
            }
        }
        return decryptedString;
    }

    static char DecryptChar(char c, int k)
    {
        char baseChar = char.IsUpper(c) ? 'A' : 'a';
        int offset = c - baseChar;
        int decryptedOffset = (offset - k + 26) % 26; // Applying the decryption formula
        char decryptedChar = (char)(baseChar + decryptedOffset);
        return decryptedChar;
    }
}
