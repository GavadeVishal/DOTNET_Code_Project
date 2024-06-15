using System;

class Program
{
    static int Pin = 123;
    static int balance = 700000000;

    static void Main(string[] args)
    {
        Console.WriteLine("---------- SBI-ATM ----------");

        if (!VerifyPin())
        {
            Console.WriteLine("Incorrect PIN. Exiting...");
            return;
        }

        Console.WriteLine("----------------------------------");

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Choose your option \n 1 : CHECK BALANCE \n 2 : CASH DEPOSIT \n 3: CASH WITHDRAW \n 4: QUIT \n ------------------------------");
            Console.Write("Enter your request: ");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("CHECK BALANCE");
                    Console.WriteLine($"Your current balance is: {balance} rs");
                    break;
                case 2:
                    Console.WriteLine("CASH DEPOSIT");
                    Console.WriteLine("Enter the amount you want to DEPOSIT");
                    int dep = Convert.ToInt32(Console.ReadLine());
                    balance += dep;
                    Console.WriteLine($"Your updated balance is {balance} rs");
                    break;
                case 3:
                    Console.WriteLine("CASH WITHDRAW");
                    Console.WriteLine("Enter the amount you want to WITHDRAW");
                    int withdraw = Convert.ToInt32(Console.ReadLine());
                    balance -= withdraw;
                    Console.WriteLine($"Your updated balance is {balance} rs");
                    break;
                case 4:
                    Console.WriteLine("Quit");
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Enter a valid option");
                    break;
            }

            Console.WriteLine("----------------------------------");
        }
    }

    static bool VerifyPin()
    {
        Console.Write("Enter Your Pin: ");
        int enteredPin = Convert.ToInt32(Console.ReadLine());

        if (enteredPin == Pin)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}