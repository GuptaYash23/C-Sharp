/* Partial Classes in C#  

In C#, a partial class is a class whose definition is split across multiple files. This feature allows the division of a large class into several smaller files, making the code more modular, maintainable, and easier to work on in teams. All parts of a partial class are combined into a single class when the program is compiled.

Why Use Partial Classes?

Large Class Management: For large classes, splitting the code into smaller, more manageable sections helps improve readability and organization.

Team Collaboration: Multiple developers can work on different parts of a class simultaneously without causing merge conflicts.
Generated Code: Partial classes are often used in auto-generated code (such as designer files in WinForms or ASP.NET), allowing developers to add custom code in separate files without modifying generated code.

How Partial Classes Work

Partial classes are declared using the partial keyword.
All parts of the partial class must use the partial keyword.
All parts of the partial class must be within the same namespace.
Partial classes allow the division of methods, properties, fields, and other members across different files.
When the program is compiled, the compiler combines all parts into a single class.

Syntax:

-------------------------------------------------------------------
// File 1: Part1.cs
public partial class MyClass
{
    public void Method1()
    {
        Console.WriteLine("Method 1");
    }
}

// File 2: Part2.cs
public partial class MyClass
{
    public void Method2()
    {
        Console.WriteLine("Method 2");
    }
}
-------------------------------------------------------------------

When the program is compiled, the above two partial classes are combined into a single class that has both Method1 and Method2.

Example of Partial Classes:

File 1: Employee.Part1.cs

-------------------------------------------------------------------
using System;

public partial class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void PrintEmployeeDetails()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}
-------------------------------------------------------------------

File 2: Employee.Part2.cs

-------------------------------------------------------------------
public partial class Employee
{
    public string Designation { get; set; }
    public decimal Salary { get; set; }

    public void PrintSalaryDetails()
    {
        Console.WriteLine($"Designation: {Designation}, Salary: {Salary}");
    }
}
-------------------------------------------------------------------

Main Program:

-------------------------------------------------------------------
class Program
{
    static void Main()
    {
        Employee emp = new Employee
        {
            Name = "John Doe",
            Age = 30,
            Designation = "Software Developer",
            Salary = 60000
        };

        emp.PrintEmployeeDetails();  // Calls method from Part1
        emp.PrintSalaryDetails();    // Calls method from Part2
    }
}
-------------------------------------------------------------------

Output:

-------------------------------------------------------------------
Name: John Doe, Age: 30
Designation: Software Developer, Salary: 60000
-------------------------------------------------------------------

Key Points about Partial Classes:

Code Separation: Partial classes allow separation of concerns, such as separating auto-generated code from developer-written code.

Single Class: Despite being defined in multiple files, all parts of a partial class are compiled into a single class at runtime.

Same Namespace: All parts of the partial class must belong to the same namespace.

Consistent Access Modifiers: All partial class declarations must have the same access level (e.g., public, internal).

Use Cases:

Auto-generated code: For example, in WinForms applications, UI designer code is placed in a separate file as a partial class, and developer-written logic goes in another file.

Large Classes: When a class grows too large, partial classes can help divide the code into more manageable chunks.

Limitations:

You cannot split partial class definitions across different assemblies.

Partial methods must be defined and declared in the same class (though they can be spread across different parts).

Partial Methods:

C# also supports partial methods, where the method signature is defined in one part of the class and optionally implemented in another. Partial methods must return void and are implicitly private. If the partial method is not implemented, the method call is ignored by the compiler.

Example of a Partial Method:

-------------------------------------------------------------------
// File: Part1.cs
public partial class MyClass
{
    partial void MyPartialMethod(); // Declaration
}

// File: Part2.cs
public partial class MyClass
{
    partial void MyPartialMethod() // Implementation
    {
        Console.WriteLine("Partial method executed.");
    }
}

class Program
{
    static void Main()
    {
        MyClass obj = new MyClass();
        obj.MyPartialMethod();  // Calls the partial method
    }
}
-------------------------------------------------------------------

Conclusion:

Partial classes provide a way to manage large and complex codebases by splitting a class across multiple files. They are especially useful in scenarios where code is generated automatically, such as in designer files, and help in maintaining a clear separation between generated and manually written code.
*/

