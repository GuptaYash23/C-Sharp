using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many number of items do you want to store?");

            int num = int.Parse(Console.ReadLine());

            int[] numbers = new int[num];

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Enter {i+1} data");
                // Parse the input to an integer
                int data = int.Parse(Console.ReadLine());
                numbers[i] = data;
            }

            // Added missing semicolon
            Console.WriteLine("Your Data is---------");

            foreach (int element in numbers)
            {
                Console.WriteLine(element);
            }
        }
    }
}
