using System;

class Program
{
    static void Main()
    {
        string input = "HELLO WORLD";
        string lowerCase = ConvertToLowerCase(input);

        Console.WriteLine($"Original String: {input}");
        Console.WriteLine($"Converted to Lowercase: {lowerCase}");
    }

    static string ConvertToLowerCase(string input)
    {
        return input.ToLower();
    }
}
