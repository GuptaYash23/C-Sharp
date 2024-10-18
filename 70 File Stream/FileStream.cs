using System;
using System.IO;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = @"G:\myFile.txt";

            // Creating a FileStream object using file path and FileMode (FileMode.Create to create a new file if file already doesn't exist and overwrite if it already exists) and selecting FileAccess.Write to write in the file. Also using FileShare.Read to allow other processes to read the file
            FileSteam file = new FileStream(path, FileMode.Create,FileAccess.Write, FileShare.Read);

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