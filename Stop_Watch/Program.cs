using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
  
        Stopwatch stopwatch = new Stopwatch();

        Console.WriteLine("Press 'Enter' to start the stopwatch.");
        Console.ReadLine();

        stopwatch.Start();

        Console.WriteLine("Stopwatch is running. Press 'Enter' to stop.");
        Console.ReadLine();

        stopwatch.Stop();

        TimeSpan elapsedTime = stopwatch.Elapsed;

        Console.WriteLine($"Elapsed Time: {elapsedTime.Hours:00}:{elapsedTime.Minutes:00}:{elapsedTime.Seconds:00}.{elapsedTime.Milliseconds / 10:00}");
    }
}
