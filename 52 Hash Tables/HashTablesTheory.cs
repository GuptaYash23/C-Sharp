/* Hash table collection

C# includes Hashtable collection in System.Collections namespace.

We can store both homogeneous and hetrogeneous elements in hash table. Hast table stores data in key/value format

In HashTable, keys are not pre-defined it means you can explicitly define user-defined keys in Hashtable.

The HashTable collection stores key-value pairs.

The Hashtable class represents a collection key-and-value pairs that are organized based on the hash code of the key.

A hash table is used when you need to access elements by using key, and you can identify a useful key value.

Each item in the hash table has a key/value pair. The key is used to access the itmes in the collection.

.Keys property gets all the keys in the HashTable

.Values property gets all the values in the HashTable

-> Methods of HashTable

1. Add: Adds an item with a key and value into the hashtable.

2. Remove: Removes the item with the specified key from the hashtable.

3. Clear: Removes all the items from the Hashtable

4. Contains: Checks whether the hashtable contains a specific key

5. ContainsKey: Checks whether the hashtable contains a specific key

6. ContainsValue: Checks whether the hashtable contains a specific value

7. GetHashCode: Returns the hashcode for a specified key (hash code is an integer value attached to a key, used to find keys/values using hash code) [ Hashtables used Hashing algorithms to generate hash codes for every key and because of these hash codes hash tables are faster than Array and Arraylist]

*/

/* Hashtable in detail

In C#, a Hashtable is a collection that stores key-value pairs and allows fast lookups, additions, and deletions based on the key. The keys are used to access the corresponding values efficiently, thanks to the use of a hashing algorithm, which gives Hashtable its name.

Here’s a detailed explanation of Hashtable in C#:

-> Key Features of Hashtable:

1. Key-Value Pairs: A Hashtable stores data as key-value pairs. The keys must be unique, but the values can be duplicated.

2. Fast Access: A Hashtable uses a hash function to compute an index into an array of buckets or slots, making the process of finding values very fast (almost constant time on average).

3. Non-generic: Like ArrayList, Hashtable is non-generic, meaning it can store objects of any type, but with performance drawbacks like boxing/unboxing for value types and no compile-time type safety.

4. Resizable: It dynamically resizes itself when necessary, similar to ArrayList.

-> When to Use Hashtable:

When you need fast access to data based on keys.

When the data involves key-value pairs and the keys are unique.

When you don't need type safety or generics (for type safety, consider Dictionary<TKey, TValue> instead).

-> Example of a Hashtable:

-------------------------------------------------------------------------------
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

        // Accessing values using keys
        Console.WriteLine("Value for key 2: " + hashtable[2]);
        // Output: Value for key 2: Banana

        // Checking if a key exists
        bool containsKey = hashtable.ContainsKey(3);
        Console.WriteLine("Contains key 3: " + containsKey);
        // Output: Contains key 3: True

        // Checking if a value exists
        bool containsValue = hashtable.ContainsValue("Apple");
        Console.WriteLine("Contains value 'Apple': " + containsValue);
        // Output: Contains value 'Apple': True

        // Removing an entry by key
        hashtable.Remove(2); // Removes key 2 and its associated value
        Console.WriteLine("After removing key 2:");
        foreach (DictionaryEntry entry in hashtable)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }
        // Output:
        // After removing key 2:
        // Key: 1, Value: Apple
        // Key: 3, Value: Cherry

        // Iterating over the Hashtable
        Console.WriteLine("Iterating over the Hashtable:");
        foreach (DictionaryEntry entry in hashtable)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }
        // Output:
        // Iterating over the Hashtable:
        // Key: 1, Value: Apple
        // Key: 3, Value: Cherry
    }
}
-------------------------------------------------------------------------------

-> Important Methods and Properties:

1. Add(key, value): Adds a key-value pair to the Hashtable.

-------------------------------------------------------------------------------
hashtable.Add(1, "Apple");
-------------------------------------------------------------------------------

2. [key] (Indexer): Accesses the value associated with the specified key.

-------------------------------------------------------------------------------
Console.WriteLine(hashtable[1]); // Output: Apple
-------------------------------------------------------------------------------

3. Remove(key): Removes the key-value pair with the specified key.

-------------------------------------------------------------------------------
hashtable.Remove(2); // Removes key 2 and its value
-------------------------------------------------------------------------------

4. ContainsKey(key): Checks if a specific key exists in the Hashtable.

-------------------------------------------------------------------------------
hashtable.ContainsKey(3); // Returns true if key 3 exists
-------------------------------------------------------------------------------

5. ContainsValue(value): Checks if a specific value exists in the Hashtable.

-------------------------------------------------------------------------------
hashtable.ContainsValue("Apple"); // Returns true if value "Apple" exists
-------------------------------------------------------------------------------

6. Count: Gets the number of key-value pairs in the Hashtable.

-------------------------------------------------------------------------------
int count = hashtable.Count; // Returns the total number of elements
-------------------------------------------------------------------------------

7. Iteration: You can iterate over the key-value pairs in the Hashtable using a foreach loop and DictionaryEntry.

-------------------------------------------------------------------------------
foreach (DictionaryEntry entry in hashtable)
{
    Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
}
-------------------------------------------------------------------------------

-> Drawbacks of Hashtable:

1. Non-generic: Since it is non-generic, all keys and values are stored as object, which requires casting when retrieving data and results in potential runtime errors. For type safety, you should use the Dictionary<TKey, TValue> generic collection.

2. Performance: It suffers from the overhead of boxing/unboxing when storing value types. A generic Dictionary<TKey, TValue> avoids this issue.

3. Less Modern: In modern C# development, Hashtable is often replaced by Dictionary<TKey, TValue> because Dictionary is more efficient and type-safe.

-> Generic Alternative: Dictionary<TKey, TValue>

In modern C#, it is recommended to use Dictionary<TKey, TValue>, which is a generic version of Hashtable, providing better performance and type safety. Here’s a quick example:

-------------------------------------------------------------------------------
Dictionary<int, string> dictionary = new Dictionary<int, string>();
dictionary.Add(1, "Apple");
dictionary.Add(2, "Banana");

Console.WriteLine(dictionary[1]); // Output: Apple
-------------------------------------------------------------------------------

Conclusion:

Hashtable is a key-value collection that offers fast lookups and flexibility with non-generic types.

It is less commonly used in modern C# due to the existence of Dictionary<TKey, TValue>, which is faster and type-safe.

*/

