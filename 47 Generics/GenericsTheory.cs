/* Generics

Generics in C# are a powerful feature that allows you to define classes, interfaces, and methods with a placeholder for the data type. This means you can create type-safe data structures and algorithms that can work with any data type without sacrificing performance or type safety. Generics help reduce code duplication and improve code reusability.

Generic methods process values whose data types are known only when accessing the variables that store these values.

A generic method is declared with the generic type parameter list enclosed within angular brackets.

Defining methods with type parameters allow you to call the method with a different type every time.

You can declare a generic method within generic or non-generic class declarations.

Generic methods can be declared with the following keywords:

-> Virtual
-> Override
-> Abstract

Key Concepts of Generics in C#:

Type Parameters: Generics use type parameters, which are specified in angle brackets (<>). For example, in a generic class or method, you can define a type parameter like T:

Example:

---------------------------------------------------------------------------
public class GenericClass
{
    private T data;

    public GenericClass(T value)
    {
        data = value;
    }

    public T GetData()
    {
        return data;
    }
}
---------------------------------------------------------------------------

Generic Methods: You can also define methods that use generics. This allows you to create methods that can operate on different types:

---------------------------------------------------------------------------
public T GetDefault<T>()
{
    return default(T); // Returns the default value for the type T
}
---------------------------------------------------------------------------

Type Safety: Generics provide compile-time type checking, which helps catch type-related errors early in the development process. This means that you can avoid runtime errors that occur due to type mismatches.

Code Reusability: By using generics, you can create a single implementation that works with multiple data types, reducing the need for multiple class or method definitions for different types.

Constraints: You can impose constraints on type parameters to restrict the types that can be used. For example, you can specify that a type parameter must be a reference type, a value type, or must implement a specific interface:

---------------------------------------------------------------------------
public class GenericClass<T> where T : class
{
    // Implementation
}
---------------------------------------------------------------------------

Collections: The .NET Framework provides a rich set of generic collections, such as List<T>, Dictionary<TKey, TValue>, and HashSet<T>, which are widely used for storing and manipulating data in a type-safe manner.

Example of Generics:

Here’s a simple example of a generic method that swaps two elements in an array:

---------------------------------------------------------------------------
public static void Swap<T>(T[] array, int index1, int index2)
{
    T temp = array[index1];
    array[index1] = array[index2];
    array[index2] = temp;
}

// Usage
int[] numbers = { 1, 2, 3 };
Swap(numbers, 0, 2); // Swaps the first and last elements
---------------------------------------------------------------------------

In this example, the Swap method is generic and can work with any type of array, providing flexibility and type safety.

Benefits of Using Generics:

Performance: Generics eliminate the need for boxing and unboxing when working with value types, which can improve performance.

Type Safety: Generics provide compile-time type checking, reducing the risk of runtime errors.

Code Clarity: Generics can make your code more readable and maintainable by clearly indicating the types being used.

Overall, generics are a fundamental part of C# that enhance the language's expressiveness and efficiency, making it easier to write robust and reusable code.

*/