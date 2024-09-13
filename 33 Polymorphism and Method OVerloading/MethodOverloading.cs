using System;

public class Calculator
{
    // Method with two integer parameters
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Overloaded method with three integer parameters
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    // Overloaded method with two double parameters
    public double Add(double a, double b)
    {
        return a + b;
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        // Calling different overloads of the Add method
        Console.WriteLine(calc.Add(3, 4));           // Calls Add(int, int) -> Output: 7
        Console.WriteLine(calc.Add(3, 4, 5));        // Calls Add(int, int, int) -> Output: 12
        Console.WriteLine(calc.Add(3.5, 4.5));       // Calls Add(double, double) -> Output: 8.0
    }
}
