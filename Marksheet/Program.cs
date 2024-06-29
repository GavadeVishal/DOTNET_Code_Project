using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter student details:");
        Console.Write("Name: ");
        string name = Console.ReadLine().Trim();

        Console.Write("Roll Number: ");
        string rollNumber = Console.ReadLine().Trim();

     
        Console.WriteLine("\nEnter marks for each subject (out of 100):");
        int[] marks = new int[5];
        string[] subjects = { "Subject 1", "Subject 2", "Subject 3", "Subject 4", "Subject 5" };

        for (int i = 0; i < marks.Length; i++)
        {
            Console.Write($"{subjects[i]}: ");
            marks[i] = Convert.ToInt32(Console.ReadLine());
        }

      
        int totalMarks = 0;
        foreach (int mark in marks)
        {
            totalMarks += mark;
        }

       
        double percentage = (double)totalMarks / marks.Length;

       
        string grade = CalculateGrade(percentage);

        Console.WriteLine("\n************ Marksheet ************");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Roll Number: {rollNumber}");
        Console.WriteLine("Marks:");

        for (int i = 0; i < marks.Length; i++)
        {
            Console.WriteLine($"{subjects[i]}: {marks[i]}");
        }

        Console.WriteLine($"Total Marks: {totalMarks}");
        Console.WriteLine($"Percentage: {percentage:F2}%");
        Console.WriteLine($"Grade: {grade}");
    }

    static string CalculateGrade(double percentage)
    {
        if (percentage >= 90)
            return "A+";
        else if (percentage >= 80)
            return "A";
        else if (percentage >= 70)
            return "B";
        else if (percentage >= 60)
            return "C";
        else if (percentage >= 50)
            return "D";
        else
            return "Fail";
    }
}
