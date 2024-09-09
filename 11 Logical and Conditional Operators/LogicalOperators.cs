using System;

class Program
{
    static void Main()
    {
        // Logical Operators
        int x = 10;
        int y = 20;
        
        bool isXGreaterThanY = x > y; // False
        bool isXLessThanY = x < y;    // True
        bool isEqual = (x == y);      // False

        // Using AND (&&) operator
        bool andResult = isXGreaterThanY && isXLessThanY; // False (both conditions are not True)

        // Using OR (||) operator
        bool orResult = isXGreaterThanY || isXLessThanY;  // True (at least one condition is True)

        // Using NOT (!) operator
        bool notResult = !isEqual; // True (isEqual is False)

        Console.WriteLine($"AND Result: {andResult}");   // False
        Console.WriteLine($"OR Result: {orResult}");     // True
        Console.WriteLine($"NOT Result: {notResult}");   // True

        // Conditional Operators
        // Ternary Conditional Operator
        string max = (x > y) ? x.ToString() : y.ToString();  // "20" (y is greater than x)
        
        // Null-Coalescing Operator
        string userName = null;
        string displayName = userName ?? "Guest"; // "Guest" (userName is null)

        // Null-Coalescing Assignment Operator
        string firstName = null;
        firstName ??= "John"; // firstName is assigned "John" because it was null

        Console.WriteLine($"Max value: {max}");            // 20
        Console.WriteLine($"Display Name: {displayName}"); // Guest
        Console.WriteLine($"First Name: {firstName}");     // John

        // Combined Example
        int age = 17;
        string ageStatus = (age >= 18) ? "Adult" : "Minor";
        Console.WriteLine($"Age Status: {ageStatus}"); // "Minor" (age is less than 18)

        Console.ReadLine();
    }
}
