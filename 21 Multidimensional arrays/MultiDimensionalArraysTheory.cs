/* C# Multidimensional arrays

In C#, a multidimensional array is an array that can hold data in more than one dimension. This allows you to organize data in tables, grids, or matrices. C# supports two types of 
multidimensional arrays:

Rectangular arrays: Arrays with fixed dimensions where each row has the same number of columns.
Jagged arrays: Arrays of arrays, where each inner array can have a different length.

1. Rectangular Arrays

A rectangular array in C# is a grid-like structure where each row has the same number of columns. It's declared with a comma between the dimensions.

Declaration and Initialization:

--------------------------------------------------------------
// 2D array (3 rows, 4 columns)
int[,] array2D = new int[3, 4];

// Initializing with values
int[,] array2D = {
    { 1, 2, 3, 4 },
    { 5, 6, 7, 8 },
    { 9, 10, 11, 12 }
};
--------------------------------------------------------------

Multiple ways of declaration and initialization:

--------------------------------------------------------------
int[,] arr = new int[3,3] = {{1,2,3},{4,5,6},{7,8,9}};

// Omitting the array size
int [,] arr = new int[,]{{1,2,3},{4,5,6},{7,8,9}};

// Omitting the new operator as well
int [,] arr = {{1,2,3},{4,5,6},{7,8,9}};
--------------------------------------------------------------

Accessing Elements:

You can access elements using row and column indices:

--------------------------------------------------------------
int value = array2D[1, 2];  // Retrieves the value at row 1, column 2 (in this case, 7)
--------------------------------------------------------------

Example of Looping through a 2D Array:

--------------------------------------------------------------
for (int i = 0; i < array2D.GetLength(0); i++) {   // Loop through rows
    for (int j = 0; j < array2D.GetLength(1); j++) { // Loop through columns
        Console.Write(array2D[i, j] + " ");
    }
    Console.WriteLine();
}
--------------------------------------------------------------

2. Jagged Arrays

A jagged array is an array of arrays. This allows rows to have different numbers of columns.

Declaration and Initialization:

--------------------------------------------------------------
// Array of arrays (jagged array)
int[][] jaggedArray = new int[3][];

// Initializing rows individually
jaggedArray[0] = new int[2] { 1, 2 };
jaggedArray[1] = new int[4] { 3, 4, 5, 6 };
jaggedArray[2] = new int[3] { 7, 8, 9 };
--------------------------------------------------------------

Accessing Elements:

You access elements by first selecting the row, and then the column within that row:

--------------------------------------------------------------
int value = jaggedArray[1][2];  // Retrieves the value at row 1, column 2 (in this case, 5)
--------------------------------------------------------------

Example of Looping through a Jagged Array:

--------------------------------------------------------------
for (int i = 0; i < jaggedArray.Length; i++) {
    for (int j = 0; j < jaggedArray[i].Length; j++) {
        Console.Write(jaggedArray[i][j] + " ");
    }
    Console.WriteLine();
}
--------------------------------------------------------------

Key Differences:

Rectangular arrays are better for fixed-dimension tables where each row has the same number of columns.
Jagged arrays allow flexibility, where each row can have a different length.

*/

/* Why you can't use a single foreach statement for a jagged array like rectangular array?

The reason you need to use two foreach loops for a jagged array is that a jagged array is essentially an array of arrays. Each element of a jagged array is itself an array, meaning you first need to iterate over the "outer" array (which contains the inner arrays), and then for each inner array, you need to iterate over its elements.

In contrast, rectangular arrays are treated as a single contiguous block of data, meaning you can directly access elements using two indices (row and column), and in a single foreach loop, C# automatically flattens the 2D structure so that you can iterate over all the elements.

*/

/* Different ways of accessing elements in rectangular array and jagged array

The difference in accessing elements between rectangular arrays and jagged arrays (rectArray[i,j] vs. jaggedArray[i][j]) stems from how these two types of arrays are structured in memory:

1. Rectangular Arrays (2D arrays):\

Rectangular arrays in C# are multidimensional arrays where all rows and columns are part of a single, contiguous block of memory. The array has a fixed number of rows and columns, and C# internally treats this as a grid where each element is indexed by two coordinates: the row (i) and the column (j).

You access elements using one pair of indices (rectArray[i, j]), because this represents a single, unified array where each element's position can be computed directly using the two indices (row and column).

Example:

--------------------------------------------------------------
int[,] rectArray = new int[3, 3] {
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};


int value = rectArray[1, 2];  // Accesses the element at row 1, column 2 (value 6)
--------------------------------------------------------------

Here, rectArray[i, j] accesses the element at the intersection of row i and column j because all the elements are stored in a grid-like structure with fixed dimensions.

2. Jagged Arrays (Array of arrays):

Jagged arrays are arrays of arrays, where each row (inner array) is a separate array object. Unlike rectangular arrays, the rows can have different lengths, and each row is stored independently in memory.

You access elements in a jagged array using two sets of indices (jaggedArray[i][j]). The first index (i) retrieves the inner array at position i, and the second index (j) accesses the element within that inner array.

Example:

--------------------------------------------------------------
int[][] jaggedArray = new int[3][] {
    new int[] { 10, 11 },
    new int[] { 12, 13, 14 },
    new int[] { 15, 16, 17, 18 }
};

int value = jaggedArray[1][2];  // Accesses the element in the 2nd inner array at index 2 (value 14)
s
--------------------------------------------------------------

Here, jaggedArray[i] accesses the entire array at position i, and jaggedArray[i][j] accesses the element at index j within that specific inner array.


Key Differences:

Rectangular arrays are contiguous in memory, and C# computes the memory offset using both i and j together, so you access elements using rectArray[i, j].

Jagged arrays consist of separate arrays in memory for each row. Therefore, you first access the array (row) using i (jaggedArray[i]) and then access the specific element using j (jaggedArray[i][j]).

Visual Representation:

Rectangular Array (2D) - Single Block of Memory:

--------------------------------------------------------------
rectArray = {
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
}

Memory layout:
1 2 3 4 5 6 7 8 9  (Contiguous block of memory)
--------------------------------------------------------------

Access: rectArray[i, j]

Jagged Array (Array of Arrays) - Separate Arrays:

--------------------------------------------------------------

jaggedArray = {
    [0] -> { 10, 11 }
    [1] -> { 12, 13, 14 }
    [2] -> { 15, 16, 17, 18 }
}

Memory layout:
Inner arrays are stored separately:
10 11  |  12 13 14  |  15 16 17 18  (Different blocks of memory)
--------------------------------------------------------------

Access: jaggedArray[i][j]

Summary:

Rectangular arrays ([,]) are stored as a contiguous block of memory, so you can access elements with a single index pair rectArray[i, j].

Jagged arrays ([][]) are arrays of arrays, so you need two separate indexing operations jaggedArray[i][j]—one to access the inner array and another to access the element inside that array.


*/