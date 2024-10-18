/* StringBuilder in C#

In C#, StringBuilder is a class from the System.Text namespace designed for efficient string manipulation, particularly when multiple modifications are required. It provides a mutable string, meaning its content can be changed without creating a new instance.

Why StringBuilder is Needed:

In C#, the string type is immutable, meaning once a string object is created, its value cannot be changed. Whenever you modify a string (e.g., by concatenating, removing, or replacing characters), a new string object is created in memory, leaving the old string object to be garbage collected. This constant creation of new string objects can lead to performance issues, especially in scenarios where a large number of string modifications are needed (e.g., loops, concatenations in algorithms).

StringBuilder addresses this by providing a way to modify strings in place, improving both memory efficiency and performance.

Why StringBuilder is Better than string in Certain Scenarios:

1. Immutability of string:

Since string objects are immutable, every time you modify a string (such as concatenating or appending), a new string object is created.
This process can be inefficient in scenarios where strings need to be modified frequently, as it leads to excessive memory allocation and garbage collection.

Example:

----------------------------------------------------------------------------
string str = "Hello";
str += " World";   // A new string object is created
----------------------------------------------------------------------------

2. Mutability of StringBuilder:

StringBuilder is mutable, meaning the content of the string can be changed without creating new objects.
Instead of creating a new object with every modification, StringBuilder modifies the existing string in memory.

Example:

----------------------------------------------------------------------------
StringBuilder sb = new StringBuilder("Hello");
sb.Append(" World");  // No new object is created; the existing one is modified
----------------------------------------------------------------------------

3. Performance:

StringBuilder is much more efficient when performing repeated string manipulations like concatenation, insertion, or replacement in loops.
It avoids the performance overhead of creating and garbage collecting multiple immutable string objects.

4. Memory Efficiency:

Since StringBuilder does not create multiple string instances during modification, it uses memory more efficiently compared to repeatedly concatenating strings using the + operator.

Key Properties and Methods of StringBuilder:

1. Append(): Adds a string (or other types) to the end of the StringBuilder.

----------------------------------------------------------------------------
StringBuilder sb = new StringBuilder("Hello");
sb.Append(" World");   // Result: "Hello World"
----------------------------------------------------------------------------

2. Insert(): Inserts a string at the specified index.

----------------------------------------------------------------------------
sb.Insert(5, " Beautiful");   // Result: "Hello Beautiful World"
----------------------------------------------------------------------------

3. Remove(): Removes a specified number of characters starting from a given index.

----------------------------------------------------------------------------
sb.Remove(5, 10);   // Removes " Beautiful" => Result: "Hello World"
----------------------------------------------------------------------------

4. Replace(): Replaces all occurrences of a specified substring with a new substring

----------------------------------------------------------------------------
sb.Replace("World", "C#");   // Result: "Hello C#"
----------------------------------------------------------------------------

5. ToString(): Converts the StringBuilder object back into a regular string.

----------------------------------------------------------------------------
string result = sb.ToString();   // Converts "Hello C#" to a string
----------------------------------------------------------------------------

6. Length Property: Returns or sets the length of the current StringBuilder object.

----------------------------------------------------------------------------
int length = sb.Length;  // Gets the length of the current string in `sb`
----------------------------------------------------------------------------

Performance Example: string vs StringBuilder

Using string (Inefficient):

----------------------------------------------------------------------------
string result = "";
for (int i = 0; i < 10000; i++)
{
    result += i.ToString();  // New string object is created in each iteration
}
----------------------------------------------------------------------------

In the above example, 10,000 new string objects are created, one for each iteration, because string is immutable. This results in high memory allocation and poor performance.

Using StringBuilder (Efficient):

----------------------------------------------------------------------------
StringBuilder sb = new StringBuilder();
for (int i = 0; i < 10000; i++)
{
    sb.Append(i.ToString());  // Modifies the existing StringBuilder object
}
----------------------------------------------------------------------------

Here, only one StringBuilder object is created and modified in place during the loop, making it much more efficient.

When to Use StringBuilder vs string:

Use string when you are working with fixed or few string modifications, such as simple concatenations or comparisons. For example:

Use StringBuilder when you need to modify or build strings dynamically, particularly in loops or scenarios where strings are modified frequently. 

For example:

----------------------------------------------------------------------------
StringBuilder sb = new StringBuilder();
for (int i = 0; i < 100; i++)
{
    sb.Append(i.ToString() + " ");
}

Code Example: Using StringBuilder

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
----------------------------------------------------------------------------

Output:

----------------------------------------------------------------------------
Hello World!
Hello Beautiful World!
Hello Amazing World!
Hello World!
Hello World!
----------------------------------------------------------------------------

Summary:

string: Immutable, every modification creates a new instance, which is inefficient for multiple modifications.

StringBuilder: Mutable, efficient for dynamic string manipulations with minimal memory usage and improved performance.

In scenarios where you need to modify a string multiple times (e.g., concatenating, inserting, or replacing), StringBuilder provides significant performance and memory management advantages over string.

*/