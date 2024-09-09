using System;

class LoopExample
{
    static void Main()
    {
        // 1. 'for' loop - Prints numbers from 1 to 5
        Console.WriteLine("For Loop:");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i); // Output: 1 2 3 4 5
        }

        // 2. 'while' loop - Prints numbers from 6 to 10
        Console.WriteLine("While Loop:");
        int j = 6;
        while (j <= 10)
        {
            Console.WriteLine(j); // Output: 6 7 8 9 10
            j++;
        }

        // 3. 'do-while' loop - Prints numbers from 11 to 15
        Console.WriteLine("Do-While Loop:");
        int k = 11;
        do
        {
            Console.WriteLine(k); // Output: 11 12 13 14 15
            k++;
        } while (k <= 15);

        // 4. 'foreach' loop - Iterates over an array of numbers
        Console.WriteLine("Foreach Loop:");
        int[] numbers = { 16, 17, 18, 19, 20 };
        foreach (int number in numbers)
        {
            Console.WriteLine(number); // Output: 16 17 18 19 20
        }

        Console.ReadKey();
    }
}
