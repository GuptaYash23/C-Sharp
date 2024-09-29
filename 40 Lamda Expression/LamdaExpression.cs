using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    // Define a delegate that takes two integers and returns an integer
    delegate int Operation(int x, int y);

    static void Main()
    {
        // 1. Lambda Expression with a Delegate

        // Assign a lambda expression to the delegate
        Operation add = (a, b) => a + b;
        Operation multiply = (a, b) => a * b;

        // Use the lambda expressions
        Console.WriteLine("Addition: " + add(3, 4));       // Output: 7
        Console.WriteLine("Multiplication: " + multiply(3, 4)); // Output: 12

        // 2. Passing Lambda Expression as a Method Argument

        // Method that accepts a delegate as a parameter
        ExecuteOperation(add, 5, 6);         // Output: 11
        ExecuteOperation(multiply, 5, 6);    // Output: 30

        // Pass an inline lambda expression directly to the method
        ExecuteOperation((x, y) => x - y, 10, 3);  // Output: 7

        // 3. Lambda Expression with LINQ

        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

        // Use a lambda expression to filter even numbers
        var evenNumbers = numbers.Where(n => n % 2 == 0);

        Console.WriteLine("Even numbers:");
        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);  // Output: 2 4 6 8
        }

        // Use a lambda expression to calculate the square of each number
        var squaredNumbers = numbers.Select(n => n * n);

        Console.WriteLine("Squared numbers:");
        foreach (var num in squaredNumbers)
        {
            Console.WriteLine(num);  // Output: 1 4 9 16 25 36 49 64
        }
    }

    // Method that accepts a delegate as a parameter
    static void ExecuteOperation(Operation op, int x, int y)
    {
        Console.WriteLine("Result of operation: " + op(x, y));
    }
}
