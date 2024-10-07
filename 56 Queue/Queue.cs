using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // Initialize a Queue
        Queue queue = new Queue();

        // Enqueue elements into the Queue
        queue.Enqueue(10);        // int
        queue.Enqueue("Hello");    // string
        queue.Enqueue(3.14);       // double
        queue.Enqueue(true);       // bool

        Console.WriteLine("Elements have been enqueued.");
        // Output: Elements have been enqueued.

        // Peek at the front element without removing it
        Console.WriteLine("\nPeek at front element: " + queue.Peek());
        // Output: Peek at front element: 10 (first element enqueued)

        // Dequeue elements from the Queue (FIFO behavior)
        Console.WriteLine("\nDequeuing elements...");
        Console.WriteLine("Dequeued element: " + queue.Dequeue()); // 10
        // Output: Dequeued element: 10

        Console.WriteLine("Dequeued element: " + queue.Dequeue()); // "Hello"
        // Output: Dequeued element: Hello

        // Check if a specific element exists in the Queue
        bool containsPi = queue.Contains(3.14);
        Console.WriteLine("\nQueue contains 3.14: " + containsPi);
        // Output: Queue contains 3.14: True

        bool containsWorld = queue.Contains("World");
        Console.WriteLine("Queue contains 'World': " + containsWorld);
        // Output: Queue contains 'World': False

        // Check the number of elements currently in the Queue
        Console.WriteLine("\nQueue count: " + queue.Count);
        // Output: Queue count: 2

        // Convert the Queue to an array and display the elements
        object[] queueArray = queue.ToArray();
        Console.WriteLine("\nQueue elements in an array:");
        foreach (object obj in queueArray)
        {
            Console.WriteLine(obj);
        }
        // Output:
        // 3.14
        // True

        // Dequeue the remaining elements
        Console.WriteLine("\nDequeued element: " + queue.Dequeue());  // 3.14
        // Output: Dequeued element: 3.14

        Console.WriteLine("Dequeued element: " + queue.Dequeue());  // True
        // Output: Dequeued element: True

        // Check the count after dequeuing all elements
        Console.WriteLine("\nQueue count after dequeuing all elements: " + queue.Count);
        // Output: Queue count after dequeuing all elements: 0

        // Clear the Queue (it is already empty, but this will ensure no elements are left)
        queue.Clear();
        Console.WriteLine("\nQueue has been cleared.");
        // Output: Queue has been cleared.

        // Confirm the Queue is empty
        Console.WriteLine("Queue count after clear: " + queue.Count);
        // Output: Queue count after clear: 0
    }
}
