using System;

class Program
{
    static void Main()
    {
        int number = 10;
        Console.WriteLine("Before calling PassByValue: " + number);
        
        PassByValue(number);
        
        Console.WriteLine("After calling PassByValue: " + number);
    }

    static void PassByValue(int num)
    {
        num = 20;
        Console.WriteLine("Inside PassByValue: " + num);
    }
}
