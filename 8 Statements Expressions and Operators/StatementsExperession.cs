using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const float PI = 3.14F;
            float radius = 5;
            float area = PI*radius*radius;

            Console.WriteLine("The area of the circle is : "+ area);   // The area of the circle is 78.5
            Console.ReadLine();
        }
    }
}