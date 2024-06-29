using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose what you want to calculate:");
        Console.WriteLine("1. Distance");
        Console.WriteLine("2. Speed");
        Console.WriteLine("3. Time");

        int choice = GetChoice(1, 3);

        switch (choice)
        {
            case 1:
                CalculateDistance();
                break;
            case 2:
                CalculateSpeed();
                break;
            case 3:
                CalculateTime();
                break;
        }
    }

    static int GetChoice(int min, int max)
    {
        int choice;
        while (true)
        {
            Console.Write($"Enter your choice ({min}-{max}): ");
            if (int.TryParse(Console.ReadLine(), out choice) && choice >= min && choice <= max)
            {
                return choice;
            }
            Console.WriteLine("Invalid input. Please enter a valid choice.");
        }
    }

    static void CalculateDistance()
    {
        Console.Write("Enter speed (in km/h): ");
        double speed = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter time (in hours): ");
        double time = Convert.ToDouble(Console.ReadLine());

        double distance = speed * time;

        Console.WriteLine($"Distance = {distance} kilometers");
    }

    static void CalculateSpeed()
    {
        Console.Write("Enter distance (in kilometers): ");
        double distance = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter time (in hours): ");
        double time = Convert.ToDouble(Console.ReadLine());

        double speed = distance / time;

        Console.WriteLine($"Speed = {speed} km/h");
    }

    static void CalculateTime()
    {
        Console.Write("Enter distance (in kilometers): ");
        double distance = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter speed (in km/h): ");
        double speed = Convert.ToDouble(Console.ReadLine());

        double time = distance / speed;

        Console.WriteLine($"Time = {time} hours");
    }
}
