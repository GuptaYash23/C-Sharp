/* Namespace and Main method

-> Namespace in C#

A namespace in C# is a logical grouping of related classes, interfaces, structs, enums, and other namespaces. Namespaces are used to organize code in a hierarchical manner and help avoid naming conflicts between different classes or types, especially in large projects.

-> Key Points:

Organization: Namespaces allow you to categorize your code into logical groups. For example, you might have a namespace for data access, another for user interface components, and another for business logic.

Avoiding Conflicts: By grouping related classes and types under a namespace, you prevent naming collisions. For instance, you could have a class named Logger in one namespace and another Logger in a different namespace.

Usage: You can use classes from a namespace by specifying the namespace name or using the using directive to import the namespace.

Example:

----------------------------------------------------------------
namespace MyApplication.DataAccess
{
    public class DatabaseHandler
    {
        // Class code here
    }
}
----------------------------------------------------------------

In the above example:

MyApplication.DataAccess is the namespace.

The class DatabaseHandler is defined within this namespace.

To use the DatabaseHandler class elsewhere, you would either fully qualify it like MyApplication.DataAccess.DatabaseHandler or include using MyApplication.DataAccess; at the top of your file.

-> Main Method in C#

The Main method is the entry point of a C# console application or Windows application. It’s where the execution of your program begins. Every C# console application must have a Main method, and there can be only one Main method per application.

Key Points:

Entry Point: The Main method is where the runtime starts the execution of the program.

Static Method: The Main method is static, meaning it belongs to the class itself rather than to instances of the class. This allows the runtime to invoke it without creating an object of the class.

Return Type: The Main method can return either void or an int. When it returns int, the value can be used as the exit code of the program.

Parameters: The Main method can take an optional parameter of type string[] (an array of strings), which represents the command-line arguments passed to the program.

Example:

----------------------------------------------------------------
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            if (args.Length > 0)
            {
                Console.WriteLine("Arguments passed:");
                foreach (var arg in args)
                {
                    Console.WriteLine(arg);
                }
            }
        }
    }
}
----------------------------------------------------------------

In the above example:

static void Main(string[] args): This is the Main method, where args is an array of strings that stores any command-line arguments passed to the program.

Console.WriteLine("Hello, World!");: This line outputs "Hello, World!" to the console.

When you run the application, the Main method is the first method that is called, and it will execute the code inside it.

-> Summary

Namespace: A way to organize and group related classes and other types to avoid naming conflicts and improve code readability.

Main Method: The starting point of a C# application, where the program begins its execution. It must be static and can optionally take an array of strings as an argument to handle command-line parameters.

*/