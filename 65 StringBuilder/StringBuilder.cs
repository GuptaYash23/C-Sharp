using System;
using System.Text;

class Program
{
    static void Main()
    {
        // Create a new StringBuilder object
        StringBuilder sb = new StringBuilder("Hello");

        // Append a string to the StringBuilder
        sb.Append(" World!");
        Console.WriteLine(sb);   // Output: Hello World!

        // Insert a string at a specific position
        sb.Insert(6, "Beautiful ");
        Console.WriteLine(sb);   // Output: Hello Beautiful World!

        // Replace a substring
        sb.Replace("Beautiful", "Amazing");
        Console.WriteLine(sb);   // Output: Hello Amazing World!

        // Remove a portion of the string
        sb.Remove(6, 8);
        Console.WriteLine(sb);   // Output: Hello World!

        // Convert the StringBuilder object to a string
        string finalString = sb.ToString();
        Console.WriteLine(finalString);  // Output: Hello World!
    }
}
