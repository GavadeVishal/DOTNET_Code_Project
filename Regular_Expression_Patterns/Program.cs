using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "The quick brown fox jumps over the lazy dog. Contact us at example@example.com or visit https://www.example.com.";
        
        
        string emailPattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";
       
        string urlPattern = @"https?://[a-zA-Z0-9./-]+";
       
        string wordPattern = @"\b\w+\b";
        
      
        Console.WriteLine("Email Addresses:");
        foreach (Match match in Regex.Matches(input, emailPattern))
        {
            Console.WriteLine(match.Value);
        }
        
  
        Console.WriteLine("\nURLs:");
        foreach (Match match in Regex.Matches(input, urlPattern))
        {
            Console.WriteLine(match.Value);
        }
        

        Console.WriteLine("\nWords:");
        foreach (Match match in Regex.Matches(input, wordPattern))
        {
            Console.WriteLine(match.Value);
        }
    }
}
