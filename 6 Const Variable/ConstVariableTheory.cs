/* C# const keyword

In C#, the const keyword is used to declare a constant field or local variable, meaning its value is set at compile time and cannot be changed afterward. Here's a breakdown:

Key Points about const in C#:

Immutable Value: Once a const variable is assigned a value, it cannot be modified throughout the program. This is because the value is hard-coded directly into the compiled code.

Compile-Time Constant: The value of a const variable must be known at compile time. This means you can only assign literals or other const values to a const variable. You cannot assign the result of a runtime operation.

Static by Default: const fields are implicitly static, meaning they belong to the type itself rather than to a specific instance of the type. You don't need to use the static keyword explicitly.

Types Allowed: You can use const with simple types like int, float, double, char, string, bool, and enum. Custom objects or complex types are not allowed as const.

Example usage:

-----------------------------------------------------------------
public class Example
{
    // Declaring a const field
    public const int MyConstValue = 10;
    
    public void DisplayConstant()
    {
        // Accessing the const value
        Console.WriteLine(MyConstValue); // Output: 10
    }
}
-----------------------------------------------------------------

In this example, MyConstValue is a constant integer with a value of 10. Once set, this value cannot be changed anywhere in the code.

Summary

Use const when you have a value that you know will never change throughout the lifetime of the program.

It is especially useful for defining things like mathematical constants (e.g., const double Pi = 3.14159;) or fixed configuration values.

If you need a variable that can be initialized at runtime but cannot be changed afterward, consider using the readonly keyword instead.

*/

/* C# readonly 

In C#, if you declare an object using the const keyword, you cannot change the reference or modify the object because const can only be applied to primitive types and strings.

Using readonly in C#:

A readonly field can be assigned only during its declaration or in the constructor of the class in which it is declared.

While the reference to the object itself cannot be changed once it is assigned, the internal state of the object (i.e., its properties and fields) can be modified.

Example of readonly in C#:

-----------------------------------------------------------------
public class Example
{
    public readonly Dictionary<string, int> MyDictionary;

    public Example()
    {
        // Assigning the dictionary in the constructor
        MyDictionary = new Dictionary<string, int>
        {
            { "Key1", 100 }
        };
    }

    public void ModifyDictionary()
    {
        // Modifying the dictionary - this is allowed
        MyDictionary["Key1"] = 200;   // Changing the value of an existing key
        MyDictionary["Key2"] = 300;   // Adding a new key-value pair
    }
}
-----------------------------------------------------------------

Explanation:

MyDictionary is declared as readonly, meaning the reference to this dictionary cannot be changed after it is assigned in the constructor.

However, you can still modify the contents of the dictionary (i.e., add, update, or remove key-value pairs), similar to how you would modify an object's properties in JavaScript after it is declared with const.

Key Differences Between const and readonly:

const: The value is fixed at compile time and cannot change. Applicable only to primitive types, string, and enum.

readonly: The value is fixed after the object is constructed, but the internal state of the object can be modified.

So, if you need to declare an object in C# and want to ensure that the reference to the object cannot be changed but its internal state can be modified, use readonly instead of const.

*/