using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list of integers
        List<int> numbers = new List<int>();

        // 1. Add individual elements
        numbers.Add(10);
        numbers.Add(5);
        numbers.Add(20);
        numbers.Add(15);
        Console.WriteLine("After Add:");
        DisplayList(numbers);                            // After Add: 10 5 20 15 

        // 2. Sort the list
        numbers.Sort();
        Console.WriteLine("\nAfter Sort:");
        DisplayList(numbers);                           // After Sort: 5 10 15 20     

        // 3. Add a range of elements
        numbers.AddRange(new List<int> { 30, 40, 50 });
        Console.WriteLine("\nAfter AddRange:");
        DisplayList(numbers);                          // After AddRange: 5 10 15 20 30 40 50

        // 4. Insert an element at a specific index
        numbers.Insert(2, 12);
        Console.WriteLine("\nAfter Insert at index 2:");
        DisplayList(numbers);                          // After Insert at index 2: 5 10 12 15 20 30 40 50 

        // 5. Insert a range of elements at a specific index
        numbers.InsertRange(4, new List<int> { 25, 35 });
        Console.WriteLine("\nAfter InsertRange at index 4:"); 
        DisplayList(numbers);                          // After InsertRange at index 4: 5 10 12 15 25 35 20 30 40 50 

        // 6. Remove a specific element
        numbers.Remove(20);
        Console.WriteLine("\nAfter Remove element 20:");
        DisplayList(numbers);                          // After Remove element 20: 5 10 12 15 25 35 30 40 50 

        // 7. Remove an element at a specific index
        numbers.RemoveAt(3);  // Remove element at index 3
        Console.WriteLine("\nAfter RemoveAt index 3:");  
        DisplayList(numbers);                           // After RemoveAt index 3: 5 10 12 25 35 30 40 50 

        // 8. Remove a range of elements
        numbers.RemoveRange(2, 2);  // Remove 2 elements starting at index 2
        Console.WriteLine("\nAfter RemoveRange starting at index 2:");
        DisplayList(numbers);                           // After RemoveRange starting at index 2: 5 10 35 30 40 50 

        // 9. Remove all elements that match a condition
        numbers.RemoveAll(x => x > 30);  // Remove all elements greater than 30
        Console.WriteLine("\nAfter RemoveAll (elements > 30):");
        DisplayList(numbers);                            // After RemoveAll (elements > 30): 5 10 30 

        // 10. Contains method
        bool containsValue = numbers.Contains(15);
        Console.WriteLine($"\nContains 15? {containsValue}");   // Contains 15? False

        // 11. Reverse the list
        numbers.Reverse();
        Console.WriteLine("\nAfter Reverse:");
        DisplayList(numbers);                              // After Reverse: 30 10 5 


        // 12. IndexOf (first occurrence)
        int indexOf15 = numbers.IndexOf(15);
        Console.WriteLine($"\nIndexOf 15: {indexOf15}");    // IndexOf 15: -1

        // 13. IndexOf (first occurrence starting from a specific index)
        int indexOf15FromIndex2 = numbers.IndexOf(15, 2);
        Console.WriteLine($"\nIndexOf 15 from index 2: {indexOf15FromIndex2}");   //IndexOf 15 from index 2: -1

        // 14. LastIndexOf
        int lastIndexOf15 = numbers.LastIndexOf(15);
        Console.WriteLine($"\nLastIndexOf 15: {lastIndexOf15}");            // LastIndexOf 15: -1

        // 15. Clear the list
        numbers.Clear();
        Console.WriteLine("\nAfter Clear:");
        DisplayList(numbers);                                 // After Clear:

        // Add back some elements for further methods
        numbers.AddRange(new List<int> { 10, 15, 25, 15, 30, 40, 50 });

        // 16. Find the first element that matches a condition
        int findResult = numbers.Find(x => x > 20);
        Console.WriteLine($"\nFind first element > 20: {findResult}");    // Find first element > 20: 25

        // 17. Find the last element that matches a condition
        int findLastResult = numbers.FindLast(x => x > 20);
        Console.WriteLine($"\nFind last element > 20: {findLastResult}");  // Find last element > 20: 50

        // 18. Find all elements that match a condition
        List<int> findAllResult = numbers.FindAll(x => x > 20);
        Console.WriteLine("\nFind all elements > 20:");
        DisplayList(findAllResult);                              // Find all elements > 20: 25 30 40 50 

        // 19. FindIndex (first occurrence)
        int findIndexResult = numbers.FindIndex(x => x == 15);
        Console.WriteLine($"\nFindIndex of 15: {findIndexResult}");  // FindIndex of 15: 1

        // 20. FindLastIndex
        int findLastIndexResult = numbers.FindLastIndex(x => x == 15);
        Console.WriteLine($"\nFindLastIndex of 15: {findLastIndexResult}");  // FindLastIndex of 15: 3

        // 21. Convert list to array
        int[] arrayResult = numbers.ToArray();
        Console.WriteLine("\nToArray result:");
        DisplayArray(arrayResult);                  // ToArray result: 10 15 25 15 30 40 50 

        // 22. Convert array back to list
        List<int> listResult = arrayResult.ToList();
        Console.WriteLine("\nToList result:");
        DisplayList(listResult);                   // ToList result: 10 15 25 15 30 40 50 
    }

    // Helper method to display a list
    static void DisplayList(List<int> list)
    {
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    // Helper method to display an array
    static void DisplayArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}


/* Summary

Explanation:

Add(): Adds individual elements to the list.

Sort(): Sorts the list in ascending order.

AddRange(): Adds a collection of elements to the end of the list.

Insert(): Inserts an element at a specific index.

InsertRange(): Inserts a collection of elements at a specific index.

Remove(): Removes the first occurrence of a specific element.

RemoveAt(): Removes an element at a specific index.

RemoveRange(): Removes a range of elements starting at a specified index.

RemoveAll(): Removes all elements that match a condition.

Contains(): Checks if an element exists in the list.

Reverse(): Reverses the order of elements in the list.

IndexOf(): Finds the index of the first occurrence of an element.

IndexOf(element, startIndex): Finds the index of the first occurrence of an element starting at a specified index.

LastIndexOf(): Finds the index of the last occurrence of an element.

Clear(): Removes all elements from the list.

Find(): Finds the first element that matches a condition.

FindLast(): Finds the last element that matches a condition.

FindAll(): Finds all elements that match a condition.

FindIndex(): Finds the index of the first occurrence of an element that matches a condition.

FindLastIndex(): Finds the index of the last occurrence of an element that matches a condition.

ToArray(): Converts the list to an array.

ToList(): Converts an array back to a list.

*/