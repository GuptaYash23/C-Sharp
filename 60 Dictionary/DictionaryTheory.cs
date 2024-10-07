/* Dictionary

Dictionary is generic Hashtable which is type safe and stores data in key value format where keys are user-defined. Syntax is Dictionary<Tkey,Tvalue>.

foreach loop KeyValuePair<T,T> item(item.key,item.value)/var item (item.key, item.value)

The working of dictionary is quite similar to the non-generic hashtable

It is dynamic in nature

Important properties of dictionary

.Add, .Remove(), .Count(), .Count(LamdaExpression/Predicate), .ContainsKey(), .ContainsValue(), .Clear(), .TryGetValue()

out keyword

In dictionary keys are unique (duplicate keys are not allowed and compiler will throw an exception)

In dictionary key cannot be null but value can be null (if key is null we will get an error at run time)

Capacity of the dictionary is the number of elements it can hold

*/


/* Dictionary 

A Dictionary<TKey, TValue> in C# is a collection of key-value pairs, where each key is unique and is used to access the corresponding value. It provides fast lookups, insertions, and deletions based on keys. It is part of the System.Collections.Generic namespace.

-> Key Features:

Key-Value Pairs: The Dictionary stores data in key-value pairs where each key is unique.

Fast Lookup: Uses a hash table internally, so lookup times for values based on their keys are very efficient (on average O(1)).

No Duplicates: You cannot have duplicate keys in a Dictionary. However, values can be duplicated.

Generic: The types for both the key and value are specified when creating the dictionary (Dictionary<TKey, TValue>).

-> Dictionary Methods and Properties

1. Add(TKey key, TValue value)

Purpose: Adds a new key-value pair to the dictionary.

Exception: Throws an exception if the key already exists in the dictionary.

-------------------------------------------------------------------------------------
Dictionary<int, string> dict = new Dictionary<int, string>();
dict.Add(1, "Apple");
dict.Add(2, "Banana");
-------------------------------------------------------------------------------------

2. Remove(TKey key)

Purpose: Removes the element with the specified key from the dictionary.

Returns: true if the element is successfully found and removed; otherwise, false.

-------------------------------------------------------------------------------------
dict.Remove(1);  // Removes the key-value pair with key 1
-------------------------------------------------------------------------------------

3. Count

Purpose: Gets the number of key-value pairs currently in the dictionary.

-------------------------------------------------------------------------------------
int count = dict.Count;  // Returns the number of items in the dictionary
-------------------------------------------------------------------------------------

4. ContainsKey(TKey key)

Purpose: Determines whether the dictionary contains the specified key.

Returns: true if the dictionary contains the key, otherwise false.

-------------------------------------------------------------------------------------
bool hasKey = dict.ContainsKey(2);  // Checks if key 2 exists
-------------------------------------------------------------------------------------

5. ContainsValue(TValue value)

Purpose: Determines whether the dictionary contains the specified value.

Returns: true if the dictionary contains the value, otherwise false.

-------------------------------------------------------------------------------------
bool hasValue = dict.ContainsValue("Banana");  // Checks if value "Banana" exists
-------------------------------------------------------------------------------------

6. Clear()

Purpose: Removes all key-value pairs from the dictionary.

-------------------------------------------------------------------------------------
dict.Clear();  // Clears the entire dictionary
-------------------------------------------------------------------------------------

7. TryGetValue(TKey key, out TValue value)

Purpose: Tries to get the value associated with the specified key without throwing an exception if the key is not found.

Returns: true if the key is found, otherwise false. If found, the corresponding value is returned through the out parameter.

-------------------------------------------------------------------------------------
string value;
bool result = dict.TryGetValue(2, out value);  // Tries to get value for key 2
-------------------------------------------------------------------------------------

8. Count(predicate) (Custom Method using LINQ)

Purpose: Counts the number of elements in the dictionary that match a specified condition (using LINQ).

-------------------------------------------------------------------------------------
int count = dict.Count(kv => kv.Value.StartsWith("B"));  // Counts values starting with "B"
-------------------------------------------------------------------------------------

-> Unique Properties of Dictionary

1. Key Uniqueness: Every key in the dictionary must be unique. If you attempt to add a duplicate key, it will throw an ArgumentException.

2. Efficient Lookup: Since Dictionary<TKey, TValue> uses a hash table internally, lookup operations are very fast (average O(1)) when retrieving values based on keys.

3. Dynamic Resizing: The size of the dictionary automatically adjusts as elements are added or removed.

4. Unordered Collection: The order of the key-value pairs in a dictionary is not guaranteed. They are not stored in the order they were added, but rather based on their hashed positions.

5. Custom Equality Comparer: You can provide a custom equality comparer when creating the dictionary, allowing you to control how the keys are compared.

*/