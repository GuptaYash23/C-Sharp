/* Exceptions stops further flow of program and C# throws a generated object ereror */

/* Exceptions and Exception Handling

Exceptions and Exception Handling in C#
Exception refers to an event that occurs during the execution of a program that disrupts the normal flow of instructions. In C#, exceptions are unexpected errors that occur during the runtime, such as dividing by zero, accessing an invalid index, or working with a null reference.

C# provides a robust mechanism for handling exceptions, known as exception handling, which allows developers to manage runtime errors gracefully without crashing the application.

Exception Classes

All exceptions in C# are derived from the System.Exception class. Some common built-in exceptions are:

System.DivideByZeroException: Thrown when attempting to divide by zero.

System.NullReferenceException: Thrown when attempting to use an object that has not been initialized.

System.IndexOutOfRangeException: Thrown when attempting to access an index that is out of bounds of an array or collection.

System.InvalidOperationException: Thrown when a method call is invalid for the object's current state.

System.ArgumentException: Thrown when one of the arguments provided to a method is invalid.

Exception Handling Mechanism

C# provides four key keywords for exception handling:

try: A block of code that may potentially throw an exception.

catch: A block that handles the exception if one is thrown in the try block.

finally: A block that is always executed after the try block, whether or not an exception occurred.

throw: Used to manually throw an exception.

Basic Exception Handling Structure

------------------------------------------------------------------------------
try
{
    // Code that may throw an exception
}
catch (ExceptionType ex)
{
    // Handle the exception
}
finally
{
    // Code that will always execute, regardless of whether an exception occurred or not
}
------------------------------------------------------------------------------

How It Works:

The code that might throw an exception is placed inside the try block.

If an exception occurs, the control is transferred to the corresponding catch block.

The finally block is executed after the try and catch blocks, regardless of whether an exception occurred. It is typically used to release resources such as closing file streams or database connections.

Example of Exception Handling

------------------------------------------------------------------------------
using System;

class Program
{
    static void Main()
    {
        try
        {
            int dividend = 10;
            int divisor = 0;
            int result = dividend / divisor;  // This will throw DivideByZeroException
            Console.WriteLine($"Result: {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            Console.WriteLine($"Exception Message: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"General Exception: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("This will always execute.");
        }
    }
}
------------------------------------------------------------------------------

Output:

------------------------------------------------------------------------------
Error: Division by zero is not allowed.
Exception Message: Attempted to divide by zero.
This will always execute.
------------------------------------------------------------------------------

Multiple catch Blocks

You can have multiple catch blocks to handle different types of exceptions separately:

------------------------------------------------------------------------------
try
{
    // Some code that can throw multiple types of exceptions
}
catch (NullReferenceException ex)
{
    Console.WriteLine("Null reference encountered.");
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Index out of range.");
}
catch (Exception ex)
{
    Console.WriteLine("General exception occurred.");
}
------------------------------------------------------------------------------

In this example, the first catch block will handle NullReferenceException, the second will handle IndexOutOfRangeException, and the last one will catch any other exceptions.

The finally Block

The finally block is optional and is used to ensure that certain cleanup code is always executed regardless of whether an exception is thrown or not.

------------------------------------------------------------------------------
try
{
    // Some code that may throw an exception
}
catch (Exception ex)
{
    Console.WriteLine("An error occurred.");
}
finally
{
    Console.WriteLine("This block always executes.");
}
------------------------------------------------------------------------------

Throwing Exceptions Manually (throw)

You can throw exceptions manually using the throw keyword. For example, you might want to throw an exception when an invalid condition occurs:

------------------------------------------------------------------------------
static void ValidateAge(int age)
{
    if (age < 18)
    {
        throw new ArgumentException("Age must be 18 or older.");
    }
}
------------------------------------------------------------------------------

Catching All Exceptions

The base Exception class can catch any type of exception. It is a good practice to catch specific exceptions first and catch the base Exception class as a fallback.

------------------------------------------------------------------------------
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}
------------------------------------------------------------------------------

Custom Exceptions

You can create custom exceptions by deriving from the Exception class. This is useful when you need more specific error handling that built-in exceptions don't cover.

------------------------------------------------------------------------------
public class InvalidAgeException : Exception
{
    public InvalidAgeException(string message) : base(message) { }
}
------------------------------------------------------------------------------

You can then use this custom exception in your code like this:

------------------------------------------------------------------------------
static void ValidateAge(int age)
{
    if (age < 18)
    {
        throw new InvalidAgeException("Age must be 18 or older.");
    }
}
------------------------------------------------------------------------------

Common Exception Classes in C#:

ArgumentException: Raised when an invalid argument is passed to a method.
ArgumentNullException: Raised when a null argument is passed to a method that doesn’t accept it.

ArgumentOutOfRangeException: Raised when the value of an argument is outside the allowable range.

DivideByZeroException: Raised when an attempt to divide by zero occurs.

IndexOutOfRangeException: Raised when an attempt to access an invalid index in an array or collection occurs.

InvalidOperationException: Raised when a method is called that is not valid for the object's current state.

NullReferenceException: Raised when trying to use an object reference that is set to null.

FileNotFoundException: Raised when trying to access a file that doesn’t exist.

Best Practices for Exception Handling in C#:

Catch Specific Exceptions: Always catch the most specific exception types before catching generic exceptions (Exception).

Don't Swallow Exceptions: Don’t use empty catch blocks, as it can hide potential problems. Always log or handle exceptions appropriately.

Use finally Block for Cleanup: Use the finally block to release resources such as file handles, database connections, or network connections.

Use Custom Exceptions: If built-in exceptions don't cover your specific case, create and throw custom exceptions to better describe the error scenario.

Don't Overuse Exceptions: Exceptions should be used for exceptional cases, not for normal control flow.

Summary

Exceptions: Errors that occur during the execution of a program.

Exception Handling: Managed using try, catch, finally, and throw.

try-catch-finally: Try block contains the code that may throw exceptions, catch block handles the exceptions, and finally block contains code that is always executed.

Throwing Exceptions: You can manually throw exceptions using the throw keyword.

Custom Exceptions: Can create custom exceptions by deriving from Exception.
This allows for robust error handling and ensures that your application can handle runtime issues gracefully.

This allows for robust error handling and ensures that your application can handle runtime issues gracefully.

*/

