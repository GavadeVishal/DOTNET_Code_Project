using System;     
class swap {   
public static void Main()   
    {   
        Console.WriteLine("Enter the value of x and y");  
        int x=Convert.ToInt32(Console.ReadLine());  
        int y = Convert.ToInt32(Console.ReadLine());  
        Console.WriteLine("before swapping numbers: "+x +"  "+ y);  
            
        x = x + y;   
        y = x - y;   
        x = x - y;   
        Console.WriteLine("After swapping: "+x +"   " + y);   
          
    }   
}  
