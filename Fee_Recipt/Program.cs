using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Enter Student Name: ");
        string studentName = Console.ReadLine();

        Console.Write("Enter UIT Number: ");
        string uitNumber = Console.ReadLine();

        Console.Write("Enter Branch: ");
        string branch = Console.ReadLine();

        Console.Write("Enter Year/Semester: ");
        string yearSemester = Console.ReadLine();

        string currentDate = DateTime.Now.ToString("dd/MM/yyyy");
        string currentTime = DateTime.Now.ToString("HH:mm:ss");

        
        Console.Write("Enter Entrance Fee: ");
        double entranceFee = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Exam Fee: ");
        double examFee = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Library Fee: ");
        double libraryFee = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Hostel Fee: ");
        double hostelFee = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Laboratory Fee: ");
        double laboratoryFee = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Projects Fee: ");
        double projectsFee = Convert.ToDouble(Console.ReadLine());

        
        double totalFee = entranceFee + examFee + libraryFee + hostelFee + laboratoryFee + projectsFee;
        double gst = totalFee * 0.18;
        double grandTotal = totalFee + gst;

        
        Console.WriteLine("\n\n==============================================");
        Console.WriteLine("        SANJIVANI COLLEGE OF ENGINEERING       ");
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("            Academic Fee Receipt               ");
        Console.WriteLine("==============================================");
        Console.WriteLine($"Student Name: {studentName}");
        Console.WriteLine($"UIT Number: {uitNumber}");
        Console.WriteLine($"Branch: {branch}");
        Console.WriteLine($"Year/Semester: {yearSemester}");
        Console.WriteLine($"Date: {currentDate}");
        Console.WriteLine($"Time: {currentTime}");
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine($"{"Entrance Fee-",-25} Rs. {entranceFee,10:F2}");
        Console.WriteLine($"{"Exam Fee-",-25} Rs. {examFee,10:F2}");
        Console.WriteLine($"{"Library Fee-",-25} Rs. {libraryFee,10:F2}");
        Console.WriteLine($"{"Hostel Fee-",-25} Rs. {hostelFee,10:F2}");
        Console.WriteLine($"{"Laboratory Fee-",-25} Rs. {laboratoryFee,10:F2}");
        Console.WriteLine($"{"Projects Fee-",-25} Rs. {projectsFee,10:F2}");
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine($"{"Total Fee-",-25} Rs. {totalFee,10:F2}");
        Console.WriteLine($"{"GST (18%)-",-25} Rs. {gst,10:F2}");
        Console.WriteLine($"{"Grand Total-",-25} Rs. {grandTotal,10:F2}");

    }
}
