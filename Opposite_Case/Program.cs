using System;

class Program
{
    static void Main()
    {
        string input = "Hello World 123";
        string oppositeCase = ConvertToOppositeCase(input);

        Console.WriteLine($"Original String: {input}");
        Console.WriteLine($"Converted to Opposite Case: {oppositeCase}");
    }

    static string ConvertToOppositeCase(string input)
    {
        char[] chars = input.ToCharArray();

        for (int i = 0; i < chars.Length; i++)
        {
            if (char.IsLower(chars[i]))
            {
                chars[i] = char.ToUpper(chars[i]);
            }
            else if (char.IsUpper(chars[i]))
            {
                chars[i] = char.ToLower(chars[i]);
            }
            
        }

        return new string(chars);
    }
}
