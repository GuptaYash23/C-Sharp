using System;

class OperatorPrecedenceExample
{
    static void Main()
    {
        // Without parentheses, operator precedence applies
        int result1 = 10 + 5 * 2; // Multiplication happens before addition
        Console.WriteLine("Result1 (10 + 5 * 2) = " + result1); // Output: 20

        // Using parentheses to change the order of evaluation
        int result2 = (10 + 5) * 2; // Addition happens before multiplication
        Console.WriteLine("Result2 ((10 + 5) * 2) = " + result2); // Output: 30

        // Combining different precedence levels
        int result3 = 10 + 5 * 2 - 3 / 1; // Multiplication and division happen first
        Console.WriteLine("Result3 (10 + 5 * 2 - 3 / 1) = " + result3); // Output: 17

        // Using conditional operators
        int a = 5, b = 10, c = 15;
        int result4 = a > b ? a : (b < c ? b : c); // Ternary operator precedence
        Console.WriteLine("Result4 (Ternary expression) = " + result4); // Output: 10
    }
}
