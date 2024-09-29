/* delegate keyword

In C#, a delegate is a type that represents references to methods with a specific signature. Delegates are similar to function pointers in C++ but are type-safe and secure. They allow methods to be passed as parameters, making them useful for implementing callbacks, event handling, and designing extensible and flexible applications.

Key Features of Delegates:

A delegate holds references to methods that match its signature (return type and parameters).

Delegates are type-safe, meaning only methods with a matching signature can be assigned to them.

Delegates support multicast, meaning one delegate instance can point to multiple methods.

Delegates enable asynchronous programming by invoking methods asynchronously.

You need not specify the return type in an anonymous method, it is inferred from the return statement inside the method body.

Syntax:

To declare a delegate, you use the delegate keyword followed by a method signature.

--------------------------------------------------------------------------------------------------------
delegate return_type DelegateName(parameter_list);
--------------------------------------------------------------------------------------------------------

For example:

--------------------------------------------------------------------------------------------------------
public delegate void MyDelegate(string message);
--------------------------------------------------------------------------------------------------------

This defines a delegate type called MyDelegate, which can reference any method that returns void and accepts a single string parameter.

Declaring and Using Delegates:

Step 1: Declare a Delegate You first declare a delegate type that specifies the method signature.

--------------------------------------------------------------------------------------------------------
public delegate void PrintDelegate(string message);
--------------------------------------------------------------------------------------------------------

Step 2: Define a Method Matching the Delegate's Signature Define a method that matches the signature of the declared delegate.

--------------------------------------------------------------------------------------------------------
public void PrintMessage(string message) {
    Console.WriteLine(message);
}
--------------------------------------------------------------------------------------------------------

Step 3: Instantiate the Delegate Create an instance of the delegate and assign it to the method.

--------------------------------------------------------------------------------------------------------
PrintDelegate print = PrintMessage;
--------------------------------------------------------------------------------------------------------

Step 4: Invoke the Delegate Call the delegate just like a regular method. It will invoke the method it references.

--------------------------------------------------------------------------------------------------------
print("Hello, World!");  // Output: Hello, World!
--------------------------------------------------------------------------------------------------------

Example:

--------------------------------------------------------------------------------------------------------
using System;

public class Program
{
    // Step 1: Declare the delegate
    public delegate void PrintDelegate(string message);

    // Step 2: Define a method matching the delegate signature
    public static void PrintToConsole(string message)
    {
        Console.WriteLine(message);
    }

    public static void Main()
    {
        // Step 3: Instantiate the delegate
        PrintDelegate print = PrintToConsole;

        // Step 4: Invoke the delegate
        print("Hello, Delegate!");  // Output: Hello, Delegate!
    }
}
--------------------------------------------------------------------------------------------------------

Multicast Delegates:

A delegate can point to multiple methods. This is called multicasting, and it can be done using the + or += operators to combine methods.

--------------------------------------------------------------------------------------------------------
public static void PrintToFile(string message)
{
    // Code to write message to a file
}

PrintDelegate print = PrintToConsole;
print += PrintToFile;

print("Multicast Delegate!");  // Both methods will be invoked.
--------------------------------------------------------------------------------------------------------

If you invoke print, both PrintToConsole and PrintToFile methods will be called in the order they were added.

Delegate Types in C#:

Single-cast Delegate: A delegate that points to a single method (default behavior).

Multicast Delegate: A delegate that points to multiple methods (achieved by combining delegates).

Built-in Delegates:

C# provides some built-in delegate types for convenience:

Action<T>: A delegate for methods that return void and take 0 to 16 parameters.

--------------------------------------------------------------------------------------------------------
Action<string> action = PrintMessage;
--------------------------------------------------------------------------------------------------------

Func<T, TResult>: A delegate for methods that return a value and take 0 to 16 parameters.

--------------------------------------------------------------------------------------------------------
Func<int, int, int> add = (a, b) => a + b;
--------------------------------------------------------------------------------------------------------

Predicate<T>: A delegate for methods that return a boolean and take a single parameter

--------------------------------------------------------------------------------------------------------
Predicate<int> isPositive = (num) => num > 0;
--------------------------------------------------------------------------------------------------------

Use Cases of Delegates:

Event Handling: Delegates are extensively used in event-driven programming. Events in C# are based on delegates.

Callback Functions: Delegates allow passing methods as parameters to other methods, which is useful for callbacks.

Asynchronous Programming: Delegates support invoking methods asynchronously using BeginInvoke and EndInvoke.

Conclusion:

The delegate keyword in C# is a powerful feature that allows methods to be passed as arguments, referenced, and invoked dynamically. It forms the backbone of event handling, callbacks, and other flexible programming paradigms.

*/

/* Anonymous functions

In C#, anonymous functions are functions that are defined inline without a name. They are commonly used for short-lived functionality, often passed as arguments to methods or stored in variables. In the context of delegates, anonymous functions provide a way to define behavior inline without explicitly defining a separate method.

There are two main types of anonymous functions in C#: anonymous methods and lambda expressions. However, we'll focus on anonymous methods in this explanation using the delegate keyword, as requested.

1. Passing Anonymous Function by Reference Using the delegate Keyword

Delegates are used to reference any methods that has the same signature as that of the delegate.

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

*/