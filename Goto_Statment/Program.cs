using System;

class Program
{
    static void Main()
    {
        int counter = 0;

        start:
        counter++;
        Console.WriteLine("Counter: " + counter);

      
        if (counter < 5)
        {
            goto start;
        }

        Console.WriteLine("Exited the loop after 5 iterations.");
    }
}
