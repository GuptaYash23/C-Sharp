using System;

// Custom Exception class
public class InvalidAgeException : Exception
{
    public InvalidAgeException(string message) : base(message)
    {
    }
}

class Program
{
    static void Main()
    {
        try
        {
            // 1. Basic try-catch-finally structure
            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine());  // May throw FormatException

            // 2. Validate the input
            ValidateAge(age);  // May throw InvalidAgeException if age is < 18

            // 3. Simulate a possible division by zero error
            int dividend = 10;
            int divisor = age - 20;  // If age is 20, divisor will be 0 (throws DivideByZeroException)
            int result = dividend / divisor;
            Console.WriteLine($"Result: {result}");
        }
        catch (InvalidAgeException ex)  // Custom exception catch block
        {
            Console.WriteLine($"Custom Exception: {ex.Message}");
        }
        catch (FormatException ex)  // Catching incorrect input format (non-integer input)
        {
            Console.WriteLine("Input Error: Please enter a valid integer.");
            Console.WriteLine($"Exception Details: {ex.Message}");
        }
        catch (DivideByZeroException ex)  // Catching division by zero errors
        {
            Console.WriteLine("Math Error: Division by zero is not allowed.");
            Console.WriteLine($"Exception Details: {ex.Message}");
        }
        catch (Exception ex)  // General exception catch-all block
        {
            Console.WriteLine($"General Exception: {ex.Message}");
        }
        finally
        {
            // Code that will always execute, regardless of whether an exception occurred
            Console.WriteLine("Execution of try-catch-finally completed.");
        }
    }

    // Method to validate age and throw custom exception
    static void ValidateAge(int age)
    {
        if (age < 18)
        {
            // Throwing a custom exception if age is less than 18
            throw new InvalidAgeException("Age must be 18 or older.");
        }
    }
}

/* Sample Output

1. When entering a valid age (e.g., 25):

------------------------------------------------------------------------------
Enter your age: 
25
Result: 0
Execution of try-catch-finally completed.
------------------------------------------------------------------------------

2. When entering an invalid age (< 18):

------------------------------------------------------------------------------
Enter your age: 
16
Custom Exception: Age must be 18 or older.
Execution of try-catch-finally completed.
------------------------------------------------------------------------------

3. When entering non-numeric input:

------------------------------------------------------------------------------
Enter your age: 
abc
Input Error: Please enter a valid integer.
Exception Details: Input string was not in a correct format.
Execution of try-catch-finally completed.
------------------------------------------------------------------------------

4. When entering age 20 (causing division by zero):

------------------------------------------------------------------------------
Enter your age: 
20
Math Error: Division by zero is not allowed.
Exception Details: Attempted to divide by zero.
Execution of try-catch-finally completed.
------------------------------------------------------------------------------

*/
