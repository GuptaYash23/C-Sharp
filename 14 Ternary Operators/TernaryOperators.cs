using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Ternary Operators [condition?ValueIfTrue:ValueIfFalse]

            int a = 10;
            int b = 20;
            int max = (a > b) ? a : b; // max will be 20s

            Console.WriteLine(max);    // 20

            // Null Coalescing Operator [value ?? defaultValue;]

            string name = null;
            string displayName = name ?? "Guest"; // displayName will be "Guest"

            Console.WriteLine(displayName);  // Guest

            // Null Coalescing Assignment Operator [variable ??= value;]

            string username = null;
            username ??= "Default Name"; // username will be "Default Name"

            Console.WriteLine(username); // Default Name

        }
    }
}