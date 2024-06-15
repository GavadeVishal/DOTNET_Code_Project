using System;  
class Program {  
    static void Main() {  
     
        bool isPrime = true;  
        int i, j;  
        
        Console.WriteLine("Prime Numbers are : ");  
        for (i = 2; i <= 100; i++) {  
            for (j = 2; j <= 100; j++) {  
                if (i != j && i % j == 0) {  
                    isPrime = false;  
                    break;  
                }  
            }  
            if (isPrime) {  
                Console.Write("\t" + i);  
            }  
            isPrime = true;  
        }  
        Console.ReadKey();  
    }  
} 
