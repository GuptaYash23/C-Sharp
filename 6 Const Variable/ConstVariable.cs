using System;

namespace ConsoleApp
{
    public class Program
    {
        // const value cannot be redefined (reinitialize) and should be defined (initialized) at the time of declaration

        // const are declared for value types rather than for referenc types
        public const double PI = 3.14;
        
        public static void Main(string[] args)
        {
            // PI = 3.14159;
            Console.WriteLine(PI);     //  3.14
            Console.ReadLine();
            
        }
    }
}