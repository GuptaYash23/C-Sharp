/* Static Properties

In C#, static properties are properties that belong to the class itself rather than to any specific instance of the class. This means they can be accessed without creating an instance of the class. Static properties are useful when you need a value or behavior that is shared across all instances of a class.

Key Characteristics:

Shared across all instances: A static property is shared by all objects of the class. Changing its value affects all instances.

Accessed via the class name: You can access a static property by using the class name instead of creating an instance of the class.

Cannot use instance members: Static properties cannot directly access instance variables or instance methods of the class. They can only interact with other static members.

Syntax:

-------------------------------------------------------
public class MyClass
{
    // Static field
    private static int _counter;

    // Static property
    public static int Counter
    {
        get { return _counter; }
        set { _counter = value; }
    }
}
-------------------------------------------------------

Accessing a Static Property:

-------------------------------------------------------
// Accessing static property without creating an instance
Console.WriteLine(MyClass.Counter);

// Modifying static property
MyClass.Counter = 10;
-------------------------------------------------------

Example:

-------------------------------------------------------
public class BankAccount
{
    // Static property shared by all instances
    public static double InterestRate { get; set; } = 0.05;
}

// Accessing the static property
Console.WriteLine(BankAccount.InterestRate); // Output: 0.05

// Modifying the static property
BankAccount.InterestRate = 0.07;
Console.WriteLine(BankAccount.InterestRate); // Output: 0.07
-------------------------------------------------------

In this example, InterestRate is a static property that is the same for all bank accounts, and it can be accessed without creating a BankAccount object.

*/