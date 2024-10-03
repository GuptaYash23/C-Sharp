using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // Initialize a Hashtable
        Hashtable hashtable = new Hashtable();

        // Adding key-value pairs
        hashtable.Add(1, "Apple");
        hashtable.Add(2, "Banana");
        hashtable.Add(3, "Cherry");
        hashtable.Add("Four","Mango");  // Can store hetrogeneous datatype too

        // Accessing values using keys
        Console.WriteLine("\nValue for key 2: " + hashtable[2]);
        // Output: Value for key 2: Banana

        // Checking if a key exists
        bool containsKey = hashtable.ContainsKey(3);
        Console.WriteLine("\nContains key 3: " + containsKey);
        // Output: Contains key 3: True

        // Checking if a value exists
        bool containsValue = hashtable.ContainsValue("Apple");
        Console.WriteLine("\nContains value 'Apple': " + containsValue);
        // Output: Contains value 'Apple': True

        // Removing an entry by key
        hashtable.Remove(2); // Removes key 2 and its associated value
        Console.WriteLine("\nAfter removing key 2:");
        foreach (DictionaryEntry entry in hashtable)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }
        
        // Iterating hashtable keys using .Keys Method
        Console.WriteLine($"\nIterating over Hashtable keys");
        foreach(object obj in hashtable.Keys)
        {
            Console.WriteLine(obj);
            
        }

        // Output:
        // After removing key 2:
        // Key: 1, Value: Apple
        // Key: 3, Value: Cherry

        // Iterating over the Hashtable
        Console.WriteLine("\nIterating over the Hashtable:");
        foreach (DictionaryEntry entry in hashtable)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }

        foreach (object obj in hashtable.Keys)
        {
            Console.WriteLine($"Key: {obj}, Value: {hashtable[obj]}");
        }
        // Output:
        // Iterating over the Hashtable:
        // Key: 1, Value: Apple
        // Key: 3, Value: Cherry

        // Iterating hashtable keys using .Keys Method
        Console.WriteLine($"\nIterating over Hashtable values");
        foreach(object obj in hashtable.Values)
        {
            Console.WriteLine(obj);
            
        }
    }
}
