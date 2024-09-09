/* 

-> C# Introduction

C# (pronounced "C-sharp") is a modern, object-oriented programming language developed by Microsoft as part of its .NET initiative. It was first released in 2000, and it has since become one of the most popular programming languages, especially for developing Windows applications, web services, and enterprise software.

-> Key Features of C#:

Object-Oriented: C# is inherently object-oriented, which means it supports the principles of encapsulation, inheritance, and polymorphism. This makes it easy to create modular and reusable code.

Type-Safe: C# is a statically-typed language, meaning that variable types are known at compile time, which reduces runtime errors and increases code stability.

Rich Standard Library: C# has a vast standard library (the .NET Framework or .NET Core/5+) that provides numerous classes and functions for various tasks like file handling, database interaction, web services, etc.

Automatic Memory Management: C# handles memory allocation and deallocation automatically using a garbage collector, reducing the chances of memory leaks and other memory-related issues.

Interoperability: C# can interact with other languages, particularly those running on the .NET platform. It also allows for calling native Windows APIs and COM objects.

LINQ: Language-Integrated Query (LINQ) is a powerful feature in C# that allows querying data from various sources (like collections, databases, XML documents) directly within the C# language.

Asynchronous Programming: C# supports asynchronous programming with the async and await keywords, making it easier to write code that doesn't block the main thread, enhancing performance in applications.

Cross-Platform: With .NET Core and later versions, C# has become a cross-platform language, meaning you can develop and run C# applications on Windows, Linux, and macOS.

-> Basic Syntax:

Here’s a simple example of a C# program:

-------------------------------------------------------------
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
--------------------------------------------------------------

-> Explanation:

using System;: This line allows the program to use the classes in the System namespace, like Console.

namespace HelloWorld: Namespaces are used to organize code and prevent naming conflicts.

class Program: A class in C# is a blueprint for creating objects, and it encapsulates data and methods.

static void Main(string[] args): The Main method is the entry point of a C# program. It's where the program starts execution.

Console.WriteLine("Hello, World!");: This line prints "Hello, World!" to the console.

-> In this example:

namespace HelloWorld defines a namespace named HelloWorld.
Inside this HelloWorld namespace, there is a Program class.

-> Why Use Namespaces?

Organization: Namespaces help organize your code, making it easier to manage and navigate, especially in large projects.

Avoiding Conflicts: If two classes in different libraries have the same name, namespaces prevent them from clashing by providing a unique identifier for each.

Code Readability: Namespaces can reflect the logical structure of your application, which enhances code readability.

-> Applications of C#:

Windows Desktop Applications: Using technologies like Windows Forms and WPF.

Web Applications: Using ASP.NET Core.

Mobile Applications: With Xamarin, you can develop cross-platform mobile apps using C#.

Games: Unity, a popular game development platform, uses C# as its primary scripting language.

Enterprise Applications: Due to its scalability, security, and robustness, C# is often used in enterprise-level applications.

C# is a versatile and powerful language suitable for a wide range of programming tasks. Whether you’re developing desktop applications, web services, or games, C# provides the tools and features needed to build robust and efficient software.

*/