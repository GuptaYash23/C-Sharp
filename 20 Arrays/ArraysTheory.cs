/* C# Arrays

In C#, an array is a collection of elements of the same type stored in contiguous memory locations. Arrays allow you to store multiple values in a single variable and access them using indices. Each element in an array is accessed by a numeric index, starting from 0 for the first element. Arrays are reference type datatypes.

Key Features of Arrays in C#:

Fixed size: Once an array is created, its size cannot be changed.
Homogeneous elements: All elements in an array must be of the same type (e.g., int[], string[]).

Indexed: Arrays are zero-indexed, meaning the first element is accessed using index 0.

Declaring and Initializing Arrays

You can declare and initialize arrays in different ways:

1. Declaring an Array

-------------------------------------------------------------------------
int[] numbers; // Declares an array of integers
-------------------------------------------------------------------------

2. Initializing an Array

You can initialize an array in two ways:

With a specific size:

-------------------------------------------------------------------------
int[] numbers = new int[5]; // Array can hold 5 integers
-------------------------------------------------------------------------

With predefined elements:

-------------------------------------------------------------------------
int[] numbers = { 1, 2, 3, 4, 5 }; // Array with 5 elements
-------------------------------------------------------------------------

With both predefined size and elements:

-------------------------------------------------------------------------
int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
-------------------------------------------------------------------------

Accessing Array Elements

You can access array elements using their index:

-------------------------------------------------------------------------
int[] numbers = { 10, 20, 30, 40, 50 };
Console.WriteLine(numbers[0]); // Output: 10 (first element)
Console.WriteLine(numbers[4]); // Output: 50 (fifth element)
-------------------------------------------------------------------------

Modifying Array Elements

You can modify the value of an array element by assigning a new value to its index:

-------------------------------------------------------------------------
numbers[2] = 35; // Changes the third element (index 2) from 30 to 35
-------------------------------------------------------------------------

Array Length

The length of an array can be obtained using the .Length property:

-------------------------------------------------------------------------
Console.WriteLine(numbers.Length); // Output: 5 (number of elements)
-------------------------------------------------------------------------

Looping Through Arrays

You can use loops to iterate through arrays. The for loop and foreach loop are commonly used:

Using for loop:

-------------------------------------------------------------------------
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}
-------------------------------------------------------------------------

Using foreach loop:

-------------------------------------------------------------------------
foreach (int number in numbers)
{
    Console.WriteLine(number);
}
-------------------------------------------------------------------------

Multi-Dimensional Arrays

C# supports multi-dimensional arrays (arrays with more than one dimension). The most common types are two-dimensional arrays:

Declaring a 2D Array

-------------------------------------------------------------------------
int[,] matrix = new int[3, 3]; // A 3x3 array (3 rows, 3 columns)
-------------------------------------------------------------------------

Initializing a 2D array:

-------------------------------------------------------------------------
int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
-------------------------------------------------------------------------

Accessing elements in a 2D array:

-------------------------------------------------------------------------
Console.WriteLine(matrix[0, 1]); // Output: 2 (element in the first row, second column)
-------------------------------------------------------------------------

Jagged Arrays

A jagged array is an array of arrays, where each sub-array can have different sizes.

Declaring a jagged array:

-------------------------------------------------------------------------
int[][] jaggedArray = new int[3][]; // Array with 3 sub-arrays
-------------------------------------------------------------------------

Initializing a jagged array:

-------------------------------------------------------------------------
jaggedArray[0] = new int[] { 1, 2 };
jaggedArray[1] = new int[] { 3, 4, 5 };
jaggedArray[2] = new int[] { 6, 7, 8, 9 };
-------------------------------------------------------------------------

Accessing elements in a jagged array:

-------------------------------------------------------------------------
Console.WriteLine(jaggedArray[1][2]); // Output: 5 (third element of the second sub-array)
-------------------------------------------------------------------------

Summary:

Array: Collection of elements of the same type.
Fixed size: Once created, the size cannot be changed.
Access via index: First element is at index 0.
Multi-dimensional arrays: Used to represent tabular data.
Jagged arrays: Arrays of arrays where sub-arrays can vary in size.

*/