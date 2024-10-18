/* Concrete Class

A concrete class is a class that has an implementation for all of it's methods.

- All methods have their body {}

- They cannot have any unimplemented methods (methods without body)

It can also extend an abstract class or implement an interface as long as it implements all their methods

It is a complete class and can be instantiated. (We can always create object of concrete class)

Necessary condition for a concrete class: There must be an implementation for each and every method.

Concrete class is nothing but normal class, we may use it as a base class.

It cannot contain abstract methods

We can create object and work with this class.

A concrete class is used to define a useful object that can be instatiated as an automatic variable on the program stack.

In other words, we can say that any class which is not abstract is a concrete class.

---------------------------------------------------------------------------------------------------------------------

Concrete Classes in C#

A concrete class in C# is a class that can be instantiated, meaning that you can create objects (instances) from it. It provides implementations for all its methods and does not leave any method or member as abstract or virtual without a definition.

In simpler terms, a concrete class is a regular class with fully defined behavior, and it contrasts with abstract classes or interfaces, which cannot be instantiated directly.

-> Characteristics of Concrete Classes:

- Fully Implemented Methods: All methods in a concrete class have complete implementations.

- Can Instantiate Objects: You can create instances (objects) of a concrete class.

- Not Marked as Abstract: A concrete class is not marked with the abstract keyword.

- Can Inherit from Other Classes: A concrete class can inherit from an abstract class or implement interfaces, but it must provide implementations for all abstract or interface methods.

Example:

---------------------------------------------------------------------------------------------------------------------
using System;

public class Animal // Concrete class
{
    // Properties
    public string Name { get; set; }
    public int Age { get; set; }

    // Constructor
    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Fully implemented method
    public void Speak()
    {
        Console.WriteLine($"{Name} is speaking.");
    }
}

class Program
{
    static void Main()
    {
        // Creating an instance of a concrete class
        Animal dog = new Animal("Buddy", 5);

        // Accessing properties and methods of the concrete class
        Console.WriteLine($"Animal: {dog.Name}, Age: {dog.Age}");
        dog.Speak();
    }
}
---------------------------------------------------------------------------------------------------------------------

Explanation:

1. Animal Class:

This is a concrete class because it can be instantiated and has all methods implemented.

The Speak method is fully implemented and can be called by any instance of the class.

The Animal class is not marked as abstract, meaning you can create objects of this class (e.g., dog in the Main method).

2. Object Instantiation:

In the Main method, the Animal class is instantiated by creating an object called dog. This demonstrates that Animal is a concrete class because objects can be created from it.

-> Concrete Class vs Abstract Class

1. Concrete Class:

Can be instantiated (objects can be created from it).

Provides full implementations of all methods.

Can inherit from abstract classes or implement interfaces but must provide implementations for inherited abstract methods.

2. Abstract Class:

Cannot be instantiated directly (you cannot create objects from it).

May contain abstract methods (methods without implementation) that must be implemented by derived classes.

Intended to serve as a base class for other classes to inherit from.

Example of Abstract Class (for comparison):

---------------------------------------------------------------------------------------------------------------------
public abstract class Animal // Abstract class
{
    public string Name { get; set; }

    // Abstract method (no implementation here)
    public abstract void Speak();
}

public class Dog : Animal // Concrete class derived from abstract class
{
    // Implementing abstract method
    public override void Speak()
    {
        Console.WriteLine($"{Name} barks.");
    }
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog { Name = "Buddy" };
        dog.Speak(); // Output: Buddy barks.
    }
}
---------------------------------------------------------------------------------------------------------------------

Summary:

Concrete Class: A regular class with complete method implementations that can be instantiated to create objects.

Abstract Class: A class meant to be a blueprint for other classes and cannot be instantiated directly.

In real-world applications, you use concrete classes for creating objects with actual behavior, while abstract classes and interfaces provide templates for how concrete classes should behave.

*/