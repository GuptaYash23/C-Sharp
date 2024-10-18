/* Params Keyword in C#

The params keyword in C# allows a method to accept a variable number of arguments as a parameter array. It provides flexibility to pass zero or more arguments of the specified type to a method, which can simplify method calls when the number of arguments is not known at compile time.

Key Features of params Keyword:

Single params Parameter: A method can only have one params parameter, and it must be the last parameter in the method signature.

Type-Specific: The params array must be of a specific type (e.g., int[], string[]), meaning all elements passed to the method must match the type.

Optional: You can call the method with zero, one, or multiple arguments. If no arguments are passed, the method receives an empty array.

Syntax:

----------------------------------------------------------------------------------
public void MethodName(params Type[] parameterName)
{
    // Method logic
}
----------------------------------------------------------------------------------

Type[] is the array type (e.g., int[], string[]).

parameterName is the name of the parameter that will hold the array.

Example 1: Method with params:

----------------------------------------------------------------------------------
public class Example
{
    public void PrintNumbers(params int[] numbers)
    {
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Example ex = new Example();

        ex.PrintNumbers(1, 2, 3, 4, 5);   // Passing multiple values
        ex.PrintNumbers();                // No values passed (empty array)
    }
}
----------------------------------------------------------------------------------

Output:

----------------------------------------------------------------------------------
1
2
3
4
5
----------------------------------------------------------------------------------

If no arguments are passed, the method handles an empty array without causing an error.

How params Works:

Multiple Arguments: When you pass several arguments, the compiler treats them as an array and passes it to the method.

No Arguments: If no arguments are provided, an empty array is passed to the method.

Passing an Array: You can also pass an array directly.

Example 2: Passing an Array:

----------------------------------------------------------------------------------
class Program
{
    static void Main(string[] args)
    {
        int[] numbersArray = { 10, 20, 30 };
        
        Example ex = new Example();
        ex.PrintNumbers(numbersArray);   // Passing an array directly
    }
}
----------------------------------------------------------------------------------

Combining params with Other Parameters:

The params keyword can be combined with other parameters in a method. However, it must always be the last parameter.

----------------------------------------------------------------------------------
public void PrintDetails(string message, params int[] numbers)
{
    Console.WriteLine(message);
    foreach (var num in numbers)
    {
        Console.WriteLine(num);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Example ex = new Example();
        
        // First argument is string, followed by multiple integers
        ex.PrintDetails("Numbers List:", 1, 2, 3, 4, 5); 
    }
}
----------------------------------------------------------------------------------

Output:

----------------------------------------------------------------------------------
Numbers List:
1
2
3
4
5
----------------------------------------------------------------------------------

Limitations of params:

Only One params Parameter: A method cannot have more than one params parameter.

Must Be Last: The params parameter must be the last parameter in the method signature. Any additional parameters must precede it.

Example of Invalid Use:

----------------------------------------------------------------------------------
public void InvalidMethod(params int[] numbers, string message) // Not allowed, params must be the last parameter
{
}
----------------------------------------------------------------------------------

Using params with Other Data Types:

You can use params with other data types, such as string[], double[], or custom objects.

Example: Using params with Strings:

----------------------------------------------------------------------------------
public void PrintNames(params string[] names)
{
    foreach (var name in names)
    {
        Console.WriteLine(name);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Example ex = new Example();

        ex.PrintNames("John", "Alice", "Bob");  // Passing multiple strings
    }
}
----------------------------------------------------------------------------------

Output:

----------------------------------------------------------------------------------
John
Alice
Bob
----------------------------------------------------------------------------------

Best Practices:

Avoid Overuse: Using params can lead to potential performance issues when dealing with large datasets, as arrays are created implicitly. Use it only when necessary.

Clear Documentation: When using params, document the method clearly to specify that it accepts a variable number of arguments.

Conclusion:

The params keyword in C# allows methods to handle a variable number of arguments in a clean and efficient way. It is useful for scenarios where you don’t know the exact number of arguments at compile time, providing flexibility in method calls.
*/

