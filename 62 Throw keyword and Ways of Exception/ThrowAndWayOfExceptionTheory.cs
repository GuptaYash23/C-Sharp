/* Throw keyword and Ways of Exception

In C#, the throw keyword is used to explicitly raise an exception. It allows you to either propagate an existing exception or generate a new exception, interrupting the normal flow of execution. The throw keyword is essential when you need to indicate an error condition, either by rethrowing a caught exception or by throwing a custom or predefined exception as C# won't recognize exceptional situation of buisness logic.

Using throw in C#:

Throwing a New Exception: You can create a new exception and throw it using throw. This is typically used when you encounter an invalid state or input in your program and want to signal an error.

Rethrowing an Existing Exception: In a catch block, you can rethrow the caught exception to pass it up the call stack, allowing it to be handled by higher-level exception handling code.

1. Throwing a New Exception:

You can use throw to raise a predefined exception (like ArgumentNullException, InvalidOperationException, etc.) or a custom exception.

Syntax:

----------------------------------------------------------------------------------------------------------------------
throw new ExceptionType("Error message");
----------------------------------------------------------------------------------------------------------------------

Example:

----------------------------------------------------------------------------------------------------------------------
using System;

class Program
{
    static void Main()
    {
        try
        {
            ValidateNumber(-5);  // This will throw an exception
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Exception caught: {ex.Message}");
        }
    }

    static void ValidateNumber(int number)
    {
        if (number < 0)
        {
            // Throwing an exception if the number is negative
            throw new ArgumentOutOfRangeException("number", "The number cannot be negative.");
        }
        Console.WriteLine($"Valid number: {number}");
    }
}
----------------------------------------------------------------------------------------------------------------------

Output:

----------------------------------------------------------------------------------------------------------------------
Exception caught: The number cannot be negative. (Parameter 'number')
----------------------------------------------------------------------------------------------------------------------

In this example, when a negative number is passed to the ValidateNumber method, it throws an ArgumentOutOfRangeException, which is caught in the catch block.

2. Rethrowing an Exception:

In a catch block, you can use the throw keyword to rethrow the same exception. This is useful when you want to perform some additional processing or logging before passing the exception to the higher layers for further handling.

Syntax:

----------------------------------------------------------------------------------------------------------------------
catch (Exception ex)
{
    // Additional code (logging, etc.)
    throw;  // Rethrows the same exception
}
----------------------------------------------------------------------------------------------------------------------

Example:

----------------------------------------------------------------------------------------------------------------------
using System;

class Program
{
    static void Main()
    {
        try
        {
            int result = Divide(10, 0);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Main method caught: {ex.Message}");
        }
    }

    static int Divide(int a, int b)
    {
        try
        {
            return a / b;  // This will throw a DivideByZeroException
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Log: Divide by zero attempted.");
            throw;  // Rethrow the exception to be handled by the caller
        }
    }
}
----------------------------------------------------------------------------------------------------------------------

Output:

----------------------------------------------------------------------------------------------------------------------
Log: Divide by zero attempted.
Main method caught: Attempted to divide by zero.
----------------------------------------------------------------------------------------------------------------------

In this example, the Divide method catches the DivideByZeroException to log a message, and then rethrows the exception to be caught by the catch block in the Main method.

Ways of Throwing Exceptions in C#:

1. Throwing Predefined Exceptions: You can throw any of the predefined exceptions in .NET, such as ArgumentNullException, InvalidOperationException, IndexOutOfRangeException, etc. These exceptions represent common error conditions that occur in various scenarios.

Example:

----------------------------------------------------------------------------------------------------------------------
throw new InvalidOperationException("Operation is invalid.");
----------------------------------------------------------------------------------------------------------------------

2. Throwing Custom Exceptions: You can define your own exception by creating a class that inherits from Exception and throw that exception when a specific error condition arises in your application.

Example:

----------------------------------------------------------------------------------------------------------------------
public class InvalidAgeException : Exception
{
    public InvalidAgeException(string message) : base(message)
    {
    }
}

// Usage
throw new InvalidAgeException("Age cannot be less than 18.");
----------------------------------------------------------------------------------------------------------------------

3. Rethrowing an Exception: In some scenarios, you may want to catch an exception, perform some actions (like logging), and then rethrow the exception using the throw keyword without specifying the exception object. This passes control to the higher-level exception handler.

----------------------------------------------------------------------------------------------------------------------
catch (Exception ex)
{
    // Log the exception or perform any action
    throw;  // Rethrow the same exception
}
----------------------------------------------------------------------------------------------------------------------

4. Throwing Exceptions Conditionally: You can throw exceptions conditionally based on input validation or other business logic. This is commonly used in methods that require certain preconditions to be met.

----------------------------------------------------------------------------------------------------------------------
if (age < 0)
{
    throw new ArgumentOutOfRangeException("age", "Age cannot be negative.");
}
----------------------------------------------------------------------------------------------------------------------

Summary of throw Keyword Usage:

Throw a new exception: Use throw to signal an error condition and interrupt normal program flow by raising an exception.

Rethrow an exception: Use throw without specifying the exception object inside a catch block to propagate the exception to the higher layers of the program.

Custom exceptions: You can define and throw your own exceptions to handle specific application-specific error conditions.

Conditionally throw exceptions: You can use validation logic and throw exceptions when input or conditions are invalid.

Key Points to Remember:

throw always stops execution: When an exception is thrown, the normal flow of the program is interrupted, and control moves to the nearest matching catch block.

Exception hierarchy: Exceptions in C# are derived from the base Exception class, so you can catch specific exceptions or more general exceptions like Exception.

throw in catch block: If you want to rethrow the original exception, use throw; inside a catch block without specifying the exception object to preserve the original stack trace.
*/