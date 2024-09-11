/* Methods/Functions

In C#, methods (also called functions) are blocks of code that perform specific tasks and can be reused multiple times throughout a program. They help improve code organization, readability, and maintainability by encapsulating reusable logic in a single place. Methods are functions inside the class.

Key Concepts of C# Methods:

Method Declaration: This defines the method’s name, return type, parameters (if any), and body.

Return Type: The data type of the value the method returns (e.g., int, string). If the method doesn't return any value, the return type is void.

Method Name: A unique identifier used to call the method.

Parameters: These are variables passed into the method, allowing you to provide input. Parameters are optional.

Method Body: The block of code that executes when the method is called.

Syntax of a Method:

--------------------------------------------------------------------------------------
return_type MethodName(parameter_list)
{
    // method body
    // return statement (if not void)
}
--------------------------------------------------------------------------------------

Example of a Method:

--------------------------------------------------------------------------------------
class Program
{
    // Method that returns the sum of two integers
    static int Add(int a, int b)
    {
        return a + b;
    }

    static void Main()
    {
        // Calling the method
        int result = Add(5, 3);
        Console.WriteLine("The sum is: " + result);
    }
}
--------------------------------------------------------------------------------------


In C#, methods (also called functions) are blocks of code that perform specific tasks and can be reused multiple times throughout a program. They help improve code organization, readability, and maintainability by encapsulating reusable logic in a single place.

Key Concepts of C# Methods:

Method Declaration: This defines the method’s name, return type, parameters (if any), and body.

Return Type: The data type of the value the method returns (e.g., int, string). If the method doesn't return any value, the return type is void.

Method Name: A unique identifier used to call the method.

Parameters: These are variables passed into the method, allowing you to provide input. Parameters are optional.

Method Body: The block of code that executes when the method is called.

Syntax of a Method:

--------------------------------------------------------------------------------------
return_type MethodName(parameter_list)
{
    // method body
    // return statement (if not void)
}
--------------------------------------------------------------------------------------

Example of a Method:

--------------------------------------------------------------------------------------
class Program
{
    // Method that returns the sum of two integers
    static int Add(int a, int b)
    {
        return a + b;
    }

    static void Main()
    {
        // Calling the method
        int result = Add(5, 3);
        Console.WriteLine("The sum is: " + result);
    }
}
--------------------------------------------------------------------------------------

Explanation:

Add: The method name.

int Add(int a, int b): This method has two parameters (a and b), both of type int. It returns an integer (int) as the result.

return a + b: The method returns the sum of a and b to the calling code.

int result = Add(5, 3): The method is called with arguments 5 and 3, and the result (8) is stored in the variable result.

Method Components:

1. Return Type:

The return type specifies what type of value the method returns. For example, if the method returns an integer, the return type is int. If it doesn’t return anything, the return type is void.

Example:

--------------------------------------------------------------------------------------
void PrintMessage() // No return value
{
    Console.WriteLine("Hello, World!");
}
--------------------------------------------------------------------------------------

2. Parameters:

Parameters allow you to pass data into a method. These are specified in parentheses after the method name. Parameters have types and names, and the number of parameters is optional.

Example:

--------------------------------------------------------------------------------------
int Multiply(int x, int y) // Method with two parameters
{
    return x * y;
}
--------------------------------------------------------------------------------------

Parameter Passing Types

By value (default): The method gets a copy of the argument.

By reference: Using the ref or out keyword, the method can modify the caller's variable.

Example (by reference using ref):

--------------------------------------------------------------------------------------
public void MultiplyByTwo(ref int num)
{
    num *= 2;
}
--------------------------------------------------------------------------------------

3. Method Call:

You call a method by using its name followed by parentheses, passing in arguments if required.

--------------------------------------------------------------------------------------
int product = Multiply(4, 5); // Calls Multiply method with arguments 4 and 5
--------------------------------------------------------------------------------------

4. Method Overloading:

C# allows method overloading, meaning you can define multiple methods with the same name, but different parameter lists (either in number, type, or order of parameters).

Example:

--------------------------------------------------------------------------------------
class Program
{
    static int Add(int a, int b)
    {
        return a + b;
    }

    static double Add(double a, double b)
    {
        return a + b;
    }

    static void Main()
    {
        Console.WriteLine(Add(3, 4));         // Calls Add(int, int), output: 7
        Console.WriteLine(Add(3.5, 4.2));     // Calls Add(double, double), output: 7.7
    }
}
--------------------------------------------------------------------------------------

5. Types of Methods:

1. Instance Methods: These are methods that operate on instances (objects) of a class. You need to create an instance of the class to call these methods.

2. Static Methods: These belong to the class itself and can be called without creating an instance of the class.

Example:

--------------------------------------------------------------------------------------
public static void ShowInfo()
{
    Console.WriteLine("This is a static method.");
}
--------------------------------------------------------------------------------------

6. Recursion in Methods:

A method can call itself, a concept known as recursion. This is useful for problems like factorial calculation, Fibonacci series, etc.

Example: Recursive method to calculate factorial:

--------------------------------------------------------------------------------------
class Program
{
    static int Factorial(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * Factorial(n - 1);
    }

    static void Main()
    {
        Console.WriteLine(Factorial(5));  // Output: 120
    }
}
--------------------------------------------------------------------------------------

7. Optional Parameters

Methods can have optional parameters, meaning arguments can be omitted when calling the method, and default values will be used.

--------------------------------------------------------------------------------------
public void PrintMessage(string message = "Default Message")
{
    Console.WriteLine(message);
}
--------------------------------------------------------------------------------------

8. Expression-Bodied Methods

For simple methods, you can use an arrow (=>) to define the method in one line.

Example:

--------------------------------------------------------------------------------------
public int Square(int x) => x * x;
--------------------------------------------------------------------------------------

Summary:

Methods (or functions) are reusable blocks of code in C#.

They have a return type, a name, optional parameters, and a body of code that executes when the method is called.

Methods can be static (called on the class) or instance (called on an object).

You can overload methods by defining them with different parameter lists.

Recursion allows a method to call itself, which is useful for certain types of problems.


*/