using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // If-Else statements
            int x = 10;
            if (x < 5)
            {
                Console.WriteLine("x is less than 5");
            }
            else if (x == 10)
            {
                Console.WriteLine("x is equal to 10");  // x is equal to 10
            }
            else
            {
                Console.WriteLine("x is greater than 5 but not 10");
            }

            // Switch Statements
            int day = 3;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");  // Wednesday
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }

            // Ternary Operators
            int y = 10;
            string result = (y > 5) ? "y is greater than 5" : "y is less than or equal to 5";
            Console.WriteLine(result); // Output: "y is greater than 5"

            // Null-Coalescing Operator
            string name = null;
            string displayName = name ?? "Guest";
            Console.WriteLine(displayName); // Output: "Guest"

            // Switch Expression
            int holiday = 3;
            string dayName = holiday switch
            {
                1 => "Monday",
                2 => "Tuesday",
                3 => "Wednesday",
                _ => "Invalid day"
            };
            Console.WriteLine(dayName); // Output: "Wednesday"
        }
    }
}
