using System;

class Program
{
    static void Main()
    {
        // Rectangular Array (2D)
        int[,] rectArray = new int[3, 3] {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        // Jagged Array (Array of arrays)
        int[][] jaggedArray = new int[3][] {
            new int[] { 10, 11 },
            new int[] { 12, 13, 14 },
            new int[] { 15, 16, 17, 18 }
        };

        // Accessing and printing elements from the Rectangular Array
        Console.WriteLine("Rectangular Array:");
        for (int i = 0; i < rectArray.GetLength(0); i++)  // Loop through rows
        {
            for (int j = 0; j < rectArray.GetLength(1); j++)  // Loop through columns
            {
                Console.Write(rectArray[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Using foreach loop for rectangular array");

        // Using foreach loop in multidimensional array
        // Flattens multidimensional array into a single row array

        foreach (int element in rectArray)
        {
            Console.Write(element + " ");
        }

        Console.WriteLine();

        // Accessing and printing elements from the Jagged Array
        Console.WriteLine("Jagged Array:");
        for (int i = 0; i < jaggedArray.Length; i++)  // Loop through rows
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)  // Loop through elements in each row
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }

        // Using foreach loop in jagged array

        Console.WriteLine("Using foreach loop for jagged array");

        foreach (int[] innerArray in jaggedArray)
        {
            foreach (int element in innerArray)
            {
                Console.Write(element + " ");
            }
        }
    }
}
