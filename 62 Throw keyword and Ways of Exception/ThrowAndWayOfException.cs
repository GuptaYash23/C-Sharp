using System;

// Custom exception class
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
            // Call a method that throws a predefined exception
            PerformDivision(10, 0); // This will throw DivideByZeroException

            // Call a method that throws a custom exception
            ValidateAge(-5); // This will throw InvalidAgeException
        }
        catch (DivideByZeroException ex)
        {
            // Handle DivideByZeroException specifically
            Console.WriteLine("Caught DivideByZeroException: " + ex.Message);
        }
        catch (InvalidAgeException ex)
        {
            // Handle custom InvalidAgeException
            Console.WriteLine("Caught InvalidAgeException: " + ex.Message);
        }
        catch (Exception ex)
        {
            // Handle all other exceptions (general catch block)
            Console.WriteLine("Caught a general exception: " + ex.Message);
        }
        finally
        {
            // This block will always execute, whether an exception is thrown or not
            Console.WriteLine("Finally block executed: Cleanup resources or perform final actions.");
        }
    }

    // Method that throws a predefined exception (DivideByZeroException)
    static void PerformDivision(int a, int b)
    {
        try
        {
            int result = a / b;  // This will throw DivideByZeroException
            Console.WriteLine("Division result: " + result);
        }
        catch (DivideByZeroException)
        {
            // Log the exception and rethrow it to be handled by the caller
            Console.WriteLine("Attempted to divide by zero.");
            throw;  // Rethrow the same exception to be caught in the Main method
        }
    }

    // Method that throws a custom exception (InvalidAgeException)
    static void ValidateAge(int age)
    {
        if (age < 0)
        {
            // Throwing a custom exception if age is negative
            throw new InvalidAgeException("Age cannot be negative.");
        }
        else if (age < 18)
        {
            // Throwing an ArgumentOutOfRangeException if age is below 18
            throw new ArgumentOutOfRangeException("age", "Age must be at least 18.");
        }
        else
        {
            Console.WriteLine("Valid age: " + age);
        }
    }
}


/*

There are 4 ways of exception

1. Default Throw and Default Catch

Code:

----------------------------------------------------------------------------------------------------------------------
static void Main(string[] args)
{
  int a = 1-;
  int b = 0;
  int c = a/b;
  Console.WriteLine(c);
}
----------------------------------------------------------------------------------------------------------------------

Output:

----------------------------------------------------------------------------------------------------------------------
C# default catch
An unhandled exception of type 'System.DivideByZeroException' ocurred in ExceptionDemo.exe.
----------------------------------------------------------------------------------------------------------------------

2. Default Throw and Our Catch

----------------------------------------------------------------------------------------------------------------------
static void Main(string[] args)
{
  try
  {
    int a = 10;
    int b = 0;
    int c = a/b;
    Console.WriteLine(c);
  }
  catch(DivideByZeroException ex)
  {
    Console.WriteLine(ex.Message);
  }
}
----------------------------------------------------------------------------------------------------------------------

Output:

----------------------------------------------------------------------------------------------------------------------
Attempted to divide by zero.
----------------------------------------------------------------------------------------------------------------------

3. Our Throw and Default Catch

----------------------------------------------------------------------------------------------------------------------
static void Main(string[] args)
{
 Console.WriteLine("Enter your age: ");
 int age = int.Parse(Console.ReadLine());

 if(age>=18)
  {
    Console.WriteLine("You are eligible to vote");
  }
 else 
  {
    throw new Exception("You aren't eligible to vote");
  }
}
----------------------------------------------------------------------------------------------------------------------

Output:

----------------------------------------------------------------------------------------------------------------------
C# default catch
An unhandled exception of type 'System.Exception' occurred in ExceptionDemo.exe
----------------------------------------------------------------------------------------------------------------------

4. Our Throw and Our Catch

Code:

----------------------------------------------------------------------------------------------------------------------
static void Main(string[] args)
{
 try
 {
 
 Console.WriteLine("Enter your age: ");
 int age = int.Parse(Console.ReadLine());

 if(age>=18)
  {
    Console.WriteLine("You are eligible to vote");
  }
 else 
  {
    throw new Exception("You aren't eligible to vote");
  }
 }
 catch(Exception ex)
 {
   Console.WriteLine(ex.Message);
 }
}
----------------------------------------------------------------------------------------------------------------------

Output:

----------------------------------------------------------------------------------------------------------------------
19 
You are eligible to vote
15
You aren't eligible to vote
----------------------------------------------------------------------------------------------------------------------
*/