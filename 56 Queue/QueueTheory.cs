/* Queue

System.Collection namespace consists of the Queue collection class

Queue stores the elements in the FIFO style (First in First Out), so basically it contains the elements in the order they were added

In C#, a Queue (non-generic) is a collection that represents a first-in, first-out (FIFO) data structure. This means the first item added to the queue is the first one to be removed. The non-generic Queue class in C# is part of the System.Collections namespace, and it can store elements of any type, as it stores objects as object types.

-> Key Characteristics of a Non-Generic Queue:

1. FIFO (First-In, First-Out): The first element added to the queue is the first one to be removed.

2. Non-Generic: The Queue can store elements of any type, but this lacks type safety, and value types are boxed and unboxed, which can affect performance.

3. Dynamic Size: Like the Stack, the Queue grows and shrinks dynamically as elements are added or removed.

4. Use Cases: Queues are commonly used in scenarios like processing tasks in the order they arrive, managing print jobs, or handling events.

-> Common Methods of Queue:

1. Enqueue(object obj): Adds an object to the end of the queue.

2. Dequeue(): Removes and returns the object at the front of the queue.

3. Peek(): Returns the object at the front of the queue without removing it.

4. Count: Gets the number of elements in the queue.
Contains(object obj): Checks whether a specific object is in the queue.

5. Clear(): Removes all objects from the queue.

6. ToArray(): Copies the queue elements into a new array.

Example of Non-Generic Queue:

------------------------------------------------------------------------------
using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // Initialize a Queue
        Queue queue = new Queue();

        // Enqueue elements into the Queue
        queue.Enqueue(10);       // int
        queue.Enqueue("Hello");   // string
        queue.Enqueue(3.14);      // double
        queue.Enqueue(true);      // bool

        // Peek at the front element without removing it
        Console.WriteLine("Front element (Peek): " + queue.Peek());
        // Output: Front element (Peek): 10

        // Dequeue elements from the Queue (FIFO behavior)
        Console.WriteLine("Dequeued element: " + queue.Dequeue());
        // Output: Dequeued element: 10 (first added is first out)

        Console.WriteLine("Dequeued element: " + queue.Dequeue());
        // Output: Dequeued element: Hello

        // Count the remaining elements in the queue
        Console.WriteLine("Queue count: " + queue.Count);
        // Output: Queue count: 2

        // Check if the Queue contains a specific element
        bool containsPi = queue.Contains(3.14);
        Console.WriteLine("Queue contains 3.14: " + containsPi);
        // Output: Queue contains 3.14: True

        // Dequeue the remaining elements
        Console.WriteLine("Dequeued element: " + queue.Dequeue());  // 3.14
        Console.WriteLine("Dequeued element: " + queue.Dequeue());  // True

        // Check the count after dequeuing all elements
        Console.WriteLine("Queue count after dequeuing all elements: " + queue.Count);
        // Output: Queue count after dequeuing all elements: 0
    }
}
------------------------------------------------------------------------------

Output:

------------------------------------------------------------------------------
Front element (Peek): 10
Dequeued element: 10
Dequeued element: Hello
Queue count: 2
Queue contains 3.14: True
Dequeued element: 3.14
Dequeued element: True
Queue count after dequeuing all elements: 0
------------------------------------------------------------------------------

Explanation:

Enqueue: Adds elements to the end of the queue. The first element added is 10 (an integer).

Peek: Returns the front element (10) without removing it.
Dequeue: Removes and returns the front element, which is the element that was added first (FIFO).

Contains: Checks if the queue contains a specific element like 3.14.

Count: Shows the current number of elements in the queue after operations.

How Queue Works:

FIFO Behavior: Elements are added (enqueued) to the end of the queue and removed (dequeued) from the front. This ensures that the first element added is always the first one to be removed.

No Type Safety: Since the non-generic Queue stores elements as object, you can add elements of any type. However, this requires casting when retrieving value types, which can result in runtime errors if done incorrectly.

Performance Considerations:

Boxing and Unboxing: Since non-generic Queue stores all elements as object, value types (like int, bool, etc.) are boxed when added, and unboxed when retrieved. This incurs a performance overhead compared to the generic Queue<T>.

Generic Alternative:

The generic counterpart of Queue is Queue<T>, which provides type safety and better performance since it avoids boxing/unboxing for value types and ensures that all elements in the queue are of the same type.

Here’s a quick comparison of how Queue<T> looks:

------------------------------------------------------------------------------
Queue<int> genericQueue = new Queue<int>();
genericQueue.Enqueue(10);
int front = genericQueue.Dequeue();  // No casting required
------------------------------------------------------------------------------

Summary:

The non-generic Queue in C# is a FIFO data structure that can hold objects of any type but lacks type safety and may incur performance costs due to boxing/unboxing of value types.

If you need type safety and performance optimization, the generic Queue<T> is a better choice.

Common operations include Enqueue, Dequeue, Peek, and Contains, which enable you to interact with the queue efficiently.


*/