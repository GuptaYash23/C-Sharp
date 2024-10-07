using System;

class Program
{
    // Define a delegate that takes a string argument
    delegate void PrintDelegate(string message);

    // Method that accepts a delegate as a parameter
    static void Execute(PrintDelegate printDelegate)
    {
        // Call the delegate
        printDelegate("Hello from inline anonymous function!");
    }

    static void Main()
    {
        // 1. Anonymous Function with Delegate Reference

        // Create an anonymous function and assign it to a delegate
        PrintDelegate print = delegate(string msg)
        {
            Console.WriteLine("Message: " + msg);
        };

        // Now the delegate holds the reference to the anonymous function
        print("Hello from a delegate-referenced anonymous function!");
        
        // Call it again with a different message
        print("Another call using the same anonymous function!");

        // 2. Inline Anonymous Function without Delegate Reference

        // Pass an anonymous function directly as an argument to the Execute method
        Execute(delegate(string msg)
        {
            Console.WriteLine("Inline Message: " + msg);
        });

        // Pass another inline anonymous function to demonstrate flexibility
        Execute(delegate(string msg)
        {
            Console.WriteLine("Another Inline Message: " + msg.ToUpper());
        });
    }
}
