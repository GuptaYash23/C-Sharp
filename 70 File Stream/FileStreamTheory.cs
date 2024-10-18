/* File Stream

The FileStream represents a File in the Computer.

Use the FileStream class to read from, write to, open and claose files on a file system.

The FileStream is a class used for reading and writing files in C# 

It is a part of the System.IO namespace

FileStream is derived from the Stream class.

FileStream Class is used to perform the basic operation of reading and writing operating system files.

FileStream class helps in reading form, writing and closing files.

To manipulate files using FileStream, you need to create an object of FileStream class.

This object has four parameters; the Name of the File, FileMode, FileAccess , and FileShare.

-> FileMode

It specifies how to operation system should open the file. It has the following members

(i) Append - Open the file if exist or create a new file. If file exists then place cursor at the end of the file

(ii) Create - It specifies operating system to create a new file. If file already exists then previous file will be overwritten.

(iii) CreateNew - It creates a new file and if file already exists then throw IOException

(iv) Open - Open existing file

(v) Open or Create - Open existing file and if file not found the create new file

(vi) Truncate - Open an existing file and cut all the stored data. So the file size becomes 0.

-> File access

It specifies the access to the file.

- Read - To read data from a file

- Write - To write data to a file

- ReadWrite - To read and write data to a file

Example - To create a file and writing in it

Code:

---------------------------------------------------------------------------------------------------
using System;
using System.IO;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = @"G:\myFile.txt";

            // Creating a FileStream object using file path and FileMode (creating the file if it doesn't exist otherwise it overwrites the existing file) and selecting FileAccess.Write to write in the file
            FileSteam file = new FileStream(path, FileMode.Create,FileAccess.Write);

            // We can also use brackets so that file is automatically closed at end of the brackets

            //
            using(FileSteam file = new FileStream(path, FileMode.Create,FileAccess.Write)))
            {

            }

            // Writing a Byte in a file

            file.WriteByte(65);  // A

            // Closing the file
            file.Close();

        }
    }
}
---------------------------------------------------------------------------------------------------

Example - Appending the content to already existing files

Code:

---------------------------------------------------------------------------------------------------
using System;
using System.IO;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = @"G:\myFile.txt";

            // Creating a FileStream object using file path and FileMode (FileMode.Append is used because we don't require a new file and we will append the content to our already existing file) and selecting FileAccess.Write to write in the file
            FileSteam file = new FileStream(path, FileMode.Append,FileAccess.Write);

            // Writing a Byte in a file

            file.WriteByte(68);  // D
            file.WriteByte(69);  // E

            // Closing the file
            file.Close();
        }
    }
}
---------------------------------------------------------------------------------------------------

Example - Writing the data into file by converting into bytes array

Code:

---------------------------------------------------------------------------------------------------
using System;
using System.IO;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = @"G:\myFile.txt";

            // Creating a FileStream object using file path and FileMode (FileMode.Create to create a new file if file already doesn't exist and overwrite if it already exists) and selecting FileAccess.Write to write in the file
            FileSteam file = new FileStream(path, FileMode.Create,FileAccess.Write);

            // Converting the string into a UTF-8 byte array and writing it to a File using a FileStream

            string data = "This is FileStream tutorial";

            byte[] write_data = Encoding.UTF8.GetBytes(data);

            // FileStream.Write(byte[] array, int offset, int count);
            file.Write(write_data,0,data.Length);

            // Closing the file
            file.Close();
        }
    }
}
---------------------------------------------------------------------------------------------------

Another parameter FileShare is used to allow other process to read the File

Example

---------------------------------------------------------------------------------------------------
FileSteam file = new FileStream(path, FileMode.Create,FileAccess.Write, FileShare.Read);
---------------------------------------------------------------------------------------------------

*/