using System;

namespace MatrixOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int[,] matrix2 = {
                { 9, 8, 7 },
                { 6, 5, 4 },
                { 3, 2, 1 }
            };

            Console.WriteLine("Matrix 1:");
            PrintMatrix(matrix1);

            Console.WriteLine("Matrix 2:");
            PrintMatrix(matrix2);

            Console.WriteLine("Matrix Addition:");
            PrintMatrix(AddMatrices(matrix1, matrix2));

            Console.WriteLine("Matrix Subtraction:");
            PrintMatrix(SubtractMatrices(matrix1, matrix2));

            Console.WriteLine("Matrix Multiplication:");
            PrintMatrix(MultiplyMatrices(matrix1, matrix2));

            Console.WriteLine("Matrix Division:");
            PrintMatrix(DivideMatrices(matrix1, matrix2));

            Console.WriteLine("Matrix Modulus:");
            PrintMatrix(ModulusMatrices(matrix1, matrix2));
        }

        static int[,] AddMatrices(int[,] mat1, int[,] mat2)
        {
            int[,] result = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    result[i, j] = mat1[i, j] + mat2[i, j];
                }
            }

            return result;
        }

        static int[,] SubtractMatrices(int[,] mat1, int[,] mat2)
        {
            int[,] result = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    result[i, j] = mat1[i, j] - mat2[i, j];
                }
            }

            return result;
        }

        static int[,] MultiplyMatrices(int[,] mat1, int[,] mat2)
        {
            int[,] result = new int[3, 3];

            // Performing matrix multiplication
            result[0, 0] = mat1[0, 0] * mat2[0, 0] + mat1[0, 1] * mat2[1, 0] + mat1[0, 2] * mat2[2, 0];
            result[0, 1] = mat1[0, 0] * mat2[0, 1] + mat1[0, 1] * mat2[1, 1] + mat1[0, 2] * mat2[2, 1];
            result[0, 2] = mat1[0, 0] * mat2[0, 2] + mat1[0, 1] * mat2[1, 2] + mat1[0, 2] * mat2[2, 2];

            result[1, 0] = mat1[1, 0] * mat2[0, 0] + mat1[1, 1] * mat2[1, 0] + mat1[1, 2] * mat2[2, 0];
            result[1, 1] = mat1[1, 0] * mat2[0, 1] + mat1[1, 1] * mat2[1, 1] + mat1[1, 2] * mat2[2, 1];
            result[1, 2] = mat1[1, 0] * mat2[0, 2] + mat1[1, 1] * mat2[1, 2] + mat1[1, 2] * mat2[2, 2];

            result[2, 0] = mat1[2, 0] * mat2[0, 0] + mat1[2, 1] * mat2[1, 0] + mat1[2, 2] * mat2[2, 0];
            result[2, 1] = mat1[2, 0] * mat2[0, 1] + mat1[2, 1] * mat2[1, 1] + mat1[2, 2] * mat2[2, 1];
            result[2, 2] = mat1[2, 0] * mat2[0, 2] + mat1[2, 1] * mat2[1, 2] + mat1[2, 2] * mat2[2, 2];

            return result;
        }

        static int[,] DivideMatrices(int[,] mat1, int[,] mat2)
        {
            int[,] result = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (mat2[i, j] != 0)
                    {
                        result[i, j] = mat1[i, j] / mat2[i, j];
                    }
                    else
                    {
                        Console.WriteLine("Division by zero detected. Setting result to 0.");
                        result[i, j] = 0;
                    }
                }
            }

            return result;
        }

        static int[,] ModulusMatrices(int[,] mat1, int[,] mat2)
        {
            int[,] result = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (mat2[i, j] != 0)
                    {
                        result[i, j] = mat1[i, j] % mat2[i, j];
                    }
                    else
                    {
                        Console.WriteLine("Modulus by zero detected. Setting result to 0.");
                        result[i, j] = 0;
                    }
                }
            }

            return result;
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
