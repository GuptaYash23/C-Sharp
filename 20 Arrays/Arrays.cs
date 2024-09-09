using System;

class ArrayDemo
{
    static void Main()
    {
        // 1D Array
        int[] numbers = { 10, 20, 30, 40, 50 };

        // Accessing and modifying array elements
        Console.WriteLine("First element: " + numbers[0]);
        numbers[2] = 35;
        Console.WriteLine("Modified third element: " + numbers[2]);

        // Array Length
        Console.WriteLine("Array length: " + numbers.Length);

        // Looping through the array
        Console.WriteLine("Array elements:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        // 2D Array (Matrix)
        int[,] matrix = { { 1, 2 }, { 3, 4 } };
        Console.WriteLine("Matrix element at [1, 0]: " + matrix[1, 0]);

        // Jagged Array
        int[][] jaggedArray = new int[2][];
        jaggedArray[0] = new int[] { 1, 2 };
        jaggedArray[1] = new int[] { 3, 4, 5 };

        // Accessing jagged array elements
        Console.WriteLine("Jagged array element [1][2]: " + jaggedArray[1][2]);
    }
}
