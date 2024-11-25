using System;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Program
    {
        public static async Task Task1()
        {
            Console.WriteLine("Task 1 Starting ...");
            await Task.Delay(4000); // Non-blocking delay
            Console.WriteLine("Task 1 Completed");
        }

        public static async Task Task2()
        {
            Console.WriteLine("Task 2 Starting ...");
            await Task.Delay(3000); // Non-blocking delay
            Console.WriteLine("Task 2 Completed");
        }

        public static async Task Task3()
        {
            Console.WriteLine("Task 3 Starting ...");
            await Task.Delay(1000); // Non-blocking delay
            Console.WriteLine("Task 3 Completed");
        }

        public static async Task Task4()
        {
            Console.WriteLine("Task 4 Starting ...");
            await Task.Delay(6000); // Non-blocking delay
            Console.WriteLine("Task 4 Completed");
        }

        public static async Task Main(string[] args)
        {
            // Start all tasks and wait for them to complete
            await Task.WhenAll(Task1(), Task2(), Task3(), Task4());
        }
    }
}
