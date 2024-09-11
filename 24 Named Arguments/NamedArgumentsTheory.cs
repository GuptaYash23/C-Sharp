/* Named Arguments

In C#, named arguments allow you to specify the names of the parameters when calling a method, rather than just providing the values in the order they are defined in the method signature. This feature enhances code readability and allows you to omit optional parameters.

Syntax

When using named arguments, you specify the parameter name followed by a colon and then the value. Here’s the general syntax:

------------------------------------------------------------------------
MethodName(parameterName1: value1, parameterName2: value2, ...);
------------------------------------------------------------------------

Example:

Consider the following method definition:

------------------------------------------------------------------------
public void DisplayInfo(string name, int age, string city = "Unknown")
{
    Console.WriteLine($"Name: {name}, Age: {age}, City: {city}");
}
------------------------------------------------------------------------

You can call this method using named arguments in several ways:

Using all named arguments:

------------------------------------------------------------------------
DisplayInfo(name: "Alice", age: 30, city: "New York");
------------------------------------------------------------------------

Omitting optional parameters:

------------------------------------------------------------------------
DisplayInfo(name: "Bob", age: 25);
------------------------------------------------------------------------

In this case, the city parameter will take its default value of "Unknown".

Mixing named and positional arguments:

You can also mix named and positional arguments, but named arguments must come after any positional arguments:

------------------------------------------------------------------------
DisplayInfo("Charlie", age: 28);
------------------------------------------------------------------------

Benefits of Named Arguments

Improved Readability: Named arguments make it clear what each argument represents, which is especially useful when a method has many parameters or when the parameters are of the same type.

Flexibility with Optional Parameters: You can skip optional parameters without needing to specify all preceding parameters.

Order Independence: You can specify arguments in any order, which can be helpful in methods with many parameters.

Conclusion

Named arguments are a powerful feature in C# that can lead to more readable and maintainable code. They are particularly useful when dealing with methods that have multiple parameters, especially when some of them are optional.

*/