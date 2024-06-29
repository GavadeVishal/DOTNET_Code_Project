using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<string, string> phoneBook = new Dictionary<string, string>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nPhone Book Menu:");
            Console.WriteLine("1. Add a Contact");
            Console.WriteLine("2. Find a Contact");
            Console.WriteLine("3. Display All Contacts");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddContact();
                    break;
                case 2:
                    FindContact();
                    break;
                case 3:
                    DisplayContacts();
                    break;
                case 4:
                    Console.WriteLine("Exiting Phone Book. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        }
    }

    static void AddContact()
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine().Trim();

        if (phoneBook.ContainsKey(name))
        {
            Console.WriteLine($"Contact '{name}' already exists.");
            return;
        }

        Console.Write("Enter phone number: ");
        string phoneNumber = Console.ReadLine().Trim();

        phoneBook[name] = phoneNumber;
        Console.WriteLine($"Contact '{name}' added successfully.");
    }

    static void FindContact()
    {
        Console.Write("Enter name to find: ");
        string name = Console.ReadLine().Trim();

        if (phoneBook.TryGetValue(name, out string phoneNumber))
        {
            Console.WriteLine($"Contact found - Name: {name}, Phone Number: {phoneNumber}");
        }
        else
        {
            Console.WriteLine($"Contact '{name}' not found.");
        }
    }

    static void DisplayContacts()
    {
        if (phoneBook.Count == 0)
        {
            Console.WriteLine("Phone book is empty.");
            return;
        }

        Console.WriteLine("Phone Book Contacts:");
        foreach (var contact in phoneBook)
        {
            Console.WriteLine($"Name: {contact.Key}, Phone Number: {contact.Value}");
        }
    }
}
