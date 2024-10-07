/* Non Generic and Generic Collections

In C#, collections are divided into two categories: generic and non-generic collections. The primary difference between these two lies in how they store and manage data.

1. Non-Generic Collections:

Non-generic collections can store any type of object, meaning that they do not enforce type safety at compile time. Since they work with objects, when value types are added, boxing occurs (converting a value type to an object), and when retrieving, unboxing happens (converting an object back to a value type). This process can have performance drawbacks and may lead to runtime errors.

Non-generic collections are located in the System.Collections namespace.

-> Common Non-Generic Collections:

- ArrayList
- Hashtable
- Queue
- Stack

-> Example of a Non-Generic Collection (ArrayList):

--------------------------------------------------------------------------
using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList arrayList = new ArrayList();

        // Adding elements of different types
        arrayList.Add(1);          // int
        arrayList.Add("Hello");    // string
        arrayList.Add(3.14);       // double

        // Accessing elements requires casting
        int firstElement = (int)arrayList[0];  // Unboxing
        string secondElement = (string)arrayList[1];

        Console.WriteLine("First element: " + firstElement);
        Console.WriteLine("Second element: " + secondElement);
    }
}
--------------------------------------------------------------------------

Characteristics of Non-Generic Collections:

Type Safety: Not enforced. They can store any data type, and type casting is required when retrieving elements.

Boxing/Unboxing: Value types are boxed when added and unboxed when retrieved, causing performance overhead.

Performance: Generally slower due to boxing, unboxing, and the lack of compile-time type checks.

Error-Prone: Can lead to runtime errors if the wrong type is cast from an object.

2. Generic Collections:

Generic collections are strongly typed, meaning they enforce type safety at compile time. When you declare a generic collection, you specify the type of elements it will store. This eliminates the need for boxing/unboxing, improves performance, and prevents runtime errors due to incorrect type casting.

Generic collections are located in the System.Collections.Generic namespace.

-> Common Generic Collections:\

- List<T>
- Dictionary<TKey, TValue>
- Queue<T>
- Stack<T>

Example of a Generic Collection (List<T>):

--------------------------------------------------------------------------
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> intList = new List<int>();

        // Adding elements to a strongly-typed list
        intList.Add(1);    // int
        intList.Add(2);
        intList.Add(3);

        // No need for casting when retrieving elements
        int firstElement = intList[0];
        int secondElement = intList[1];

        Console.WriteLine("First element: " + firstElement);
        Console.WriteLine("Second element: " + secondElement);
    }
}
--------------------------------------------------------------------------

Characteristics of Generic Collections:

Type Safety: Enforced at compile time. You can only store objects of the specified type, preventing type mismatch errors.

Boxing/Unboxing: Eliminated for value types, leading to better performance.

Performance: Generally faster due to the absence of boxing/unboxing and compile-time type checks.

Maintainability: Code is easier to maintain since type-related bugs are caught at compile time.

Generic Collections Advantage:

Generic collections are preferred in modern C# programming due to their type safety, better performance, and ability to prevent runtime errors caused by incorrect type casting. They offer a more efficient and maintainable way to work with collections, especially when dealing with value types or large datasets.

Summary:

Non-generic collections can store any type of data but require casting and have performance overhead due to boxing/unboxing.
Generic collections are strongly typed, avoid boxing/unboxing, and offer better performance and type safety.

*/

