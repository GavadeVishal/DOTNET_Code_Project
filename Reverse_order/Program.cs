using System;

namespace ReverseOrderWithArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i]);
            }

            Console.ReadLine();
        }
    }
}
