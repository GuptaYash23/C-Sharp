/* Sealed Keyword

In C#, a sealed class is a class that cannot be inherited by any other class. This is useful when you want to prevent further derivation and modifications to a class’s functionality. Sealed keyword for method is only used with override keyword (not applicable to new keyword methods or base class methods/overriden methods).

Syntax:

The sealed keyword is used to declare a sealed class.

------------------------------------------------------------------------
public sealed class MyClass
{
    // Class implementation
}
------------------------------------------------------------------------

Key Characteristics of Sealed Classes:

1) Prevents Inheritance: Once a class is marked as sealed, no other class can inherit from it. This ensures that the behavior of the class remains unchanged and prevents unintended extensions or modifications.

For eg)

------------------------------------------------------------------------
sealed class Animal
{
    public void Speak()
    {
        Console.WriteLine("The animal speaks.");
    }
}

// This will cause a compile-time error
class Dog : Animal
{
    // Not allowed to inherit from a sealed class
}
------------------------------------------------------------------------

2) Performance Optimization: Sealed classes can offer slight performance benefits because the runtime knows that no other class will derive from it, allowing certain optimizations, such as method inlining.

3) Use Case: Sealed classes are often used when you want to restrict the inheritance of classes that are considered stable, complete, or security-critical.

Sealing Methods in a Class:

If a class is not sealed but you want to prevent certain methods from being overridden, you can mark specific methods as sealed. This is done in conjunction with overriding methods.

A method can be sealed in a derived class to prevent further overriding in subsequent derived classes.

For eg)

------------------------------------------------------------------------
public class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("The animal speaks.");
    }
}

public class Dog : Animal
{
    // Sealing the method so it cannot be overridden further
    public sealed override void Speak()
    {
        Console.WriteLine("The dog barks.");
    }
}

// This class cannot override Speak() because it is sealed in Dog
public class Bulldog : Dog
{
    // Error: Cannot override sealed member 'Dog.Speak()'
    // public override void Speak() { }
}
------------------------------------------------------------------------

Summary:

A sealed class cannot be inherited by any other class.

It is used to restrict further modification through inheritance.

It can slightly improve performance due to runtime optimizations.

Methods can also be marked as sealed to prevent further overriding, even if the class itself is not sealed.

Sealed classes are commonly used when the behavior of a class is finalized or for security reasons where modification through inheritance should be restricted.

*/