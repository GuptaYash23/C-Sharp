using System;

namespace ConsoleApp
{
    public class Program
    {
        public static int add(int a, int b)
        {
            return a + b;
        }

        public static int diff(int a, int b)
        {
            return a - b;
        }

        public static int multiply(int a, int b)
        {
            return a * b;
        }

        public static int division(int a, int b)
        {
            // Optional: Add a check to prevent division by zero
            if (b == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return 0; // or throw an exception
            }
            return a / b;
        }

        public static void Main(string[] args)
        {
            int num1, num2;

            string repeat = "yes";

            while (repeat == "yes")
            {
                Console.WriteLine("Enter the first number: ");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the second number: ");
                num2 = int.Parse(Console.ReadLine());

                string op;

                Console.WriteLine("What operation to perform? "); // Added missing semicolon
                op = Console.ReadLine();

                if (op == "+") // Changed to string comparison
                {
                    Console.WriteLine("The sum of two numbers is " + add(num1, num2));
                }
                else if (op == "-")
                {
                    Console.WriteLine("The difference of two numbers is " + diff(num1, num2));
                }
                else if (op == "*")
                {
                    Console.WriteLine("The multiplication of two numbers is " + multiply(num1, num2));
                }
                else if (op == "/")
                {
                    Console.WriteLine("The division of two numbers is " + division(num1, num2));
                }
                else
                {
                    Console.WriteLine("This Operation is not supported!");
                }

                Console.WriteLine("Do you want to repeat the calculation? yes/no");

                repeat = Console.ReadLine().ToLower();
            }
        }
    }
}
