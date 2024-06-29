using System;

class Program
{
    static void Main()
    {
     
        int valueType = 10;
        Console.WriteLine("Before ModifyValueType: " + valueType);
        ModifyValueType(valueType);
        Console.WriteLine("After ModifyValueType: " + valueType);

        
        int[] referenceType = { 1, 2, 3 };
        Console.WriteLine("\nBefore ModifyReferenceType: " + string.Join(", ", referenceType));
        ModifyReferenceType(referenceType);
        Console.WriteLine("After ModifyReferenceType: " + string.Join(", ", referenceType));
    }

    static void ModifyValueType(int num)
    {
        num = 20;
        Console.WriteLine("Inside ModifyValueType: " + num);
    }

    static void ModifyReferenceType(int[] arr)
    {
        arr[0] = 10;
        Console.WriteLine("Inside ModifyReferenceType: " + string.Join(", ", arr));
    }
}
