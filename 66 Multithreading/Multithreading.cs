using System;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading_Demo
{
    public class Program
    {
        public static void func1()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Func1: {i}");
            }
        }

        public static void func2()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Func2: {i}");
                if(i == 2)
                {
                Console.WriteLine($"Sending Thread of Func2 to sleep for 4 seconds");
                
                // Sending the thread to sleep for 4 seconds
                  Thread.Sleep(4000);
                }
            }
        }

        public static void func3()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Func3: {i}");
            }
        }

        public static void Main(string[] args)
        {
            // Main thread is automatically created when the program runs

            // Creating multiple threads and passing reference to the different functions (child thread of main thread(parent), Total threads = 4)

            Thread t1 = new Thread(func1);
            Thread t2 = new Thread(func2);
            Thread t3 = new Thread(func3);

            // Starting various threads

            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}