using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x = 10;
            int y = 20;

            Console.WriteLine(x == y);  // False
            Console.WriteLine(x != y);  // True
            Console.WriteLine(x > y);   // False
            Console.WriteLine(x < y);   // True
            Console.WriteLine(x >= 10); // True
            Console.WriteLine(y <= 15); // False
            Console.ReadLine();
        }
    }
}