/* List in C# 

A list in C# is a collection that stores elements in a sequential manner. Lists are dynamic arrays, meaning they automatically resize as elements are added or removed. They allow indexing, meaning you can access elements by their position in the list, and support adding, removing, and searching elements.

C# offers two types of lists:

Non-Generic List (ArrayList)
Generic List (List<T>)

Irrespective of Non-Generic or Generic list both have the autoresize feature

1. Non-Generic List (ArrayList)

The ArrayList class is a non-generic collection from the System.Collections namespace. It stores elements as objects, so you can add items of different data types (e.g., integers, strings, etc.) to the same list.

Since all elements are treated as objects, you may need to perform type casting when retrieving data, which can lead to runtime errors if the cast fails.

Example:

---------------------------------------------------------------------------------------
ArrayList arrayList = new ArrayList();
arrayList.Add(1);         // Adding an integer
arrayList.Add("Hello");   // Adding a string
arrayList.Add(3.14);      // Adding a double

int number = (int)arrayList[0];  // Type casting required
---------------------------------------------------------------------------------------

2. Generic List (List<T>)

The List<T> class, found in the System.Collections.Generic namespace, is the preferred approach in modern C#. It is a generic collection, meaning you define a specific data type for the elements when you declare the list (e.g., List<int>, List<string>).

This makes the collection type-safe, avoiding the need for type casting and reducing the chance of runtime errors.
It offers better performance than ArrayList because it does not require boxing/unboxing for value types (e.g., int).

Example:

---------------------------------------------------------------------------------------
List<int> intList = new List<int>();
intList.Add(1);  // Adding an integer
intList.Add(2);
---------------------------------------------------------------------------------------

int number = intList[0];  // No need for type casting

Methods of ArrayList (Non-Generic List)

Add(object value): Adds an object to the end of the ArrayList.
Insert(int index, object value): Inserts an object at the specified index.

Remove(object value): Removes the first occurrence of the specified object.

RemoveAt(int index): Removes the element at the specified index.

RemoveRange(int index, int count): Removes a range of elements starting at the specified index.

Clear(): Removes all elements from the ArrayList.

Contains(object value): Checks if an object exists in the ArrayList.

IndexOf(object value): Returns the index of the first occurrence of the specified object.

Count: Returns the number of elements in the ArrayList.
Sort(): Sorts the elements in ascending order.

Reverse(): Reverses the order of elements.

Capacity: Gets or sets the number of elements that the ArrayList can contain.

Example of arraylist:

---------------------------------------------------------------------------------------
ArrayList arrayList = new ArrayList();
arrayList.Add(3);
arrayList.Add(1);
arrayList.Add(2);


arrayList.Sort();  // Sort the ArrayList
Console.WriteLine(arrayList[0]);  // Output: 1

arrayList.Remove(1);  // Remove the first occurrence of 1
Console.WriteLine(arrayList.Count);  // Output: 2
---------------------------------------------------------------------------------------

Methods of List<T> (Generic List)

Add(T item): Adds an element to the end of the List<T>.

AddRange(IEnumerable<T> collection): Adds elements from a collection to the List<T>.

Insert(int index, T item): Inserts an element at the specified index.

InsertRange(int index, IEnumerable<T> collection): Inserts elements from a collection at the specified index.

Remove(T item): Removes the first occurrence of the specified element.

RemoveAt(int index): Removes the element at the specified index.

RemoveRange(int index, int count): Removes a range of elements from the List<T>.

Clear(): Removes all elements from the List<T>.

Contains(T item): Checks if the List<T> contains the specified element.

IndexOf(T item): Returns the index of the first occurrence of the specified element.

Find(Predicate<T> match): Searches for an element that matches the conditions defined by a predicate.

Sort(): Sorts the elements of the List<T>.

Sort(Comparison<T> comparison): Sorts the elements of the List<T> based on a custom comparison.

Reverse(): Reverses the order of the elements.

Count: Returns the number of elements in the list.

Capacity: Gets or sets the number of elements the List<T> can contain. (The capacity of list doubles everytime a new list element is added if greater than the current list size (by default 1->2->4->8->16->32....))

ForEach(Action<T> action): Performs an action on each element of the List<T>.

Example of List<T> Methods:

---------------------------------------------------------------------------------------
List<int> intList = new List<int>();
intList.Add(3);
intList.Add(1);
intList.Add(2);

intList.Sort();  // Sort the list
Console.WriteLine(intList[0]);  // Output: 1

intList.Remove(1);  // Remove the first occurrence of 1
Console.WriteLine(intList.Count);  // Output: 2

intList.Reverse();  // Reverse the order
Console.WriteLine(intList[0]);  // Output: 2
---------------------------------------------------------------------------------------

Summary of Key Methods in List<T>:

Add(): Adds an element to the list.

Remove() / RemoveAt(): Removes an element from the list.
Sort(): Sorts the list in ascending order.

Reverse(): Reverses the order of the list.

Contains(): Checks if the list contains a specific element.

Count: Gets the number of elements in the list.

Conclusion:

ArrayList (non-generic) is more flexible but less efficient and less type-safe.

List<T> (generic) is type-safe, more efficient, and generally preferred in modern applications.

*/
