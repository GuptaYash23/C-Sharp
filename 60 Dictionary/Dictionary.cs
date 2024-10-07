using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a dictionary
        Dictionary<int, string> dict = new Dictionary<int, string>();

        // 1. Add key-value pairs to the dictionary
        dict.Add(1, "Apple");
        dict.Add(2, "Banana");
        dict.Add(3, "Cherry");

        // 2. Check if a key exists
        if (dict.ContainsKey(2))
        {
            Console.WriteLine("Key 2 exists in the dictionary.");    // Key 2 exists in the dictionary.
        }

        // 3. Try to get a value with a specific key
        if (dict.TryGetValue(3, out string value))
        {
            Console.WriteLine($"Value associated with key 3: {value}");   // Value associated with key 3: Cherry
        }

        // 4. Remove a key-value pair
        dict.Remove(1);
        Console.WriteLine("After removing key 1:");    // After removing key 1:

        // 5. Check if a value exists
        if (dict.ContainsValue("Banana"))
        {
            Console.WriteLine("Value 'Banana' exists in the dictionary.");      // Value 'Banana' exists in the dictionary.
        }

        // 6. Count the elements in the dictionary
        Console.WriteLine($"The dictionary has {dict.Count} items.");      // The dictionary has 2 items.


        // 7. Use LINQ to count items that match a condition
        int count = dict.Count(kv => kv.Value.StartsWith("B"));
        Console.WriteLine($"{count} item(s) start with 'B'.");        // 1 item(s) start with 'B'.

        // 8. Clear the dictionary
        dict.Clear();
        Console.WriteLine($"The dictionary now has {dict.Count} items after clearing.");      // The dictionary now has 0 items after clearing.
    }
}
