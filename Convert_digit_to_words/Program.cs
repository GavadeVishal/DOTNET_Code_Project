using System;

class Program
{

    static string[] onesAndTeens = {
        "Zero", "One", "Two", "Three", "Four",
        "Five", "Six", "Seven", "Eight", "Nine",
        "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen",
        "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"
    };

    static string[] tens = {
        "", "", "Twenty", "Thirty", "Forty",
        "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"
    };

    static void Main()
    {
        Console.WriteLine("Enter a number (up to 9999):");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 0 || number > 9999)
        {
            Console.WriteLine("Number out of range. Please enter a number between 0 and 9999.");
            return;
        }

        string words = ConvertNumberToWords(number);
        Console.WriteLine($"Number in words: {words}");
    }

    static string ConvertNumberToWords(int number)
    {
        if (number < 20)
        {
            return onesAndTeens[number];
        }
        else if (number < 100)
        {
            int tensDigit = number / 10;
            int onesDigit = number % 10;
            return $"{tens[tensDigit]} {onesAndTeens[onesDigit]}".Trim();
        }
        else if (number < 1000)
        {
            int hundredsDigit = number / 100;
            int remainingDigits = number % 100;
            return $"{onesAndTeens[hundredsDigit]} Hundred {ConvertNumberToWords(remainingDigits)}".Trim();
        }
        else 
        {
            int thousandsDigit = number / 1000;
            int remainingDigits = number % 1000;
            return $"{onesAndTeens[thousandsDigit]} Thousand {ConvertNumberToWords(remainingDigits)}".Trim();
        }
    }
}
