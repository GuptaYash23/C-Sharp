/* Collections

A collection is a set of related data that may not necessarily belong to the same data type that can be set or modified dynamically at run-time.

In other words, collection is a dynamic storage as it's length can increase on runtime.

-> Fixed Datatypes drawbacks

Fixed datatypes length is fixed, which means we cannot change the length after declaring the datatype. (Although there are some properties for datatypes like Array where Array.Resize() takes the reference array(ref ArrayName) and required size and creates another new array of the required size copying the data from the previous array and then destroys the previous array)

We can never insert a value into a middle of an array(Fixed datatypes), because if we want to do this then array(datatype) length should be increased but we cannot increase the length of an array after declaring the length of an array.

We can never delete a value from a middle of an array(fixed datatype)

Accessing collections is similar to accessing arrays, where elements are accessed by their index numbers. However, there are differences between arrays and collections

-> Fixed Size Datatypes

Cannot be resized at run-time.

The individual elements are of the same data type.

They do not contain any methods for operations on elements.

We can never insert a value into middle of fixed datatypes.

We can never delete a value from middle of fixed datatypes.

-> Collections

Can be resized at run time.

The individual elements can be of different types.

Contain methods for operations on elements.

We can insert a value into middle of a collection.

We can delete a value from a middle of a collection.

-> What are collections?

Collections in C# are specialized data structures that allow you to store, manage, and manipulate groups of related objects. They provide a way to work with multiple items as a single unit, offering various functionalities such as adding, removing, searching, and iterating over elements. The .NET Framework provides a rich set of collection classes that are part of the System.Collections, System.Collections.Generic, and System.Collections.Concurrent namespaces.

Type Safety - It is a feature of programming languages that ensures that variables are used in a manner consistent with their data types. In a type-safe language, operations on data types are checked at compile time (or runtime, in some cases) to prevent type errors, which can lead to unexpected behavior or crashes in a program. 

-> Types of Collections

1. Non-Generic Collections:

These collections can store any type of object, but they do not provide type safety, which can lead to runtime errors if the wrong type is used.

Common non-generic collections include:

ArrayList: A resizable array that can hold objects of any type. It is not type-safe and requires boxing/unboxing for value types.

Hashtable: A collection of key-value pairs that allows for fast retrieval based on keys. Keys must be unique.

Queue: A first-in, first-out (FIFO) collection that allows you to add items to the end and remove items from the front.

Stack: A last-in, first-out (LIFO) collection that allows you to add items to the top and remove items from the top.

2. Generic Collections:

These collections are type-safe and allow you to specify the type of objects they can hold, reducing the risk of runtime errors.

Common generic collections include:

List<T>: A dynamically sized list that can hold elements of a specified type. It provides methods for adding, removing, and searching for elements.

Dictionary<TKey, TValue>: A collection of key-value pairs where each key is unique. It allows for fast lookups based on keys.

HashSet<T>: A collection that contains unique elements and provides high-performance set operations (like union, intersection).

Queue<T>: A generic version of the non-generic queue that allows you to specify the type of elements.

Stack<T>: A generic version of the non-generic stack that allows you to specify the type of elements.

3. Concurrent Collections:

These collections are designed for use in multi-threaded environments, providing thread-safe operations.

Common concurrent collections include:

ConcurrentDictionary<TKey, TValue>: A thread-safe collection of key-value pairs.

ConcurrentQueue<T>: A thread-safe FIFO collection.

ConcurrentStack<T>: A thread-safe LIFO collection.

Example of Using Generic Collections

Here’s a simple example demonstrating the use of a List<T> and a Dictionary<TKey, TValue>:

-----------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Using List<T>
        List<string> fruits = new List<string>();
        fruits.Add("Apple");
        fruits.Add("Banana");
        fruits.Add("Cherry");

        Console.WriteLine("Fruits in the list:");
        foreach (var fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        // Using Dictionary<TKey, TValue>
        Dictionary<int, string> students = new Dictionary<int, string>();
        students.Add(1, "Alice");
        students.Add(2, "Bob");
        students.Add(3, "Charlie");

        Console.WriteLine("\nStudents in the dictionary:");
        foreach (var student in students)
        {
            Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
        }
    }
}
-----------------------------------------------------------------------------------------------------------

-> Key Features of Collections

Dynamic Sizing: Many collections, like List<T>, can grow and shrink dynamically as items are added or removed.

Type Safety: Generic collections provide compile-time type checking, reducing the risk of runtime errors.

Performance: Collections are optimized for performance, with many providing fast access and manipulation of elements.

Ease of Use: Collections come with built-in methods for common operations, making it easier to manage groups of objects.

-> Conclusion

Collections in C# are essential for managing groups of related objects efficiently and effectively. They provide a wide range of functionalities and are designed to handle various scenarios, from simple lists to complex key-value pairs. By using the appropriate collection type, developers can write cleaner, more maintainable, and more efficient code.

*/