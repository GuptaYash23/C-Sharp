/* Lamda Expression

In C#, lambda expressions provide a concise way to represent anonymous methods (functions) using a shorter syntax. Lambda expressions are often used when working with delegates, LINQ queries, or for passing short, one-off functions in a more readable manner.

Syntax of Lambda Expressions

The basic syntax of a lambda expression looks like this:

---------------------------------------------------------------------------
(parameters) => expression;
---------------------------------------------------------------------------

Where:

parameters: The input parameters for the lambda (similar to method parameters).

=>: The lambda operator (sometimes called "goes to").

expression: The body of the lambda, which can be a single expression or a block of code.

Types of Lambda Expressions:

Expression Lambdas: These have a single expression in the body.
Statement Lambdas: These use a code block (with {}) for more complex logic.

Examples of Lambda Expressions

1. Expression Lambda (Single Expression)

An expression lambda consists of one expression, and the result of that expression is implicitly returned.

---------------------------------------------------------------------------
Func<int, int> square = x => x * 2;
Console.WriteLine(square(5)); // Output: 10
---------------------------------------------------------------------------

Here:

x is the parameter.

x * 2 is the expression that multiplies x by 2.

The result of the lambda expression is implicitly returned, so square(5) evaluates to 10.

2. Statement Lambda (Multiple Statements)

For more complex logic, you can use a block of code in a lambda expression, similar to a regular method.

---------------------------------------------------------------------------
Func<int, int> factorial = n =>
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= i;
    }
    return result;
};
Console.WriteLine(factorial(5)); // Output: 120
---------------------------------------------------------------------------

Here:

We use {} to define a code block, allowing us to write multiple statements.

The lambda expression calculates the factorial of a number.

Example with a Delegate:

---------------------------------------------------------------------------
// Define a delegate
delegate int Operation(int x, int y);

class Program
{
    static void Main()
    {
        // Assign a lambda expression to the delegate
        Operation add = (a, b) => a + b;

        // Use the lambda expression
        Console.WriteLine(add(3, 4)); // Output: 7
    }
}
---------------------------------------------------------------------------

Here:

The lambda expression (a, b) => a + b is assigned to the Operation delegate, which takes two integers.

When add(3, 4) is called, the lambda adds the two numbers and returns the result.

Lambda Expressions in LINQ

Lambda expressions are heavily used in LINQ (Language Integrated Query) to simplify operations on collections.

Example of a LINQ query with a Lambda Expression:

---------------------------------------------------------------------------
using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

        // Use a lambda expression with LINQ's Where method
        var evenNumbers = numbers.Where(n => n % 2 == 0);

        foreach (var number in evenNumbers)
        {
            Console.WriteLine(number);  // Output: 2 4 6
        }
    }
}
---------------------------------------------------------------------------

Here:

n => n % 2 == 0 is a lambda expression that returns true if n is even.

Where is a LINQ method that filters the list, returning only the even numbers.

Key Features of Lambda Expressions:

Type Inference: The compiler infers the types of the parameters based on the delegate or expression it's used with.

---------------------------------------------------------------------------
Func<int, int> square = x => x * x;
---------------------------------------------------------------------------

Multiple Parameters: You can define multiple parameters in the lambda expression.

---------------------------------------------------------------------------
Func<int, int, int> add = (x, y) => x + y;
---------------------------------------------------------------------------

No Parameters: If there are no parameters, use empty parentheses.

---------------------------------------------------------------------------
Action greet = () => Console.WriteLine("Hello, World!");
---------------------------------------------------------------------------

Return Type: The return type is inferred from the expression or explicitly returned in case of a statement lambda.

Statement Lambdas vs. Expression Lambdas

Expression Lambda: Consists of a single expression and automatically returns the result of that expression.

---------------------------------------------------------------------------
Func<int, int> square = x => x * x;
---------------------------------------------------------------------------

Statement Lambda: Uses a block of code ({}) with an explicit return statement.

---------------------------------------------------------------------------
Func<int, int> factorial = x =>
{
    int result = 1;
    for (int i = 1; i <= x; i++)
    {
        result *= i;
    }
    return result;
};
---------------------------------------------------------------------------

Advantages of Lambda Expressions

Conciseness: Lambda expressions make the code shorter and more readable by avoiding boilerplate.

Reusability: They can be assigned to delegates and passed as arguments, making them reusable in different contexts.

Functional Programming Style: Lambdas allow writing code in a more functional style, especially when working with LINQ, delegates, or events.

Conclusion

Lambda expressions in C# provide a powerful way to write concise and readable code, especially when working with delegates and LINQ. By using the => syntax, you can quickly define inline anonymous functions that can be used for short-lived tasks.

*/