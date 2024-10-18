using System;

class Program
{
    static void Main()
    {
        object obj = "This is a string";

        // Using "is" to check if obj is a string
        if (obj is string)
        {
            Console.WriteLine("obj is a string.");  // Output: obj is a string.
        }
        else
        {
            Console.WriteLine("obj is not a string.");
        }

        // Using "as" to cast obj to a string
        string str = obj as string;

        if (str != null)
        {
            Console.WriteLine("obj was successfully cast to a string using 'as'.");  // Output: obj was successfully cast to a string using 'as'.
            Console.WriteLine($"String value: {str}");  // Output: String value: This is a string
        }
        else
        {
            Console.WriteLine("obj could not be cast to a string using 'as'.");
        }

        // Trying "as" with an incompatible type
        obj = 123;  // Now obj is an integer
        string wrongStr = obj as string;  // This will return null since obj is not a string

        if (wrongStr == null)
        {
            Console.WriteLine("obj could not be cast to a string using 'as'.");  // Output: obj could not be cast to a string using 'as'.
        }
    }
}
