using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the distance to convert:");
        Console.Write("Distance: ");
        double distance = Convert.ToDouble(Console.ReadLine());

        double kilometers = ConvertMeterToKilometer(distance);
        Console.WriteLine($"{distance} meters is equal to {kilometers} kilometers.");

        double meters = ConvertKilometerToMeter(distance);
        Console.WriteLine($"{distance} kilometers is equal to {meters} meters.");
    }

    static double ConvertMeterToKilometer(double meters)
    {
        return meters / 1000.0;
    }

    static double ConvertKilometerToMeter(double kilometers)
    {
        return kilometers * 1000.0;
    }
}
