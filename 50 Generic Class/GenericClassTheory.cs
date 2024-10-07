/* Generic Classess

Generic classes in C# are classes that allow you to define a class with one or more type parameters, enabling the class to operate on data of various types while maintaining type safety. This means you can create a single class definition that can work with any data type without needing to create multiple versions of the class for different types. Generics provide several benefits, including:

Type Safety: Generics allow for compile-time type checking, which helps catch type-related errors early in the development process, reducing the risk of runtime errors.

Code Reusability: By using generics, you can create a single implementation that can handle multiple data types, reducing code duplication and improving maintainability.

Performance: Generics can improve performance by eliminating the need for boxing and unboxing when working with value types, as they allow you to work directly with the specified type.

Flexibility: You can define generic classes that can accept multiple type parameters, allowing for more complex data structures and algorithms.

Example of a Generic Class

Here’s a simple example of a generic class that represents a pair of values:

-------------------------------------------------------------------------------------------------------------
public class Pair<T1, T2>         // Here T1 and T2 are known as type parameters or placeholders
{
    public T1 First { get; set; }
    public T2 Second { get; set; }

    public Pair(T1 first, T2 second)
    {
        First = first;
        Second = second;
    }
}

// Usage
class Program
{
    static void Main()
    {
        var intStringPair = new Pair<int, string>(1, "One");
        Console.WriteLine($"First: {intStringPair.First}, Second: {intStringPair.Second}");

        var doubleBoolPair = new Pair<double, bool>(3.14, true);
        Console.WriteLine($"First: {doubleBoolPair.First}, Second: {doubleBoolPair.Second}");
    }
}
-------------------------------------------------------------------------------------------------------------

In this example, the Pair<T1, T2> class is a generic class that can hold two values of potentially different types. You can create instances of Pair with any types you need, providing flexibility and type safety. This illustrates how generic classes can be used to create reusable and type-safe components in C#.

*/