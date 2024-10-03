using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // ArrayList Initialization
        ArrayList arrayList = new ArrayList();

        // Adding elements to the ArrayList
        arrayList.Add(10);
        arrayList.Add(20);
        arrayList.Add("Hello");
        arrayList.Add(40.5);
        arrayList.Add(true);

        // Access elements using index
        Console.WriteLine("Element at index 2: " + arrayList[2]); 
        // Output: Element at index 2: Hello

        // Get the count of elements in ArrayList
        Console.WriteLine("ArrayList count: " + arrayList.Count);
        // Output: ArrayList count: 5

        // Checking if an element exists
        bool containsElement = arrayList.Contains(20); // Returns true if element exists
        Console.WriteLine("ArrayList contains 20: " + containsElement);
        // Output: ArrayList contains 20: True

        // Inserting an element at a specific index
        arrayList.Insert(2, 30); // Inserts 30 at index 2
        Console.WriteLine("ArrayList after insertion: ");
        foreach (var item in arrayList)
        {
            Console.Write(item + " ");
        }
        // Output: ArrayList after insertion:
        // 10 20 30 Hello 40.5 True 

        Console.WriteLine();

        // Removing an element
        arrayList.Remove("Hello"); // Removes the element "Hello"
        Console.WriteLine("ArrayList after removing 'Hello': ");
        foreach (var item in arrayList)
        {
            Console.Write(item + " ");
        }
        // Output: ArrayList after removing 'Hello': 
        // 10 20 30 40.5 True 

        Console.WriteLine();

        // Remove element by index
        arrayList.RemoveAt(0); // Removes element at index 0
        Console.WriteLine("ArrayList after removing element at index 0: ");
        foreach (var item in arrayList)
        {
            Console.Write(item + " ");
        }
        // Output: ArrayList after removing element at index 0: 
        // 20 30 40.5 True 

        Console.WriteLine();

        // Sorting the ArrayList (Note: Sorting works only when all elements are of comparable types)
        arrayList.Clear(); // Clear ArrayList for sorting test
        arrayList.Add(50);
        arrayList.Add(10);
        arrayList.Add(30);
        arrayList.Add(40);

        arrayList.Sort(); // Sorts in ascending order
        Console.WriteLine("ArrayList after sorting: ");
        foreach (var item in arrayList)
        {
            Console.Write(item + " ");
        }
        // Output: ArrayList after sorting: 
        // 10 30 40 50 

        Console.WriteLine();

        // Reversing the ArrayList
        arrayList.Reverse();
        Console.WriteLine("ArrayList after reversing: ");
        foreach (var item in arrayList)
        {
            Console.Write(item + " ");
        }
        // Output: ArrayList after reversing: 
        // 50 40 30 10
    }
}