/* Partial Class Rules

In C#, partial classes allow you to split the definition of a class across multiple files. The C# compiler merges these parts into a single class when the program is compiled. However, certain rules and guidelines must be followed when using partial classes to ensure they function correctly.

Rules for Partial Classes in C#

1. Use the partial Keyword:

Each part of a partial class must be declared with the partial keyword.

This keyword informs the compiler that the class, interface, or structure is defined across multiple files.

Example:

-------------------------------------------------------------------
public partial class MyClass { }  // Part 1
public partial class MyClass { }  // Part 2
-------------------------------------------------------------------

2. Same Namespace:

All parts of the partial class must be in the same namespace. The compiler will not merge the class parts if they are in different namespaces.

3. Same Class Name:

All parts of the partial class must have the same class name. The class is not considered partial if the names differ.

-------------------------------------------------------------------
public partial class Employee { }  // Correct
public partial class Employee { }  // Correct

// The following would not be allowed:
// public partial class Manager { }  // Incorrect
-------------------------------------------------------------------

4. Same Accessibility Level(access modifier):

All parts of a partial class must have the same accessibility modifier (public, internal, private, etc.).

You cannot have one part as public and another part as internal or private.

-------------------------------------------------------------------
public partial class Employee { }  // Part 1
public partial class Employee { }  // Part 2

// Both parts must have the same access modifier
-------------------------------------------------------------------

5. Combined at Compile Time:

Partial class parts are combined by the compiler into a single class at compile time. Therefore, the class behaves as if it were written in a single file.

Example:

You can access members (methods, properties, fields) declared in any part of the partial class from other parts, as they belong to the same class.

6. Partial Classes Can Span Across Files:

Partial classes are typically spread across multiple files. This allows for better organization of large classes, or to separate auto-generated code from manually written code.

Example:

-------------------------------------------------------------------
// File: Employee.Part1.cs
public partial class Employee { public string Name { get; set; } }

// File: Employee.Part2.cs
public partial class Employee { public void PrintName() { Console.WriteLine(Name); } }
-------------------------------------------------------------------

7. Same Class Scope:

A partial class cannot change the overall structure or characteristics of the class. It must follow the same class scope.
For example, all parts of the partial class should either define a class or a struct, but not both.

Example:

-------------------------------------------------------------------
public partial class MyClass { }   // Part 1 defines a class

// All other parts must also define the class, not a struct or other type
public partial class MyClass { }   // Part 2 defines the same class
-------------------------------------------------------------------

8. Class Members Defined Across Files:

Partial classes allow members (methods, properties, fields, etc.) to be declared in different parts of the class across multiple files.

However, you cannot have the same method or property signature defined in multiple parts of the class. 

Example:

-------------------------------------------------------------------
// File 1
public partial class MyClass
{
    public void Method1() { }
}

// File 2
public partial class MyClass
{
    public void Method2() { }
}
-------------------------------------------------------------------

9. Partial Methods:

Partial methods can be declared within partial classes, allowing one part of the class to declare a method signature, and another part to optionally implement it.

If a partial method is declared but not implemented, the compiler removes the method's signature from the final compiled class (i.e., the call is omitted).

Partial methods must return void and are implicitly private

Example:

-------------------------------------------------------------------
public partial class MyClass
{
    partial void MyPartialMethod();  // Declaration
}

public partial class MyClass
{
    partial void MyPartialMethod()   // Optional implementation
    {
        Console.WriteLine("Partial method executed.");
    }
}
-------------------------------------------------------------------

10. Nested Types:

You can have nested types (like enums, classes, or structs) within partial classes, and these nested types can also be split across multiple parts using the partial keyword.

Example:

-------------------------------------------------------------------
public partial class MyClass
{
    public partial class NestedClass
    {
        public void Method1() { }
    }
}

public partial class MyClass
{
    public partial class NestedClass
    {
        public void Method2() { }
    }
}
-------------------------------------------------------------------

11. Attributes Can Be Applied to Partial Classes:

Attributes applied to one part of a partial class apply to the entire class, regardless of the file in which they appear.
Attributes can be distributed across different parts of the partial class.

Example:

-------------------------------------------------------------------
[Serializable]  // Applied to the entire class
public partial class MyClass { }

[Obsolete("This part is obsolete")]  // Applies to the entire class
public partial class MyClass { }
-------------------------------------------------------------------

12. Cannot Use Partial Classes Across Assemblies:

All parts of a partial class must be compiled together into the same assembly. You cannot define parts of a partial class in different assemblies.

Example:

You cannot define part of a class in one project and the other part in another project that compiles to a different assembly.

13. Declare entire class as abstract if any part is abstract:

If any part is declared abstract then the whole class is declared of the abstract type. (Abstract class cannot be instantiated, it's object cannot be created)

14. Declare entire class as sealed if any part is sealed.

If any part is declared sealed then the whole class is declared of the sealed type. (Child class of sealed class cannot be created)

15. If any of the partz inherits the class, then the entire class inherits the class.

16. C# does not support multiple class inheritance. Different parts of the partial class, must not specify different base class.

17. Different parts of the partial class can specify different base interfaces.

18. Any member that are declared in a partial definition are available to all of the other parts of the partial class

Summary:

Partial classes in C# are a powerful tool for improving the organization and maintainability of large classes, especially in cases where different team members work on separate parts or where auto-generated code is involved. However, certain rules need to be followed to ensure that all parts of the class are correctly combined at compile time:

Use the partial keyword in all parts.

Ensure all parts are in the same namespace and have the same name and accessibility.

Avoid declaring the same members in different parts.

Optional use of partial methods for additional flexibility.
By following these rules, you can successfully work with partial classes in C#.
*/