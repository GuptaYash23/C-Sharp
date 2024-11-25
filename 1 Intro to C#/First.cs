using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Hello World");       // Hello World
    }
}

/*

This C# code is a simple program that prints a message to the console. Let's break it down line by line:

using System;: This line includes the System namespace, which contains fundamental classes and base classes that define commonly-used types, such as Console. By including this namespace, you can use its classes without needing to specify the full namespace path.

public class HelloWorld: This line defines a public class named HelloWorld. In C#, every program must have at least one class. The public keyword means that this class can be accessed from other classes.

public static void Main(string[] args): This line defines the Main method, which is the entry point of any C# console application.

public: The method can be accessed from other classes.

static: This means that the method belongs to the class itself rather than an instance of the class. You can call it without creating an object of the class.

void: This indicates that the method does not return any value.

string[] args: This parameter is an array of strings that can hold command-line arguments passed to the program when it is executed.

{ and }: These curly braces define the beginning and end of the class and method bodies.

Console.WriteLine("Hello World");: This line is the statement that actually performs the action of the program. It calls the WriteLine method of the Console class to print the string "Hello World" to the console.

*/

/* C# Project Folder Structure

When you create a new C# project in Visual Studio, it typically generates a folder structure that may look something like this:

-------------------------------------------------------------------------------------------
MyProject/
│
├── MyProject.sln                // Solution file
├── MyProject/                    // Project folder
│   ├── MyProject.csproj         // Project file
│   ├── Program.cs                // Main entry point
│   ├── Properties/               // Project properties
│   │   └── AssemblyInfo.cs       // Assembly attributes
│   ├── obj/                      // Intermediate files
│   ├── bin/                      // Compiled binaries
│   ├── Models/                   // Folder for model classes
│   ├── Controllers/              // Folder for controllers (MVC)
│   ├── Views/                    // Folder for views (MVC)
│   ├── wwwroot/                  // Folder for static files (ASP.NET Core)
│   └── ...                       // Other folders and files
│
└── ...                           // Other projects in the solution
-------------------------------------------------------------------------------------------

-> Key Components

(i) Solution File (.sln): This file contains information about the solution, including the projects it contains and their configurations.

(ii) Project File (.csproj): This XML file defines the project settings, references, and build configurations. It includes information about the target framework, NuGet packages, and other dependencies.

(iii) Program.cs: This file typically contains the Main method, which is the entry point of a console application. In ASP.NET Core applications, this file may contain the CreateHostBuilder method to set up the web host.

(iv) Properties Folder: This folder contains files that define assembly attributes and settings for the project. The AssemblyInfo.cs file, for example, contains metadata about the assembly, such as version and description.

(v) obj Folder: This folder contains intermediate files generated during the build process. It is automatically created and managed by Visual Studio.

(vi) bin Folder: This folder contains the compiled output of the project, including executable files and DLLs.

(vii) Custom Folders: You can create additional folders (like Models, Controllers, Views, etc.) to organize your code based on the architecture of your application (e.g., MVC pattern).

*/