using System;

class JumpStatementsDemo
{

    // Method for return statement example
    static int Add(int a, int b)
    {
        return a + b; // Return the sum of a and b
    }

    // Method for throw statement example
    static void CheckValue(int value)
    {
        if (value < 0)
        {
            throw new ArgumentException("Value cannot be negative"); // Throws an exception
        }
        Console.WriteLine("Value is valid: " + value);
    }
    static void Main()
    {
        // 1. break example

        Console.WriteLine("Break Example:");
        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
            {
                break; // Exit the loop when i is 5
            }
            Console.WriteLine("i = " + i);
        }

        // 2. continue example

        Console.WriteLine("\nContinue Example:");
        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                continue; // Skip even numbers
            }
            Console.WriteLine("Odd number: " + i);
        }

        // 3. return example

        Console.WriteLine("\nReturn Example:");
        int sum = Add(10, 20); // Add two numbers and return the result
        Console.WriteLine("Sum: " + sum);

        // 4. goto example

        Console.WriteLine("\nGoto Example:");
        int counter = 0;
    startLabel:
        if (counter < 3)
        {
            Console.WriteLine("Counter = " + counter);
            counter++;
            goto startLabel; // Jump back to the label
        }

        // 5. throw example

        Console.WriteLine("\nThrow Example:");
        try
        {
            CheckValue(-5); // Throws an exception for negative value
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Exception caught: " + ex.Message);
        }
    }
}