/* Difference between Non-Generic and Generic

-> Type Safety:

Non-Generic Collections: Non-generic collections do not enforce type safety. They can store objects of any type (object), meaning you can add integers, strings, objects, etc., to the same collection. Since the compiler does not check types, type-related issues can occur at runtime, especially when retrieving elements and casting them back to their original types. For example, an ArrayList can store int, string, double, and other types together.

-> Generic Collections: Generic collections enforce type safety at compile time. When declaring a generic collection, you specify the data type (e.g., List<int>), and only elements of that type can be added. This prevents type-related issues and reduces the risk of runtime errors caused by incorrect type casting. For example, a List<int> only allows storing int values.

-> Namespace:

Non-Generic Collections: Non-generic collections are part of the System.Collections namespace. These collections were introduced before C# had generics, offering flexibility in storing different data types, but lacking type-specific safety. Examples include ArrayList, Hashtable, Queue, and Stack.

Generic Collections: Generic collections are part of the System.Collections.Generic namespace. Introduced in .NET 2.0, they provide strongly-typed collections, improving performance and type safety. Examples include List<T>, Dictionary<TKey, TValue>, Queue<T>, and Stack<T>.

-> Boxing/Unboxing:

Non-Generic Collections: Non-generic collections require boxing and unboxing for value types. When a value type (e.g., int, bool, double) is added to a non-generic collection, it is boxed (converted to an object). When retrieving the value, it must be unboxed (converted back to its original type). This process adds overhead, slowing down performance.

Generic Collections: Generic collections do not require boxing and unboxing because they are type-specific. Value types are stored directly without being converted to object. This leads to better performance, especially in high-volume operations involving value types.

-> Type Casting:

Non-Generic Collections: Since non-generic collections store all elements as object, type casting is required when retrieving elements. You must manually cast the retrieved object to its original type. Incorrect casting can lead to runtime exceptions (e.g., InvalidCastException), making it error-prone.

Generic Collections: No type casting is needed with generic collections. Since they are strongly typed, the retrieved element is automatically of the correct type. This simplifies the code and reduces the risk of type-related runtime errors.

-> Performance:

Non-Generic Collections: Non-generic collections typically have slower performance due to the overhead of boxing/unboxing and type casting. Every time a value type is added or retrieved, the system performs extra operations to convert between object and the original type.

Generic Collections: Generic collections offer better performance, as they eliminate the need for boxing/unboxing and type casting. Operations are faster, especially when working with large datasets or collections of value types.

-> Error-Prone:

Non-Generic Collections: Non-generic collections are more error-prone due to the lack of type safety. Since they can store any type of object, type mismatches can lead to runtime errors. For instance, you might try to cast a string to an integer, which would cause an exception.

Generic Collections: Generic collections are less error-prone because type mismatches are caught at compile time. Since only the specified type can be added to the collection, many potential errors are avoided before the program runs.

-> Code Maintainability:

Non-Generic Collections: Maintaining code with non-generic collections can be more difficult because you need to manually handle type casting, boxing, and unboxing. If the expected data types change, you need to update all related type casts throughout the code. Debugging can also be harder since runtime exceptions related to incorrect casts may be harder to trace.

Generic Collections: Code that uses generic collections is easier to maintain. Since type safety is enforced at compile time, potential type errors are caught early, making the code more predictable and less prone to bugs. Additionally, if the collection's data type changes, the compiler will point out any issues, helping ensure consistency.

-> Flexibility:

Non-Generic Collections: Non-generic collections offer more flexibility, as they can store objects of different types in the same collection. This can be useful in scenarios where you need to store multiple types of data. However, this flexibility comes at the cost of type safety and performance.

Generic Collections: Generic collections are less flexible because they are type-specific. You can only store elements of a single specified type in the collection. For example, a List<int> can only store integers. This ensures type safety but limits flexibility compared to non-generic collections.

-> Common Use Cases:

Non-Generic Collections: Non-generic collections are often found in legacy codebases or in situations where flexibility in data types is required. They are useful when the type of data is not known at compile time or when multiple types of data need to be stored in the same collection. Non-generic collections like Hashtable are still used for key-value pairs but are mostly replaced by generic collections in modern applications.

Generic Collections: Generic collections are preferred in modern development due to their performance, type safety, and maintainability. They are commonly used in data-intensive and type-sensitive applications. Collections like List<T>, Dictionary<TKey, TValue>, and HashSet<T> are widely used in situations where type safety, performance, and efficiency are crucial.

Examples:

Non-Generic Collections: Examples include ArrayList, Hashtable, Queue, and Stack.

Generic Collections: Examples include List<T>, Dictionary<TKey, TValue>, Queue<T>, and Stack<T>.

*/