// To handle all the exception we can also use the parent exception class

/* Index Out of Range Exception

Code:

------------------------------------------------------------------------------
int[] arr = new int[3];

            try
            {
                arr[0] = 11;
                arr[1] = 22;
                arr[2] = 33;
                arr[3] = 44;

                foreach (int num in arr)
                {
                    Console.WriteLine(num);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Array's range is exceeded");
                Console.WriteLine(ex.Message);
            }
------------------------------------------------------------------------------

*/

/* Null reference exception

Code:

------------------------------------------------------------------------------
string name = null;

try 
{
  Console.WriteLine(name.Length);
}
catch(NullReferenceException ex)
{
  Console.WriteLine(ex.Message);
}
------------------------------------------------------------------------------

*/

/* Handling Format Exception

Code:

------------------------------------------------------------------------------
Console.WriteLine("Enter a number: ");

try 
{
 int num = int.Parse(number);
 Console.WriteLine("Number is : "+num);
}
catch(FormatException ex)
{
 Console.WriteLine("String format is invalied...")
}
------------------------------------------------------------------------------
*/

/* Exception Class

We can handle all the exceptions using the parent Exception class

(i) Handlng Null reference exception

------------------------------------------------------------------------------
try{
 string a = null;
 Console.WriteLine(a.Length);
}
catch(Exception ex)
{
 Console.WriteLine(ex.Message);
}
------------------------------------------------------------------------------

(ii) Index Out Of Range Exception

------------------------------------------------------------------------------
try{
 int[] arr = new int[3];
 arr[0] = 11;
 arr[1] = 22;
 arr[2] = 33;
 arr[3] = 44;
}
catch(Exception ex)
{
 Console.WriteLine(ex.Message);
}
------------------------------------------------------------------------------

(iii) Format exception

------------------------------------------------------------------------------
try{
 string a = "Yash";
 int i = a;
}
catch(Exception ex)
{
 Console.WriteLine(ex.Message);
}
------------------------------------------------------------------------------


*/