using System;
using System.Collections.Generic;

namespace HotelManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter Customer Name:");
            string customerName = Console.ReadLine();

            Console.WriteLine("Enter Table Number:");
            int tableNumber = int.Parse(Console.ReadLine());

            
            string currentDate = DateTime.Now.ToString("dd-MM-yyyy");
            string currentTime = DateTime.Now.ToString("HH:mm:ss");

            
            string hotelName = "DOTNET Hotel";
            string gstNumber = "GST123456789";

            
            var menu = new Dictionary<string, decimal>
            {
                { "Salad", 50 },
                { "Soup", 30 },
                { "Steak", 200 },
                { "Pasta", 120 },
                { "Dessert", 60 }
            };

           
            var order = new Dictionary<string, int>();
            string input;
            do
            {
                Console.WriteLine("Enter Menu Item (or 'done' to finish):");
                input = Console.ReadLine();
                if (input.ToLower() != "done" && menu.ContainsKey(input))
                {
                    Console.WriteLine("Enter Quantity:");
                    int quantity = int.Parse(Console.ReadLine());

                    if (order.ContainsKey(input))
                    {
                        order[input] += quantity;
                    }
                    else
                    {
                        order[input] = quantity;
                    }
                }
                else if (input.ToLower() != "done")
                {
                    Console.WriteLine("Invalid menu item.");
                }
            }
            while (input.ToLower() != "done");

            
            decimal totalBill = CalculateTotalBill(order, menu);
            decimal gstAmount = totalBill * 0.18m;
            decimal finalBill = totalBill + gstAmount;

            
            PrintBill(hotelName, currentDate, currentTime, gstNumber, customerName, tableNumber, order, menu, totalBill, gstAmount, finalBill);
        }

        static decimal CalculateTotalBill(Dictionary<string, int> order, Dictionary<string, decimal> menu)
        {
            decimal total = 0;
            foreach (var item in order)
            {
                total += item.Value * menu[item.Key];
            }
            return total;
        }

        static void PrintBill(string hotelName, string currentDate, string currentTime, string gstNumber, string customerName, int tableNumber, Dictionary<string, int> order, Dictionary<string, decimal> menu, decimal totalBill, decimal gstAmount, decimal finalBill)
        {
            Console.WriteLine("\n------------------------------------------");
            Console.WriteLine($"              {hotelName}              ");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Date: {currentDate}          Time: {currentTime}");
            Console.WriteLine($"GST No: {gstNumber}");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Customer Name: {customerName}");
            Console.WriteLine($"Table Number: {tableNumber}");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("{0,-15} {1,5} {2,10} {3,10}", "Item Name", "Qty", "Rs", "Total");
            Console.WriteLine("------------------------------------------");

            foreach (var item in order)
            {
                string itemName = item.Key;
                int quantity = item.Value;
                decimal price = menu[itemName];
                decimal total = quantity * price;
                Console.WriteLine("{0,-15} {1,5} {2,10:C} {3,10:C}", itemName, quantity, price, total);
            }

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("{0,-20} {1,20:C}", "Total (without GST):", totalBill);
            Console.WriteLine("{0,-20} {1,20:C}", "GST @ 18%:", gstAmount);
            Console.WriteLine("{0,-20} {1,20:C}", "Total Bill (with GST):", finalBill);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Thank you! Visit again!");
            Console.WriteLine("------------------------------------------");
        }
    }
}
