using System;
using System.Linq;

namespace Linq_tutorial
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] Age = { 12, 23, 21, 22, 45, 33, 20, 26, 55, 66 };

            var AgeGreaterThan20 = from i in Age where i > 20 select i;

            var SortedAgeGreaterThan20 = from i in Age where i > 20 orderby i select i;

            var DescSortedAgeGreaterThan20 = from i in Age where i > 20 orderby  i descending select i;

            foreach (int item in AgeGreaterThan20)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine('\n');

            foreach (int item in SortedAgeGreaterThan20)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine('\n');

            foreach (int item in DescSortedAgeGreaterThan20)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine('\n');

            string[] names = {"Yash", "Shubham", "Rahul", "Yuvraj", "Vivek", "Varun", "Aditya"};

           // Select all the names that contain letter h (lowercase h)
            var NamesContainingh = from name in names where name.Contains("h") select name;

            foreach(string name in NamesContainingh)
            {
                Console.WriteLine(name);
            }

            var NamesStartsWithV = from name in names where name.StartsWith("V") select name;

            Console.WriteLine('\n');

            foreach(string name in NamesStartsWithV)
            {
                Console.WriteLine(name);
            }
        }
    }
}