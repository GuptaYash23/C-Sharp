/* Indexers

In C#, indexers allow instances of a class or struct to be indexed just like arrays. They enable an object to be accessed using array-like syntax, which improves readability and ease of use. Instead of calling a method to get or set values, you can use the square bracket notation ([]) with an index.

Here's a simple breakdown:

Syntax:

An indexer is defined using the this keyword, followed by the parameter list (typically the index). It has both get and set accessors, similar to properties.

-------------------------------------------------------
class ClassName
{
    // Define the indexer
    [modifier] dataType this[indexType index]
    {
        get
        {
            // Return the value at the specified index
        }
        set
        {
            // Set the value at the specified index
        }
    }
}
-------------------------------------------------------

Breakdown:

dataType: The type of value that the indexer will return or set (e.g., int, string, object, etc.).

this: The keyword used to define an indexer.

indexType: The type of the index parameter(s), such as int.

get accessor: Used to retrieve the value based on the index.

set accessor: Used to assign a value to the specified index.


Example:

-------------------------------------------------------
class SampleCollection
{
    private string[] _array = new string[100];  // backing array

    // Define the indexer
    public string this[int index]
    {
        get
        {
            return _array[index];
        }
        set
        {
            _array[index] = value;
        }
    }
}

class Program
{
    static void Main()
    {
        var collection = new SampleCollection();
        collection[0] = "Hello"; // Using the indexer to set a value
        Console.WriteLine(collection[0]); // Using the indexer to get a value
    }
}
-------------------------------------------------------

Key Points:

Indexer Declaration: The indexer is defined using this[] followed by the index type(s). In the example above, the index type is int.

Get/Set Accessors: Like properties, indexers can have get and set accessors.

Parameter Type: Indexers can take multiple parameters, not just integers. You can create multi-dimensional indexers by defining multiple parameters.

Flexibility: Indexers allow objects to behave like arrays or collections, providing an intuitive syntax for accessing elements.

Example of Multi-dimensional Indexer:

-------------------------------------------------------
class Matrix
{
    private int[,] _matrix = new int[10, 10];

    public int this[int row, int col]
    {
        get { return _matrix[row, col]; }
        set { _matrix[row, col] = value; }
    }
}
-------------------------------------------------------

Here, the indexer takes two arguments, row and col, allowing for multi-dimensional access like in a 2D array.

*/