using System;

class StringCollection
{
    private string[] _data = new string[5];  // Array with 5 elements

    // Define the indexer
    public string this[int index]
    {
        get
        {
            // Basic validation to prevent out-of-range access
            if (index < 0 || index >= _data.Length)
                throw new IndexOutOfRangeException("Invalid index.");
            
            return _data[index];
        }
        set
        {
            if (index < 0 || index >= _data.Length)
                throw new IndexOutOfRangeException("Invalid index.");
            
            _data[index] = value;
        }
    }
}

class Program
{
    static void Main()
    {
        StringCollection collection = new StringCollection();

        // Using the indexer to set values
        collection[0] = "Apple";
        collection[1] = "Banana";
        collection[2] = "Cherry";
        collection[3] = "Date";
        collection[4] = "Elderberry";

        // Using the indexer to get and print values
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(collection[i]);
        }
    }
}

/* Output

Apple
Banana
Cherry
Date
Elderberry


*/

/* Explanation:

The StringCollection class has a private array _data to hold five string values.

An indexer (this[int index]) is defined to allow access to this array. It has both get and set accessors.

In the Main method, we set values in the collection using the indexer (collection[0] = "Apple";) and retrieve them using the same syntax (Console.WriteLine(collection[0]);).

The code also includes basic index validation to prevent accessing elements outside the bounds of the array.

This is a straightforward example of how indexers can be used to access and manipulate data inside a class, just like working with arrays.

*/
