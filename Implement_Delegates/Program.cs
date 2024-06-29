using System;
delegate void Operation(int x, int y);

class Program
{
    static void Main()
    {

        Operation operation = AddNumbers;

        operation(5, 3); 

        operation = MultiplyNumbers;

        operation(5, 3); 
    }

    static void AddNumbers(int x, int y)
    {
        int result = x + y;
        Console.WriteLine($"{x} + {y} = {result}");
    }

    static void MultiplyNumbers(int x, int y)
    {
        int result = x * y;
        Console.WriteLine($"{x} * {y} = {result}");
    }
}
