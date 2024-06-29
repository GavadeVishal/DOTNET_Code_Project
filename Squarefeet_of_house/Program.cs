using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Calculate Square Feet of a House");

        double length = GetDimension("length");
        double width = GetDimension("width");
        double areaSquareFeet = CalculateArea(length, width);

        Console.WriteLine($"The area of the house is {areaSquareFeet} square feet.");
    }

    static double GetDimension(string dimensionName)
    {
        Console.Write($"Enter the {dimensionName} of the house in feet: ");
        double dimension = Convert.ToDouble(Console.ReadLine());
        return dimension;
    }

    static double CalculateArea(double length, double width)
    {

        return length * width;
    }
}
