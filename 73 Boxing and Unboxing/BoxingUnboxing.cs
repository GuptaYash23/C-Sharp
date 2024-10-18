using System;

namespace ConsoleApp
{
   public class Program
{
    static void Main()
    {
        // Boxing: Converting a value type to a reference type
        int value = 100;     // Value type (stack)
        object boxedValue = value;   // Boxing (heap)
        
        Console.WriteLine($"Boxed value: {boxedValue}");  // Output: Boxed value: 100
        
        // Unboxing: Converting back to a value type
        int unboxedValue = (int)boxedValue;   // Unboxing
        Console.WriteLine($"Unboxed value: {unboxedValue}");  // Output: Unboxed value: 100
    }
}

}