using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Calculate Simple Interest");

        Console.Write("Enter Principal Amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate of Interest (in percent): ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Time Period (in years): ");
        double time = Convert.ToDouble(Console.ReadLine());

        double simpleInterest = (principal * rate * time) / 100;

        Console.WriteLine($"Simple Interest = {simpleInterest}");

        double totalAmount = principal + simpleInterest;
        Console.WriteLine($"Total Amount (Principal + Interest) = {totalAmount}");
    }
}
