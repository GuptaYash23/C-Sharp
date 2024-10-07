/* Stack (Non Generic)

Available with System.Generic namespace. Stack can store null and duplicate values.

The Stack class implements the IEnumerable, ICollection and ICloneable interfaces.

In C#, a Stack (non-generic) is a collection that represents a simple last-in, first-out (LIFO) data structure. This means that the last item added to the stack is the first one to be removed. The non-generic Stack class in C# is part of the System.Collections namespace, and unlike its generic counterpart (Stack<T>), it can store elements of any type, as it uses object to store the values.

-> Key Characteristics of a Non-Generic Stack:

LIFO (Last-In, First-Out): The most recent element added is the first one to be removed.
Non-Generic: It can store elements of any type (object), but this may result in boxing/unboxing for value types and lacks type safety.

-> Push and Pop Operations:

Push: Adds an item to the top of the stack.

Pop: Removes and returns the item from the top of the stack.

Peek Operation: Allows you to look at the item on top of the stack without removing it.

Dynamic Size: The stack grows and shrinks dynamically as elements are added or removed.

-> Common Methods of Stack:

Push(object obj): Adds an object to the top of the stack.

Pop(): Removes and returns the object at the top of the stack.

Peek(): Returns the object at the top of the stack without removing it.

Count: Gets the number of elements in the stack.

Contains(object obj): Determines whether an object is in the stack.

Clear(): Removes all objects from the stack.

ToArray(): Copies the elements of the stack into a new array.

Example:

----------------------------------------------------------------------------------------------------------
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
----------------------------------------------------------------------------------------------------------

-> Explanation:

Push: Adds elements to the stack. The last element added is true (a boolean).

Peek: Returns the top element (true) without removing it.

Pop: Removes and returns the last element added (in this case, true), demonstrating the LIFO behavior.

Contains: Checks if the stack contains a specific element, such as "Hello".

Count: Shows the current number of elements in the stack after operations.

-> How Stack Works:

LIFO Behavior: Elements are added (pushed) to the top of the stack and removed (popped) from the top. This means the most recently added element is always the first to be removed.

No Type Safety: Since the non-generic Stack stores elements as object, any data type can be pushed into it. However, when retrieving value types, you may need to cast them back to their original types, which can lead to runtime errors if done incorrectly.

-> Performance Considerations:

Boxing and Unboxing: Since non-generic Stack stores all elements as object, value types (like int, bool, etc.) are boxed when added, and unboxed when retrieved. This can lead to performance overhead compared to the generic Stack<T>.

-> Generic Alternative:

The generic counterpart of Stack is Stack<T>, which provides type safety and better performance since it avoids boxing/unboxing for value types and ensures that all elements in the stack are of the same type.

Here’s a quick comparison of how Stack<T> looks:

----------------------------------------------------------------------------------------------------------
Stack<int> genericStack = new Stack<int>();
genericStack.Push(10);
int top = genericStack.Pop();  // No casting required
----------------------------------------------------------------------------------------------------------

Summary:

The non-generic Stack in C# is a LIFO data structure that can hold objects of any type but lacks type safety and may incur performance costs due to boxing/unboxing of value types.

If you need type safety and performance optimization, the generic Stack<T> should be preferred.

Common operations include Push, Pop, Peek, and Contains, which enable you to interact with the stack efficiently.

*/