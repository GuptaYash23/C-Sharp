using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // Initialize a Stack
        Stack stack = new Stack();

        // Push elements onto the Stack
        stack.Push(10);      // int
        stack.Push("Hello");  // string
        stack.Push(3.14);     // double
        stack.Push(true);     // bool

        // Peek at the top element without removing it
        Console.WriteLine("Top element (Peek): " + stack.Peek());
        // Output: Top element (Peek): True

        // Pop elements from the Stack (LIFO behavior)
        Console.WriteLine("Popped element: " + stack.Pop());
        // Output: Popped element: True (last added is first out)

        Console.WriteLine("Popped element: " + stack.Pop());
        // Output: Popped element: 3.14

        // Count the remaining elements in the stack
        Console.WriteLine("Stack count: " + stack.Count);
        // Output: Stack count: 2

        // Check if the Stack contains a specific element
        bool containsHello = stack.Contains("Hello");
        Console.WriteLine("Stack contains 'Hello': " + containsHello);
        // Output: Stack contains 'Hello': True

        // Pop the remaining elements
        Console.WriteLine("Popped element: " + stack.Pop());  // "Hello"
        Console.WriteLine("Popped element: " + stack.Pop());  // 10

        // Check the count after popping all elements
        Console.WriteLine("Stack count after popping all elements: " + stack.Count);
        // Output: Stack count after popping all elements: 0
    }
}
