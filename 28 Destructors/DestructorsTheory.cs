/* C# Destructors

In C#, a destructor is a special method used to clean up resources when an object is being destroyed or finalized by the garbage collector. Destructors are mainly used for releasing unmanaged resources like file handles, network connections, or database connections, which the garbage collector doesn't handle automatically.

Key Features of a Destructor:

Syntax: A destructor is defined with a tilde (~) followed by the class name, with no return type and no parameters.

Syntax:

---------------------------------------------------------
class MyClass
{
    ~MyClass()
    {
        // Destructor logic
    }
}
---------------------------------------------------------

Automatic Call: Destructors are automatically invoked by the garbage collector when the object is no longer in use and is being finalized. You cannot explicitly call a destructor.

No Parameters or Return Type: A destructor cannot have parameters or a return type, making its declaration unique.

Cannot be Overloaded: A class can have only one destructor.

Used for Unmanaged Resources: In modern C#, destructors are rarely needed for most resources. Instead, the IDisposable interface and the Dispose pattern are recommended for managing unmanaged resources more predictably.

Example:

---------------------------------------------------------
class MyResource
{
    // Constructor
    public MyResource()
    {
        Console.WriteLine("Resource created");
    }

    // Destructor
    ~MyResource()
    {
        Console.WriteLine("Resource cleaned up");
    }
}
---------------------------------------------------------

In this example, the MyResource class has a destructor that will be invoked when the garbage collector finalizes the object.

Important Notes:

Unpredictable Timing: The timing of when a destructor is called is nondeterministic because it depends on the garbage collector, which means you don’t know exactly when the object will be destroyed.

Performance: Destructors can introduce performance overhead because the garbage collector needs to keep track of objects with destructors, delaying their cleanup.

Best Practice: Use IDisposable

In modern C# development, it's generally better to implement the IDisposable interface and use the Dispose() method, especially when dealing with unmanaged resources. This gives more control over resource cleanup timing, especially when combined with the using statement.

Example using IDisposable:

---------------------------------------------------------
class MyResource : IDisposable
{
    public void Dispose()
    {
        // Clean up resources
        Console.WriteLine("Resources disposed");
        GC.SuppressFinalize(this);  // Prevent the destructor from being called
    }

    ~MyResource()
    {
        // Destructor to ensure cleanup
        Dispose();
    }
}
---------------------------------------------------------

The Dispose() method is called explicitly, while the destructor acts as a fallback in case Dispose() isn't called.

Example:

Here's a real-world example where a class manages an unmanaged resource (a file stream) using both a destructor and the IDisposable interface. The destructor acts as a fallback to clean up the resource if Dispose() is not called explicitly, but the preferred way to clean up is through Dispose() and the using statement.

Example: Managing a File Stream

---------------------------------------------------------
using System;
using System.IO;

class FileManager : IDisposable
{
    private FileStream _fileStream;
    private bool _disposed = false;

    // Constructor that opens a file stream
    public FileManager(string filePath)
    {
        _fileStream = new FileStream(filePath, FileMode.OpenOrCreate);
        Console.WriteLine("File opened.");
    }

    // Public method to write data to the file
    public void WriteToFile(string data)
    {
        if (_disposed)
            throw new ObjectDisposedException("FileManager");

        byte[] bytes = System.Text.Encoding.UTF8.GetBytes(data);
        _fileStream.Write(bytes, 0, bytes.Length);
        Console.WriteLine("Data written to file.");
    }

    // Implementation of IDisposable's Dispose method
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);  // Prevent finalizer from running
    }

    // Protected method that handles resource cleanup
    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                // Free managed resources
                if (_fileStream != null)
                {
                    _fileStream.Close();
                    _fileStream.Dispose();
                    Console.WriteLine("File stream disposed.");
                }
            }

            // Free unmanaged resources if there are any
            // (not applicable in this case, but this is where you would clean them up)

            _disposed = true;
        }
    }

    // Destructor (finalizer) to clean up resources as a fallback
    ~FileManager()
    {
        Dispose(false);
    }
}

class Program
{
    static void Main()
    {
        // Using 'using' statement ensures Dispose is called automatically
        using (var fileManager = new FileManager("example.txt"))
        {
            fileManager.WriteToFile("Hello, world!");
        }

        // Alternatively, Dispose can be called manually:
        FileManager anotherFileManager = new FileManager("example2.txt");
        try
        {
            anotherFileManager.WriteToFile("Goodbye, world!");
        }
        finally
        {
            anotherFileManager.Dispose();
        }
    }
}
---------------------------------------------------------

Explanation:

Constructor: The FileManager class opens a file using FileStream.

WriteToFile: The method allows writing data to the file, but only if the object is not already disposed.

Dispose: Implements the IDisposable interface. It calls the Dispose(bool disposing) method to close the file stream and free up resources. It also calls GC.

SuppressFinalize(this) to prevent the garbage collector from calling the destructor, which saves resources.

Destructor (~FileManager): Acts as a fallback to ensure that resources are freed if Dispose() is not called explicitly. This is rarely used in practice but ensures safety in case of improper disposal.

Usage:

In the first example, the using block ensures that Dispose() is called automatically at the end.
In the second example, Dispose() is called manually in the finally block, ensuring that the file is closed properly, even if an exception occurs.

Output:

---------------------------------------------------------
File opened.
Data written to file.
File stream disposed.
File opened.
Data written to file.
File stream disposed.
---------------------------------------------------------

This approach ensures proper resource management, where Dispose() is the preferred way to release resources, and the destructor provides a safety net.

*/