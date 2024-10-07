using System;
using System.Collections;             // For non-generic collections
using System.Collections.Generic;     // For generic collections

class Program
{
    static void Main()
    {
        // NON-GENERIC COLLECTION EXAMPLE (ArrayList)
        ArrayList nonGenericList = new ArrayList();
        nonGenericList.Add(10);         // Adding an integer
        nonGenericList.Add("Hello");    // Adding a string
        nonGenericList.Add(3.14);       // Adding a double

        Console.WriteLine("Non-Generic ArrayList:");
        foreach (object item in nonGenericList)
        {
            Console.WriteLine(item);    // Need to cast to appropriate type if required
        }

        // GENERIC COLLECTION EXAMPLE (List<T>)
        List<int> genericList = new List<int>();
        genericList.Add(10);            // Adding an integer
        genericList.Add(20);
        genericList.Add(30);

        Console.WriteLine("\nGeneric List<int>:");
        foreach (int item in genericList)
        {
            Console.WriteLine(item);    // No need for casting, as type is known
        }

        // NON-GENERIC COLLECTION EXAMPLE (Hashtable)
        Hashtable nonGenericHashTable = new Hashtable();
        nonGenericHashTable.Add(1, "One");  // Adding key-value pairs
        nonGenericHashTable.Add(2, "Two");
        nonGenericHashTable.Add(3, "Three");

        Console.WriteLine("\nNon-Generic Hashtable:");
        foreach (DictionaryEntry entry in nonGenericHashTable)
        {
            Console.WriteLine($"{entry.Key} - {entry.Value}");
        }

        // GENERIC COLLECTION EXAMPLE (Dictionary<TKey, TValue>)
        Dictionary<int, string> genericDictionary = new Dictionary<int, string>();
        genericDictionary.Add(1, "One");    // Adding key-value pairs
        genericDictionary.Add(2, "Two");
        genericDictionary.Add(3, "Three");

        Console.WriteLine("\nGeneric Dictionary<int, string>:");
        foreach (KeyValuePair<int, string> entry in genericDictionary)
        {
            Console.WriteLine($"{entry.Key} - {entry.Value}");
        }
    }
}
