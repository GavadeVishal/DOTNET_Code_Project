using System;

class Program
{
    static void Main()
    {
        int number = 10;
        Console.WriteLine("Before calling PassByReference: " + number);
        
        PassByReference(ref number);
        
        Console.WriteLine("After calling PassByReference: " + number);
    }

    static void PassByReference(ref int num)
    {
        num = 20;
        Console.WriteLine("Inside PassByReference: " + num);
    }
}
