using System;

namespace ConsoleApp
{
    public class ArithmeticOperators
    {
        public static void Main(string[] args)
        {
            int a = 10, b = 5, c, d, e, f, g;

            c = a + b;
            d = a - b;
            e = a * b;
            f = a / b;
            g = a % b;

            Console.WriteLine(c);    // 15
            Console.WriteLine(d);    // 5
            Console.WriteLine(e);    // 50
            Console.WriteLine(f);    // 2
            Console.WriteLine(g);    // 0
            Console.ReadLine();
        }
    }
}

