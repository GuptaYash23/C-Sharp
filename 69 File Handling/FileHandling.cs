using System;

namespace DirectorInfoClassProperties
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Path for a new directory having 3 files (new1, new2 and new3)

            string path = @"G:\new\new1";

            // Creating DirectoryInfo instance of path 

            DirectoryInfo dir = new DirectoryInfo(path);

            Console.WriteLine(dir.Name);    // Prints new1 (Lists the name of the directory)

            Console.WriteLine(dir.FullName); // Prints G:\new\new1 (Lists the entire path of the directory)

            Console.WriteLine(dir.LastAccessTime); // Lists the time when directory was last accessed

            Console.WriteLine(dir.CreationTime); // Lists the time when directory was created

            Console.WriteLine(dir.Attributes); // Prints Directory (Lists the attributes of the directory)

            Console.WriteLine(dir.Parent);  // Prints new (Lists the parent directory of the current directory)

            Console.WriteLine(dir.Root); // Prints G:\ (Lists the root directory of the dir object)

            Console.WriteLine(dir.LastWriteTime); // Lists the last time dir was modified


        }
    }
}