using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> names = new List<string> 
        { 
            "Vishal", "Getanjali", "Bharat", "Komal", "Samiksha" 
        };
        names.Sort();
        Console.WriteLine("Names in alphabetical order:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}
