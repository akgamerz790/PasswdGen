using System;
using System.Text;

class PasswordGenerator
{
    static void Main()
    {
        // Prompt for password length
        Console.Write("Enter total password length (min 10): ");
        if (!int.TryParse(Console.ReadLine(), out int totalLength) || totalLength < 10)
        {
            Console.WriteLine("Invalid length.");
            return;
        }

        // Ask for base keyword
        Console.Write("Enter base keyword (default: akgamerz_790): ");
        string inputKeyword = Console.ReadLine();
        string baseKeyword = !string.IsNullOrWhiteSpace(inputKeyword) ? inputKeyword : "akgamerz_790";

        Random rand = new Random();

        // Random replacement in base keyword
        StringBuilder keywordBuilder = new StringBuilder();
        foreach (char c in baseKeyword)
        {
            if ((c == 'S' || c == 's') && rand.Next(2) == 0)
                keywordBuilder.Append('$');
            else if ((c == 'a' || c == 'A') && rand.Next(2) == 0)
                keywordBuilder.Append('@');
            else
                keywordBuilder.Append(c);
        }
        string processedKeyword = keywordBuilder.ToString();

        // Generate random characters
        string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*";
        int remainingLength = totalLength - processedKeyword.Length;
        if (remainingLength < 0)
        {
            Console.WriteLine("Base keyword is longer than requested password length.");
            return;
        }

        StringBuilder randomPart = new StringBuilder();
        for (int i = 0; i < remainingLength; i++)
        {
            randomPart.Append(chars[rand.Next(chars.Length)]);
        }

        // Insert processed keyword at a random position
        int insertPos = rand.Next(randomPart.Length + 1);
        randomPart.Insert(insertPos, processedKeyword);

        Console.WriteLine("\nGenerated Password: " + randomPart.ToString());
    }
}