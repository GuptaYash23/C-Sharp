using System;

class Program
{
    static void Main()
    {
        int x = 5;
        int y;

        // Prefix increment
        y = ++x; // x is now 6, y is 6
        Console.WriteLine($"Prefix Increment: x = {x}, y = {y}");   // Prefix Increment: x = 6, y = 6

        // Postfix increment
        y = x++; // y is 6, x is now 7
        Console.WriteLine($"Postfix Increment: x = {x}, y = {y}");   // Postfix Increment: x = 7, y = 6

        // Prefix decrement
        y = --x; // x is now 6, y is 6
        Console.WriteLine($"Prefix Decrement: x = {x}, y = {y}");   // Prefix Decrement: x = 6, y = 6

        // Postfix decrement
        y = x--; // y is 6, x is now 5
        Console.WriteLine($"Postfix Decrement: x = {x}, y = {y}");   // Postfix Decrement: x = 5, y = 6

        Console.ReadLine();
    }
}
