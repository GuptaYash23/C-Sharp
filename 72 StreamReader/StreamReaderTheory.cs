/* StreamReader Class

C# StreamReader class is ued to read string from the stream.

StreamReader reads text files.

The namespace for it is System.IO namespace

It inherits TextReader class

It provides ReadLine() method to read data from the stream

It also provides ReadToEnd() method to read all data from the stream.

Peek() - Returns if there is a character or not.

Example - Reading data from file and storing it using ReadLine() method

Code:

---------------------------------------------------------------------------------------------------------------------
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

                // Reading a single line from the file
                string line = reader.ReadLine();

                Console.ReadLine(line);

                // Reading the entire file
                string filetext = "";

                while ((line = reader.ReadLine()) != null)
                {
                    filetext += line;
                }

                // Alternate Method is to use foreach to get every line and print it

                Console.WriteLine(filetext);

                reader.Close();
            }
        }
    }
}
---------------------------------------------------------------------------------------------------------------------

Example - Reading data from file and storing it using ReadToEnd() method

---------------------------------------------------------------------------------------------------------------------
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

                // Reading the entire content of the file
                string data = reader.ReadToEnd();

                Console.ReadLine(data);

                reader.Close();
            }
        }
    }
}
---------------------------------------------------------------------------------------------------------------------

Example - Checking a file whether it's empty or not using Peek() method

Code -

---------------------------------------------------------------------------------------------------------------------
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
---------------------------------------------------------------------------------------------------------------------
*/