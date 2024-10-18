/* Extension Methods in C# 

Extension methods allows you to inject additional methods without modifying, deriving or recompiling the original class, struct or interface.

Can use inheritance to use additional methods without modifiying the original class, but inheritance fails when we use struct (there is no inheritance in structures) or we use a sealed class (as we cannot apply inhertiance on sealed classes).

Extension methods are defined as static methods but once they bind with any class or structure then they convert into non-static or instace methods.

If an extension method is defined with the same name, and same signature of an existing method in the class, then extension method will not be called and ignored.

(this program p) -> It is a binding parameter only (not an original parameter)

When you call any extension method no need to provide value to this binding parameter.

If you want to provide parameters to extension method then you an place your parameter after the binding parameter

Binding parameter should always be the first parameter in the parameter list.

Binding parameter is ignored always but bot other parameters.

Only one binding parameter is allowed.

Extension methods can be used with struct too.

Extension methods, as the name suggests are additional methods.

Extension methods are static methods.

Extension method is a new feature that has been added in C# 3.0

Extension methods can be added to your own custom class, .NET framework classes, or third party classes or interface.

Extension methods in C# are a powerful feature that allows developers to "add" methods to existing types without modifying the original type, creating a new derived type, or using reflection. Extension methods enable us to extend the functionality of types we do not control (like types from the .NET Framework or third-party libraries) without altering the original source code

-> How Extension Methods Work:

Extension methods are static methods that are defined in a static class.

They are called as if they are instance methods on the extended type, even though they are static.

The first parameter of an extension method specifies the type that the method operates on. This parameter is prefixed with the this keyword to indicate that it is an extension method.

-> Defining an Extension Method:

Here’s the general syntax for creating an extension method:

---------------------------------------------------------------
public static class MyExtensions
{
    public static int WordCount(this string str)
    {
        return str.Split(' ').Length;
    }
}
---------------------------------------------------------------

In this example, we are extending the string class with a new method WordCount.

The method is static, defined in a static class called MyExtensions.

The first parameter this string str indicates that this method extends the string class. The str parameter refers to the instance on which the method is called.

-> Using an Extension Method:

Once the extension method is defined, you can call it as though it were an instance method of the type it's extending:

---------------------------------------------------------------
string sentence = "Hello world from C#";
int count = sentence.WordCount();  // Output: 4
---------------------------------------------------------------

The WordCount method is invoked as if it were part of the string class, even though string does not have a WordCount method.

Key Points:

Static Method in Static Class: Extension methods must be defined in a static method inside a static class.

this Keyword: The first parameter must be prefixed with the this keyword, followed by the type you want to extend.

Namespace and Scope: The extension method will be available when the namespace in which the static class resides is imported (using using directive).

Instance-like Invocation: Although extension methods are static, they are invoked as if they are instance methods on the extended type.

Example of Extending Built-In Types:

Here’s an example of an extension method that extends the int type:

---------------------------------------------------------------
public static class IntExtensions
{
    public static bool IsEven(this int number)
    {
        return number % 2 == 0;
    }
}
---------------------------------------------------------------

Usage:

---------------------------------------------------------------
int num = 10;
bool result = num.IsEven();  // Output: true
---------------------------------------------------------------

Example of Extending a Custom Class:

You can also create extension methods for your own custom classes:

---------------------------------------------------------------
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

public static class PersonExtensions
{
    public static string GetFullName(this Person person)
    {
        return $"{person.FirstName} {person.LastName}";
    }
}
---------------------------------------------------------------

Usage:

---------------------------------------------------------------
Person person = new Person { FirstName = "John", LastName = "Doe" };
string fullName = person.GetFullName();  // Output: "John Doe"
---------------------------------------------------------------

-> Advantages of Extension Methods:

Non-Invasive: You can add functionality to types that you do not have control over (e.g., types from external libraries or sealed classes).

Readable and Maintainable: Extension methods allow for more readable code, as they can be called in an instance method-like syntax.

Helpful for LINQ: LINQ (Language-Integrated Query) heavily relies on extension methods for making complex operations on collections simple and readable.

-> Limitations of Extension Methods:

(i) Cannot Override Existing Methods: Extension methods do not override existing methods; they only appear if there is no existing method with the same signature.

(ii) Static Context: Extension methods are static, so they cannot access the private members of the extended type.

(iii) Resolution: If an instance method with the same name exists, the instance method takes precedence over the extension method.

-> Conclusion:

Extension methods in C# allow you to extend existing types in a non-intrusive manner. They offer flexibility for adding new functionality without altering the type’s source code, and they are particularly useful in scenarios where modifying existing types is not possible, such as third-party or built-in .NET types.

*/