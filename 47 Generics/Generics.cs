using System;

class Program
{
    // Generic method to swap two values
    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }

    static void Main()
    {
        // Example with integers
        int x = 5;
        int y = 10;
        Console.WriteLine($"Before Swap: x = {x}, y = {y}");
        Swap(ref x, ref y);
        Console.WriteLine($"After Swap: x = {x}, y = {y}");

        // Example with strings
        string str1 = "Hello";
        string str2 = "World";
        Console.WriteLine($"Before Swap: str1 = {str1}, str2 = {str2}");
        Swap(ref str1, ref str2);
        Console.WriteLine($"After Swap: str1 = {str1}, str2 = {str2}");
    }
}


/* ref keyword

In C#, the ref keyword is used to indicate that a parameter is passed by reference rather than by value. When a parameter is passed by reference, any changes made to the parameter inside the method will affect the original variable that was passed in. This allows for the method to modify the value of the argument directly, rather than working with a copy of the value. To use the ref keyword, both the method definition and the method call must explicitly specify ref, ensuring that the caller is aware that the argument may be modified. This is particularly useful for scenarios where you want to return multiple values from a method or when working with large data structures to avoid the overhead of copying.

*/
