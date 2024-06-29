using System;

class Program
{
    static void Main()
    {
        int[,] matrix = {
            { 3, 7, 1 },
            { 4, 2, 9 },
            { 5, 8, 6 }
        };

        int smallest = FindSmallestElement(matrix);

        Console.WriteLine($"The smallest element in the matrix is: {smallest}");
    }

    static int FindSmallestElement(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int smallest = matrix[0, 0];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] < smallest)
                {
                    smallest = matrix[i, j];
                }
            }
        }

        return smallest;
    }
}
