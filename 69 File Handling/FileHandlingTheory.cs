/* File Handling in C#

A file is a collection of data stored in a disk with a specific name and a directory path.

Name -> abc.txt
Directory path -> C:\Program Files\Yash\abc.txt

File Handling allows to store/retrieve data on permanent storage.

File and it's data can be handled programmatically.

When a file is opened for reading or writing, it becomes a stream.

The stream is basically the sequence of bytes passing through the communication path. There are two main streams: the input stream and the output stream.

The input stream is used for reading data from file (read operation) and the output stream is used for writing into the file (write operation).

The .Net framework provides a few basic classes for creating, reading and writing to files on the secondary storage and for retrieving file system information.

They are located in the System.IO namespace and used both in desktop applications and the web applications.

Classes used in file handling in C# 

-FileStream
-BinaryReader
-BinaryWrite
-StreamReader
-StreamWrited
-StringReader
-StringWriter
-DirectoryInfo
-FileInfo

These all classes are present in System.IO namespace. This namespace is used for performing operation with files.

-> Checking file exist or not

To check whether a file exists or not we use File class from System.IO namespace which will return true if the file exists otherwise it will return false.

First we have to add the System.IO namespace, then we use the File class which is present in the System.IO namespace after which we use Exists method of the File class for checking whether the desired file exists or not.

Code:

-----------------------------------------------------------------------------------------------------
using System;
using System.IO;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // We can use paths using two ways

            // string path = "F:\\data.txt";
            string path = @"F:\data.txt"; // verbatim literal (takes string as raw string)

            if (File.Exists(path))
            {
                Console.WriteLine("The file is present");
            }
            else
            {
                Console.WriteLine("The file is not present");
            }

        }
    }
}
-----------------------------------------------------------------------------------------------------

-> Reading data from text file 

Use the File class which is present in the System.IO namespace.

Use ReadAllText method of File class to read the data from the text file.

Code:

-----------------------------------------------------------------------------------------------------
using System;
using System.IO;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // We can use paths using two ways

            // string path = "F:\\data.txt";
            string path = @"F:\data.txt"; // verbatim literal (takes string as raw string)

            if (File.Exists(path))
            {
                Console.WriteLine("The file is present");
                
                // Reading and saving the file text into a variable
                string filedata = File.ReadAllText(path);

                Console.WriteLine(filedata);
            }
            else
            {
                Console.WriteLine("The file is not present");
            }

        }
    }
}
-----------------------------------------------------------------------------------------------------

-> How to create a copy of a file

Use the File class which is present in System.IO namespace.

Use Copy method of File class to make a copy of a file.

Copy method have 2 overloaded versions.

- 1st version takes 2 arguments (src_file_path,destination_file_path).

- 2nd version takes 3 arguments (src_file_path,destination_file_path,bool_overwrite) [Will overwrite destination file if it already exists]

1st version of Copy method does not allow to overwrite file, if you try to overwrite file then it throws exception.

2nd version of Copy method allows us to overwrite file.

-> Directory Info Class

It is used to create, delete and move directory.

It provides methods to perform operations realted to directory and subdirectory. It is a sealed class so, we cannot inherit it.

C# DirectoryInfo class provides functionality to work with folders or directories.

The DirectoryInfo class is declared in the System.IO namespace that must be imported before you can use this class.

The DirectoryInfo class shares almost all of the same properties as the FileInfo class, except that they operate on directories not files.

The DirectorInfo class does nbot have static methods and can only be used on instantiated objects.

The DirectoryInfo object represents a physical directory on a disk.

It also provides instance methods for deleting folders, creating a new directory and sub directories.

Directory Info Class Methods

- Create - This method is used to create the new directory.

- CreateSubdirectory - This method is used to create a subdirectory or subdirectories on the specified path.

- MoveTo - Moves a DirectoryInfo instance and it's contents to a new path

- Delete - Deletes the instance of a DirectoryInfo, specifying whether to delete subdirectories and files.
(.Delete() is used to delete the empty directory, .Delete(true) is used to delete the directory with all it's content)

- GetDirectories - This method is used to get the sub directories in the given directory path.

- GetFiles - The GetFiles methods is used to get the files in the specified folder

Code:

-----------------------------------------------------------------------------------------------------
using System;
using System.IO;

namespace DirectoryInfoClass
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Path for new directory

            string path = @"G:\My Directory";   // Verbatim litereal

            // Creating an object of DirectoryInfo class
            DirectoryInfo dir = new DirectoryInfo(path);

            // Creating the directory on the destined parth

            dir.Create();

            // Creating a subdirectory in MyDirectory

            dir.CreateSubdirectory("My Sub Directory");

            string path2 = @"G:\MyNewDirectory";

            // Moving all the files from one directory to another director (First the other directory will be created and then all the files will be moved to it)

            dir.MoveTo(path2); // All the content of dir directory of path will move to path2 directory

            // Deleting the original directory

            dir.Delete();  // Used to delete the empty directory

            dir.Delete(true); // Will delete the directory including it's content

            string path3 = @"G:\newfolder";

            DirectoryInfo dir2 = new DirectoryInfo(path3);

            // To get all the subdirectories in path3

            DirectoryInfo[] dirs = dir2.GetDirectories();

            // To print all the subdirectories 

            foreach (DirectoryInfo item in dirs)
            {
                Console.WriteLine(item);   // Lists all the subdirectories

                // .FullName is used to get the entire path of the directory

                Console.WriteLine(item.FullName);  // Lists all the subdirectory's name

                // Printing no. of files in each directory using .GetFiles() method and .Length property

                Console.WriteLine(item.GetFiles().Length);   // Lists the no. of files in each subdirectory



            }

        }
    }
}
-----------------------------------------------------------------------------------------------------


-> Useful properties of Directory Info Class

- Name - Lists the name of the directory

- FullName - Lists the full name (entire path) of the directory

- LastAccessTime - Lists the last time it was accessed

- CreationTime - Lists the time when directory was created

- Attributes - Lists the attributes of the directory (Directory)

- Parent - Lists the parent directory of the current directory

- Root - Lists the root directory

- LastWriteTime - List the time when directory was modified

Code:

-----------------------------------------------------------------------------------------------------
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
-----------------------------------------------------------------------------------------------------
*/