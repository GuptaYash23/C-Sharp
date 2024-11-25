/* Global Usings

In C#, global usings are a feature that allows you to specify commonly used namespaces across your entire project, so you don’t have to import them in every file. This feature was introduced in C# 10 and .NET 6, aiming to reduce boilerplate code, making your code cleaner and easier to manage, especially in large projects.

-> How Global Usings Work

Definition in a Single File: You typically define global usings in a separate file (often named GlobalUsings.cs) at the root of your project. In this file, you use the global keyword before each using statement.

Applied to Entire Project: Once defined, these namespaces are available throughout all the files in the project, so you don’t need to import them repeatedly in each file.

Project-wide Scope: Global usings only affect the project in which they are defined. If your solution has multiple projects, you’ll need to define global usings in each project separately if they need them.

-> Example of Using Global Usings

Create a GlobalUsings.cs file with the following content:

-------------------------------------------------------------------------------------------// GlobalUsings.cs
global using System;
global using System.Collections.Generic;
global using System.Linq;
global using System.Threading.Tasks;
-------------------------------------------------------------------------------------------

Now, you don’t need to include using System;, using System.Collections.Generic;, etc., in every file—these namespaces will be accessible across the project.

-> Benefits

Cleaner Code: Reduces repetitive using statements across multiple files.
Easier Maintenance: If you need to add or remove a commonly used namespace, you can do it in one place. 

Improved Consistency: Ensures that all files have access to the same core namespaces, reducing errors from missing imports. 

-> Key Considerations

Scoped to a Project: As mentioned, global usings are scoped to a single project, so for solutions with multiple projects, they need to be set individually for each project.

Overhead for Minimal Files: If you have a small project with few files, global usings might not add much benefit, as the feature is most useful in larger projects.

-> Implicit Usings in .NET 6 and Later

In .NET 6 and later, implicit usings were introduced alongside global usings, where common namespaces (like System, System.Linq, etc.) are automatically imported by default, especially in SDK-style projects. You can configure implicit usings in your .csproj file.

-------------------------------------------------------------------------------------------
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <ImplicitUsings>enable</ImplicitUsings>
  </PropertyGroup>
</Project>
-------------------------------------------------------------------------------------------

This feature complements global usings by automatically importing standard namespaces, reducing the need for manual imports.

*/

/* Null Parameter Checking

In C# 11, parameter null-checking was introduced as a simplified syntax to enforce that a parameter is not null. This feature helps to prevent ArgumentNullException by automatically checking for null arguments in method parameters without having to write explicit checks in the method body.

-> How Null Parameter Checking Works

With null parameter checking, you can add the !! (double exclamation mark) suffix to a parameter, and the compiler will automatically insert a null check for that parameter. If the parameter is null, it will throw an ArgumentNullException with the parameter's name.

-> Example of Null Parameter Checking

Instead of writing:

-------------------------------------------------------------------------------------------
public void ProcessData(string data)
{
    if (data == null)
    {
        throw new ArgumentNullException(nameof(data));
    }

    // Process the data...
}
-------------------------------------------------------------------------------------------

You can use the new !! syntax:

-------------------------------------------------------------------------------------------
public void ProcessData(string data!!)
{
    // Process the data...
}
-------------------------------------------------------------------------------------------

Here, data!! automatically enforces that data is not null. If data is passed in as null, an ArgumentNullException will be thrown, and the method body will not execute.

-> How It Works Behind the Scenes

The !! syntax is syntactic sugar, and the compiler generates code similar to what you’d manually write with ArgumentNullException. Internally, this code:

-------------------------------------------------------------------------------------------
public void ProcessData(string data!!)
{
    // Method body
}
-------------------------------------------------------------------------------------------

is transformed to something like:

-------------------------------------------------------------------------------------------
public void ProcessData(string data)
{
    ArgumentNullException.ThrowIfNull(data);

    // Method body
}
-------------------------------------------------------------------------------------------

-> Benefits of Null Parameter Checking'

Reduced Boilerplate Code: Minimizes the need to write repetitive null-checking code, making methods cleaner.

Readability: Using !! immediately shows that a parameter cannot be null.

Consistent Error Handling: Automatically throws ArgumentNullException with the correct parameter name if the parameter is null.

-> Key Points

Only for Parameters: The !! syntax applies to method parameters only, not fields or properties.

Compile-time Check: Null-checks are generated at compile time, not runtime, meaning the code is optimized and consistent.

This feature improves code quality and reduces the likelihood of null reference errors, especially in methods where null arguments are not allowed.

*/

/* File scoped namespaces

In C# 10, file-scoped namespaces were introduced as a streamlined way to define a namespace for an entire file, reducing indentation and improving readability. This feature allows you to declare a namespace at the top of a file without needing to wrap the contents of the file in curly braces { }, as was previously required.

-> Traditional Namespace Syntax

Before C# 10, namespaces were defined using the following block-based syntax, which required wrapping the contents in curly braces and indenting all code within them:

-------------------------------------------------------------------------------------------
namespace MyNamespace
{
    public class MyClass
    {
        // Class members
    }
}
-------------------------------------------------------------------------------------------

This style could lead to increased indentation, especially in larger files or projects with nested namespaces.

-> File-Scoped Namespace Syntax

With file-scoped namespaces, you can define the namespace once at the top of the file, ending it with a semicolon ;, like so:

-------------------------------------------------------------------------------------------
namespace MyNamespace;

public class MyClass
{
    // Class members
}
-------------------------------------------------------------------------------------------

Here, namespace MyNamespace; applies to the entire file, and all types defined in the file will be part of MyNamespace without additional indentation.

-> Advantages of File-Scoped Namespaces

Cleaner Code: Reduces nesting and unnecessary indentation, making files easier to read.
Consistent Layout: Removes the need for wrapping braces around the entire file, so your classes, methods, and other members are aligned with the file’s left margin.

Improved Readability: Especially in large files, file-scoped namespaces allow the structure to be flatter and more concise.

-> Example Comparison

Traditional Namespace Syntax

-------------------------------------------------------------------------------------------
namespace ProjectNamespace
{
    public class ExampleClass
    {
        public void ExampleMethod()
        {
            // Method logic here
        }
    }
}-------------------------------------------------------------------------------------------

File-Scoped Namespace Syntax

-------------------------------------------------------------------------------------------
namespace ProjectNamespace;

public class ExampleClass
{
    public void ExampleMethod()
    {
        // Method logic here
    }
}
-------------------------------------------------------------------------------------------

-> Key Points

Applies to the Entire File: Only one file-scoped namespace can be declared per file, as it applies to everything within the file.

Cannot be Nested: File-scoped namespaces do not support nested namespace declarations within the same file.

Optional Use: File-scoped namespaces are optional; the traditional syntax is still fully supported.

File-scoped namespaces provide a cleaner, more modern approach to organizing code, particularly beneficial in files with a single namespace and large class definitions.

*/