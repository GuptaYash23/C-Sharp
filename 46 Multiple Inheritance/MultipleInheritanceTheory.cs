/* Multiple Inheritance

In C#, multiple inheritance refers to the ability of a class to inherit from more than one base class. However, C# does not support multiple inheritance of classes directly to avoid the complexities and ambiguities that can arise, such as the "Diamond Problem." Instead, C# allows a class to implement multiple interfaces, which provides a way to achieve similar functionality without the complications of multiple class inheritance.

Key Points about Multiple Inheritance in C#

No Multiple Class Inheritance:

In C#, a class can inherit from only one base class. This means you cannot have a class that directly inherits from multiple classes.

Example of invalid multiple inheritance:

---------------------------------------------------------------------------
class Base1 { }
class Base2 { }
class Derived : Base1, Base2 { } // This will cause a compile-time error
---------------------------------------------------------------------------

Interfaces as a Solution:

C# allows a class to implement multiple interfaces. This is a way to achieve multiple inheritance-like behavior.

A class can implement multiple interfaces, and each interface can define its own methods and properties.

Example:

---------------------------------------------------------------------------
interface IFirst
{
    void MethodA();
}

interface ISecond
{
    void MethodB();
}

class MyClass : IFirst, ISecond
{
    public void MethodA()
    {
        Console.WriteLine("Method A from IFirst");
    }

    public void MethodB()
    {
        Console.WriteLine("Method B from ISecond");
    }
}
---------------------------------------------------------------------------

Diamond Problem:

The "Diamond Problem" occurs when a class inherits from two classes that have a common base class. This can lead to ambiguity about which base class's method should be called.

C# avoids this problem by not allowing multiple class inheritance. Instead, it uses interfaces, which do not have implementation details, thus avoiding ambiguity.

Interface Inheritance:

Interfaces can inherit from other interfaces, allowing for a hierarchy of interfaces. A class that implements an interface must implement all the methods defined in that interface and any interfaces it inherits from.

---------------------------------------------------------------------------
interface IBase
{
    void BaseMethod();
}

interface IDerived : IBase
{
    void DerivedMethod();
}

class MyDerivedClass : IDerived
{
    public void BaseMethod()
    {
        Console.WriteLine("Base method implementation");
    }

    public void DerivedMethod()
    {
        Console.WriteLine("Derived method implementation");
    }
}
---------------------------------------------------------------------------

Default Interface Methods:

Starting from C# 8.0, interfaces can have default implementations for methods. This allows you to add new methods to interfaces without breaking existing implementations. However, if a class implements multiple interfaces with the same method signature, it must provide its own implementation to resolve the ambiguity.

Summary

C# does not support multiple inheritance of classes to avoid complexity and ambiguity.

A class can implement multiple interfaces, allowing for a form of multiple inheritance.

Interfaces can inherit from other interfaces, and classes must implement all methods from the interfaces they implement.

C# 8.0 introduced default interface methods, allowing interfaces to provide default implementations while still requiring classes to resolve any ambiguities.

This design choice in C# promotes a cleaner and more maintainable code structure while still allowing for flexible design patterns through the use of interfaces.

*/
