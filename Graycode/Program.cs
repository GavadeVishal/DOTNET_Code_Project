using System;

class Program
{
    static void Main()
    {
        int n = 3; 
        int[] grayCode = GenerateGrayCode(n);

        Console.WriteLine($"Gray code sequence for {n} bits:");

        foreach (int num in grayCode)
        {
            string binary = Convert.ToString(num, 2).PadLeft(n, '0');
            Console.WriteLine($"{num}: {binary}");
        }
    }

    static int[] GenerateGrayCode(int n)
    {
        if (n <= 0)
        {
            throw new ArgumentException("Number of bits must be greater than zero.");
        }

        int[] grayCode = new int[(int)Math.Pow(2, n)];
        grayCode[0] = 0;

        for (int i = 1; i < grayCode.Length; i++)
        {
           
            grayCode[i] = i ^ (i >> 1);
        }

        return grayCode;
    }
}
