using System;
using System.IO;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = @"G:\myFile.txt";

            using(FileStream file = new FileStream(path, FileMode.Open, FileAccess.Write))
            {
                // Using StreamWriter to write the content in the file (passing the file object as the argument)

                StreamWriter writer = new StreamWriter(file, Encoding.UTF8);

                writer.Write("This is StreamWrite Class Tutorial");  // As we are using .Write method instead of .WriteLine the data will be added on the same line of the previous text

                // Writing an array

                int[] arr = {1,2,3,4,5};

                foreach(var item in arr)
                {
                    writer.Write(item + " ");
                }

                writer.Close(); // Can also use using(){} syntax
            }
        }
    }
}