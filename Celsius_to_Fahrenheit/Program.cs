using System;

class Program
{
    static void Main()
    {
        
        double celsius = 25.0;


        double fahrenheit = ConvertCelsiusToFahrenheit(celsius);

    
        Console.WriteLine($"{celsius} degrees Celsius is equal to {fahrenheit} degrees Fahrenheit.");
    }

    static double ConvertCelsiusToFahrenheit(double celsius)
    {
    
        double fahrenheit = (celsius * 9 / 5) + 32;
        return fahrenheit;
    }
}
