/* Arraylist C# 

In C#, an ArrayList is a non-generic collection class provided by the .NET framework that can hold elements of any type (i.e., it stores objects of type object). This flexibility allows an ArrayList to store items of different data types, but it comes at a cost of performance and type safety, especially when compared to generic collections like List<T>.

Here’s a detailed explanation of ArrayList:

-> Key Features of ArrayList

1. Dynamic Size: Unlike arrays, the size of an ArrayList is dynamic. You can add or remove elements, and the size will adjust automatically.

2. Non-generic: ArrayList can store elements of any data type because it stores elements as object. However, this requires boxing/unboxing for value types, which affects performance.

3. Index-based Access: Similar to arrays, elements in an ArrayList are accessed by their index, starting at 0.

4. Type Safety: Since ArrayList stores elements as object, there is no compile-time type checking. This can lead to runtime errors when retrieving and casting elements to their original types.

-> Basic Operations

1. Creating an ArrayList:

--------------------------------------------------------------------------
ArrayList arrayList = new ArrayList();'
--------------------------------------------------------------------------

2. Adding Elements: You can add elements of any type (int, string, objects, etc.).

--------------------------------------------------------------------------
arrayList.Add(1);
arrayList.Add("hello");
arrayList.Add(3.14);
--------------------------------------------------------------------------

3. Accessing Elements: Elements can be accessed using the index.

--------------------------------------------------------------------------
var firstElement = arrayList[0]; // 1
var secondElement = arrayList[1]; // "hello"
--------------------------------------------------------------------------

4. Removing Elements: Elements can be removed either by value or index.

--------------------------------------------------------------------------
arrayList.Remove("hello"); // Removes the element "hello"
arrayList.RemoveAt(0); // Removes the element at index 0
--------------------------------------------------------------------------

5. Iteration: You can loop through the elements in an ArrayList using a foreach loop.

--------------------------------------------------------------------------
foreach (var item in arrayList)
{
    Console.WriteLine(item);
}
--------------------------------------------------------------------------

-> Example:

--------------------------------------------------------------------------
using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList arrayList = new ArrayList();

        // Add elements of different types
        arrayList.Add(10);
        arrayList.Add("Hello");
        arrayList.Add(3.14);

        // Accessing elements
        Console.WriteLine(arrayList[1]); // Output: Hello

        // Remove an element
        arrayList.Remove(10);

        // Iterate through the ArrayList
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }
    }
}
--------------------------------------------------------------------------

-> Drawbacks of ArrayList

Performance: ArrayList is slower than List<T> because it involves boxing/unboxing for value types and lacks type safety.

Type Safety: Since it stores elements as object, there is no compile-time checking, which can lead to runtime errors.

-> Alternative: List<T>

In most modern C# applications, it's recommended to use the generic List<T> instead of ArrayList, because:

Type safety: List<T> ensures type safety at compile time.

Performance: No boxing/unboxing for value types, leading to better performance.

Generics: You can specify the data type for the list, making it more type-safe and easier to work with.

-> For example:

--------------------------------------------------------------------------
List<int> list = new List<int>();
list.Add(1);
list.Add(2);
int firstItem = list[0];
--------------------------------------------------------------------------

In summary, while ArrayList is flexible, it is generally recommended to use List<T> in modern C# programming for better performance and type safety.

*/