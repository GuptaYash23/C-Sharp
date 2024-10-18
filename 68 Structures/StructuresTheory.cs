/* Structures in C# 

Structures is a user defined data type.

Class is also a user defined data type.

Structures are introduced first before classes.

Structures are first introduced in procedural language called C Programming language.

Classes are introducted after Structures in OOP Language.

Syntax:

<Access_Specifiers> struct <struct_name>
{
  Members here...
}

Strucutres belongs to procedural language.

Classes belong to OOP language

Stuctures in C Porgramming Language can contain only fields/variables.

Structures in C# programming language can contain most of the members that a class can contain like Methods, Fields, Constructors, Properties, Indexers etc.

In C#, classes and structs are blueprints that are used to create instance of a class.

-> Types and Size

Structure is value type.

Structures are stored in the stack memory. Stack memory is small in size.

Class is a reference type.

Classes are stored in the heap memory. Heap memory is big in size.

Class and Structures are used to represent entities like student, employee, customer etc.

We can use class for representing large amount of data whereas for small amount of data we use structures.

Structs are used for lightweight objects such as Color, Rectange, Point etc.

string is a class, reference type.

int is a struct, value type.

Pre-defined reference types are big in size.

-> New keyword

In case of a class "new" keyword is compulsory while creating the object/instance, on the other hand "new" is not compulsor while working with structures.

In case of structures, if you don't specify new keyword and constructor then you have explicity initialize the field.

In case of classes, if you don't specify new keyword and constructor then you cannot the explicity initialize the field. Because "new" keyword is compulsory while creating instance of a class.

For eg

Class:

----------------------------------------------------------------------
Program p = new Program();        // Class Constructor
----------------------------------------------------------------------

Structure:

----------------------------------------------------------------------
Program p;
Program p = new Program();        // Struct Constructor
----------------------------------------------------------------------

-> Constructors

In case of classes, if we don't create a constructor then a default constructor comes into place.

In case of classes, we can explicitly create default constructor/parameterless constructor and parameterized constructor.

But if we create any constructor in class then default constructor will be gone.

In case of structure, if we don't create a constructor then a default constructor comes into the place.

In case of structure, we cannot explicitly create default pre-defined, we can create only parameterized constructor in structures (default constructor will stay).

-> Inheritance

Class support inheritance whereas structures don't support inheritance.

Class and Structures can both implement interfaces.

----------------------------------------------------------------------------------------------------------------------

Structures in C#

In C#, a structure (also known as a struct) is a value type that allows you to create a data structure that can encapsulate data and related functionality. Unlike classes, which are reference types, structs are designed for lightweight objects that don't require inheritance and are stored directly on the stack rather than the heap. They are particularly useful for small data containers such as points, coordinates, or other simple types where performance is a concern.

Defining a Struct in C#

Here’s an example of a struct definition:

----------------------------------------------------------------------------------------------------------------------
public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    // Constructor
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    // Method
    public void DisplayCoordinates()
    {
        Console.WriteLine($"X: {X}, Y: {Y}");
    }
}
----------------------------------------------------------------------------------------------------------------------

In this example, Point is a simple struct that has two properties (X and Y), a constructor, and a method to display the coordinates.

-> Key Properties and Characteristics of Structures:

1. Value Type:

Structs are value types, meaning they are stored on the stack (except in certain scenarios where they may be boxed) and are passed by value, not by reference. This differs from classes, which are reference types and stored on the heap.

When you assign one struct variable to another, a copy is made. Modifications to one copy do not affect the other.

Example:

----------------------------------------------------------------------------------------------------------------------
Point p1 = new Point(1, 2);
Point p2 = p1; // Copy of p1 is created
p2.X = 5;
Console.WriteLine(p1.X);  // Output: 1
Console.WriteLine(p2.X);  // Output: 5
----------------------------------------------------------------------------------------------------------------------

2. No Inheritance:

Structs cannot inherit from other classes or structs, but they can implement interfaces. This makes them ideal for simple objects where inheritance is unnecessary.

Structs automatically inherit from System.ValueType, which in turn inherits from System.Object.

3. Immutable by Design:

Structs should be designed to be immutable when possible. This means that once the struct is created, it should not be modified. Immutable structs reduce bugs caused by unintended modifications.

Immutable structs can be achieved by making fields readonly and not providing setters for properties.

Example:

----------------------------------------------------------------------------------------------------------------------
public struct ImmutablePoint
{
    public readonly int X { get; }
    public readonly int Y { get; }

    public ImmutablePoint(int x, int y)
    {
        X = x;
        Y = y;
    }
}
----------------------------------------------------------------------------------------------------------------------

4. No Default Parameterless Constructor:

Structs cannot have explicit parameterless constructors. However, the compiler automatically provides a default parameterless constructor that initializes the fields to their default values (0, null, etc.).

----------------------------------------------------------------------------------------------------------------------
Point p = new Point();  // X and Y are initialized to 0 by the default constructor
----------------------------------------------------------------------------------------------------------------------

5. Performance:

Structs can be more efficient than classes when dealing with small data types because they avoid the overhead of heap allocation and garbage collection.

However, if structs are too large, passing them by value can negatively impact performance, as copying large structs becomes costly.

6. Cannot Have a Finalizer:

Since structs are value types and stored on the stack (unless boxed), they are automatically destroyed when they go out of scope. As a result, structs cannot have a destructor (finalizer).

7. Boxing and Unboxing:

When a struct is boxed, it is converted into a reference type by wrapping it in an object on the heap. This happens when you assign a struct to a variable of type object or an interface.

Unboxing is the reverse process, where the value type is extracted from the reference type.
Boxing and unboxing can incur a performance penalty, so it should be avoided in performance-critical scenarios.

Example:

----------------------------------------------------------------------------------------------------------------------
Point p = new Point(1, 2);
object obj = p;  // Boxing
Point p2 = (Point)obj;  // Unboxing
----------------------------------------------------------------------------------------------------------------------

8. Methods, Properties, and Fields:

Structs can have methods, properties, fields, and even operators. Structs can also have static members, including static constructors.

9. Interfaces:

Structs can implement interfaces, which allows them to define methods or properties without needing inheritance.

Example:

----------------------------------------------------------------------------------------------------------------------
public interface IDisplayable
{
    void Display();
}

public struct Point : IDisplayable
{
    public int X { get; set; }
    public int Y { get; set; }

    public void Display()
    {
        Console.WriteLine($"X: {X}, Y: {Y}");
    }
}
----------------------------------------------------------------------------------------------------------------------

10. Nullable Structs:

Value types, including structs, are non-nullable by default. However, you can create a nullable version of a struct using Nullable<T> or the ? shorthand.

Example:

----------------------------------------------------------------------------------------------------------------------
Point? nullablePoint = null;
if (nullablePoint.HasValue)
{
    Console.WriteLine(nullablePoint.Value.X);
}
----------------------------------------------------------------------------------------------------------------------

-> When to Use Structs:

Small Data Structures: Structs are ideal for small, self-contained data structures like points, rectangles, or colors that don't need inheritance.

Performance-Critical Code: In performance-sensitive scenarios, such as game development or real-time applications, using structs can reduce the overhead of heap allocations and garbage collection.

Immutability: If the data should be immutable and never change after creation, structs can help enforce that by design.

-> When Not to Use Structs:

Complex Data Structures: If your object is large or complex, or if you need to modify it frequently, using a class is better due to reference-type behavior (shared access).

Inheritance: If you require polymorphism or inheritance (other than interfaces), classes are more appropriate, as structs cannot inherit from other structs or classes.

Example:

----------------------------------------------------------------------------------------------------------------------
public struct Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public int Area()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main()
    {
        Rectangle rect = new Rectangle(10, 20);
        Console.WriteLine($"Area of rectangle: {rect.Area()}");
    }
}
----------------------------------------------------------------------------------------------------------------------

Summary:

Structures in C# are value types that store data and related functionality on the stack. They are useful for small, performance-critical objects.

Structs do not support inheritance but can implement interfaces.

They are passed by value, not by reference, and should be used for simple data types where inheritance and heap allocation are unnecessary.

*/