/* DictionaryEntry keyword

DictionaryEntry is a structure in C# that represents a key-value pair in collections such as Hashtable or other non-generic dictionary-like collections that implement the IDictionary interface. When you iterate over a Hashtable or other similar collections using a foreach loop, each item is represented as a DictionaryEntry object.

Key Points About DictionaryEntry:

Key-Value Pair: Each DictionaryEntry object holds two properties:

Key: Represents the key of the key-value pair.

Value: Represents the corresponding value of the key.

Used in Non-Generic Collections: It is typically used when iterating over non-generic collections like Hashtable, which store items as object. This structure allows you to access both the key and value in each iteration of the loop.

Struct: DictionaryEntry is a value type (struct), meaning it holds its data directly rather than referencing it.

For example:

-------------------------------------------------------------------------------
// Iterating over the Hashtable using DictionaryEntry
    foreach (DictionaryEntry entry in hashtable)
    {
        // Accessing the Key and Value properties
        Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
    }
-------------------------------------------------------------------------------

*/

/* Hashtable key-value pairs order is not preserved

In C#, when you use a Hashtable, the order of the key-value pairs is not preserved. This behavior happens because a Hashtable is designed for fast lookups, insertions, and deletions based on the key, rather than maintaining the order of insertion. The internal structure of a Hashtable uses a hashing algorithm to organize data into "buckets," which means:

-> Reasons Why Hashtable Does Not Maintain Order (because of hashcodes):

Hashing Mechanism: A Hashtable internally uses a hash function to determine where to store each key-value pair. This process involves computing a hash code for each key, which maps the key to a particular "bucket" in the internal data structure. This means the position of the elements is determined by the hash code of the keys, not by the order in which you added them.

Performance Optimization: The primary goal of a Hashtable is to offer fast access times, typically near constant time (O(1)) for lookups, insertions, and deletions. To achieve this, it sacrifices maintaining the order of elements. Maintaining order would require additional overhead, such as storing elements in a separate list or linked structure.

Non-Sequential Storage: Keys in a Hashtable are not stored in a sequential manner. They are distributed across buckets based on the hash code of the key, and the bucket chosen can seem random from the perspective of insertion order.

For ordered collections we can use

SortedList<TKey, TValue>, SortedDictionary<TKey, TValue>, Dictionary<TKey, TValue>, List<KeyValuePair<TKey, TValue>>

*/