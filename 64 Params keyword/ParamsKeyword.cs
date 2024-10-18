using System;

namespace ConsoleApp
{
    public class Program
    {
        public int add(params int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num; 
            }
            return sum;
        }

        // params keyword is always used in last
        public int add2(int a, int b, params int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num; 
            }
            Console.WriteLine($"a is {a}, b is {b} and sum is {sum}");
            
            return sum+a+b;
        }

        public static void Main(string[] args)
        {
            Program program = new Program(); // Create an instance of Program
            Console.WriteLine(program.add(10,20,30,40,50,60)); // Call add on the instance
            Console.WriteLine(program.add2(10,20,30,40,50,60));
        }
    }
}
