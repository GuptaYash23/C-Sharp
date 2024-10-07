/* Operator Overloading

Operator Overloading in C# allows you to define or change the behavior of operators for user-defined types (like classes and structs). This provides a way to make your custom types behave like built-in types when using operators (e.g., +, -, *, /, ==, etc.).

By overloading operators, you can define how operations involving your objects should behave when certain operators are applied.

Syntax of Operator Overloading

In C#, operators can be overloaded by defining a special method in the class or struct. This method uses the operator keyword followed by the operator you want to overload. The method must be marked as public and static. Operators maybe considered as functions internal to the compiler.

Example of Operator Overloading:

Let’s consider a class Point that represents a point in a 2D space. We can overload the + and - operators to add and subtract points, and the == and != operators to compare points.

-------------------------------------------------------------------------
using System;

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    // Constructor to initialize X and Y coordinates
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    // Overloading the + operator to add two points
    public static Point operator +(Point p1, Point p2)
    {
        return new Point(p1.X + p2.X, p1.Y + p2.Y);
    }

    // Overloading the - operator to subtract two points
    public static Point operator -(Point p1, Point p2)
    {
        return new Point(p1.X - p2.X, p1.Y - p2.Y);
    }

    // Overloading the == operator to compare two points
    public static bool operator ==(Point p1, Point p2)
    {
        return p1.X == p2.X && p1.Y == p2.Y;
    }

    // Overloading the != operator to compare two points
    public static bool operator !=(Point p1, Point p2)
    {
        return !(p1 == p2);
    }

    // Overriding the Equals method to complement == operator
    public override bool Equals(object obj)
    {
        if (obj == null || !(obj is Point))
            return false;

        Point p = (Point)obj;
        return X == p.X && Y == p.Y;
    }

    // Overriding the GetHashCode method (best practice when overriding Equals)
    public override int GetHashCode()
    {
        return (X, Y).GetHashCode();
    }

    // Method to display point coordinates
    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point(3, 4);
        Point p2 = new Point(2, 5);

        // Adding two points using overloaded + operator
        Point resultAdd = p1 + p2;
        Console.WriteLine($"p1 + p2 = {resultAdd}");  // Output: (5, 9)

        // Subtracting two points using overloaded - operator
        Point resultSub = p1 - p2;
        Console.WriteLine($"p1 - p2 = {resultSub}");  // Output: (1, -1)

        // Comparing two points using overloaded == operator
        bool areEqual = p1 == p2;
        Console.WriteLine($"p1 == p2: {areEqual}");  // Output: False

        // Comparing two points using overloaded != operator
        bool areNotEqual = p1 != p2;
        Console.WriteLine($"p1 != p2: {areNotEqual}");  // Output: True
    }
}
-------------------------------------------------------------------------

Explanation:

+ Operator Overloading: We define how two Point objects should be added together by adding their X and Y coordinates.

- Operator Overloading: Similarly, we subtract the coordinates of two points.

== and != Operator Overloading: We define the equality (==) and inequality (!=) checks based on the values of the X and Y properties of the points.

ToString(): This is overridden to display the point in a readable format like (X, Y).

Rules for Operator Overloading:

public and static: The operator overloading method must always be public and static.

Return Type: The return type should match the operation being performed (e.g., adding two objects typically returns an object of the same type).

Parameter Types: The method should take the appropriate number of parameters (for binary operators like + and -, there will be two parameters; for unary operators like ++, there will be one parameter).

Paired Operators: If you overload the == operator, you must also overload the != operator (and vice versa).

List of Operators That Can Be Overloaded:

You can overload most operators in C#, including:

Arithmetic Operators: +, -, *, /, %
Comparison Operators: ==, !=, <, >, <=, >=
Logical Operators: &, |, ^, ~
Increment/Decrement: ++, --
Unary Operators: +, -, !

However, some operators like the assignment operator (=), conditional logical operators (&&, ||), and others cannot be overloaded.

Benefits of Operator Overloading:

Code Readability: It allows objects of custom types to be used with operators in a way that’s intuitive, making the code easier to read and maintain.

Flexibility: You can define custom behavior for operators, allowing more natural operations on objects.

Cleaner Code: Overloaded operators reduce the need for verbose method calls, leading to cleaner, more concise code.

Conclusion:

Operator overloading in C# enhances how user-defined types interact with standard operators, allowing you to define custom behavior for common operations. This feature is particularly useful in cases where treating objects like built-in data types makes the code more intuitive and expressive.

*/