using System;

class Program
{
    // Static method: no need for an instance to call this method
    static int Square(int num)
    {
        return num * num;
    }

    // Instance method: you need an object to call this method
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Method overloading: two methods with the same name but different parameters
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }

    // Recursive method: calculates the factorial of a number
    static int Factorial(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * Factorial(n - 1);  // Recursively calls itself
    }

    static void Main()
    {
        // Calling the static method
        int squareResult = Square(4);
        Console.WriteLine("Square of 4 is: " + squareResult);  // Output: 16

        // Creating an instance of Program to call instance methods
        Program program = new Program();

        // Calling the instance method Add (with 2 integers)
        int sumResult1 = program.Add(3, 5);
        Console.WriteLine("Sum of 3 and 5 is: " + sumResult1);  // Output: 8

        // Calling the overloaded Add method (with 3 integers)
        int sumResult2 = program.Add(3, 5, 7);
        Console.WriteLine("Sum of 3, 5, and 7 is: " + sumResult2);  // Output: 15

        // Calling the overloaded Add method (with 2 doubles)
        double sumResult3 = program.Add(3.2, 4.5);
        Console.WriteLine("Sum of 3.2 and 4.5 is: " + sumResult3);  // Output: 7.7

        // Calling the recursive method Factorial
        int factorialResult = Factorial(5);
        Console.WriteLine("Factorial of 5 is: " + factorialResult);  // Output: 120

        Console.ReadLine();
    }
}
