using System;
using System.IO;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = @"G:\myFile.txt";

            using (FileStream fs = newFileStream(path, FileMode.Open, FileAccess.Read))
            {
                // Creating a StreamReader obj and passing the file to be read as a parameter
                StreamReader reader = new StreamReader(fs);

                if (reader.Peek() > 0)
                {
                    Console.WriteLine($"The file is not empty");
                }
                else
                {
                    Console.WriteLine($"The file is empty");
                }

                reader.Close();
            }
        }
    }
}