/* Anonymous functions

In C#, anonymous functions are functions that are defined inline without a name. They are commonly used for short-lived functionality, often passed as arguments to methods or stored in variables. In the context of delegates, anonymous functions provide a way to define behavior inline without explicitly defining a separate method.

There are two main types of anonymous functions in C#: anonymous methods and lambda expressions. However, we'll focus on anonymous methods in this explanation using the delegate keyword, as requested.

1. Passing Anonymous Function by Reference Using the delegate Keyword

In this case, we create an anonymous function and assign it to a delegate, essentially passing a reference to the function.

Example:

-------------------------------------------------------
using System;

class Program
{
    // Define a delegate
    delegate void PrintDelegate(string message);

    static void Main()
    {
        // Create an anonymous function and assign it to the delegate
        PrintDelegate print = delegate(string msg)
        {
            Console.WriteLine(msg);
        };

        // Now the delegate holds a reference to the anonymous function
        print("Hello from anonymous function!"); // Invoking the delegate
    }
}
-------------------------------------------------------

Explanation:

We define a delegate PrintDelegate that takes a string parameter.

We assign an anonymous method using the delegate keyword to print. The anonymous method takes a string argument and prints it.

We invoke print like a method by passing a string argument, which triggers the anonymous function.

2. Creating and Invoking an Anonymous Function Inline (Without Explicit Reference)

In this approach, we pass the anonymous function directly as an argument without assigning it to a delegate variable first. This is useful when the function is only needed in that specific context.

Example:

-------------------------------------------------------
using System;

class Program
{
    // Define a method that accepts a delegate as a parameter
    static void Execute(PrintDelegate printDelegate)
    {
        printDelegate("Hello from inline anonymous function!");
    }

    // Define a delegate
    delegate void PrintDelegate(string message);

    static void Main()
    {
        // Pass an anonymous function directly to the method
        Execute(delegate(string msg)
        {
            Console.WriteLine(msg);
        });
    }
}
-------------------------------------------------------

Explanation:

We define a method Execute that takes a delegate PrintDelegate as a parameter.

Instead of assigning the anonymous method to a delegate first, we pass it directly as an argument when calling Execute.

The method Execute calls the delegate with the string "Hello from inline anonymous function!", which is printed by the anonymous method.

Key Differences:

Passing by Reference: The first example stores the anonymous method in a delegate variable (print) and invokes it later.

Inline Execution: The second example passes the anonymous method directly to the Execute method, avoiding the need to store the function in a variable.

Use Cases:

Passing by Reference: Useful when the same anonymous function needs to be reused multiple times.

Inline: Ideal for one-time use when the anonymous function is needed only in a specific context.

Both approaches allow concise function definition and reduce boilerplate code in scenarios where creating a separate method would be overkill.

Limitations:

It cannot contain jump statements like goto, break or continue

It cannot access ref or out parameter of an outer method

*/