/* Types of Inheritances

In C#, there are several types of inheritance that can be implemented depending on the structure of the relationship between classes. However, C# only supports single inheritance for classes, meaning a class can inherit from one base class. Other types of inheritance are achievable through interfaces or class hierarchies. Let’s explore the main types of inheritance in C#:

1. Single Inheritance

In single inheritance, a derived class inherits from a single base class. This is the simplest and most common form of inheritance in C#.

Example:

class Animal  // Base class
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

class Dog : Animal  // Derived class
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}

In this example, the Dog class inherits the Eat method from the Animal class.

2. Multilevel Inheritance

In multilevel inheritance, a class is derived from another derived class. It forms a chain of inheritance where one class inherits from another class, which in turn inherits from a third class.

class Animal  // Base class
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

class Mammal : Animal  // Derived class
{
    public void Breathe()
    {
        Console.WriteLine("Mammal is breathing.");
    }
}

class Dog : Mammal  // Further derived class
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}

3. Hierarchical Inheritance

In hierarchical inheritance, multiple classes inherit from a single base class. This means a single base class is shared by multiple derived classes.

Example:

class Animal  // Base class
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

class Dog : Animal  // Derived class
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}

class Cat : Animal  // Another derived class
{
    public void Meow()
    {
        Console.WriteLine("Cat is meowing.");
    }
}


In this example, both Dog and Cat classes inherit from the Animal class. They each have their own unique methods (Bark and Meow), but share the common Eat method from Animal.

4. Multiple Inheritance (Through Interfaces)

C# does not support multiple inheritance with classes, meaning a class cannot inherit from more than one class. However, C# allows a class to implement multiple interfaces, which provides a way to achieve multiple inheritance-like behavior.

Example:

interface IFlyable
{
    void Fly();
}

interface IRunnable
{
    void Run();
}

class Bird : IFlyable, IRunnable  // Multiple interface implementation
{
    public void Fly()
    {
        Console.WriteLine("Bird is flying.");
    }

    public void Run()
    {
        Console.WriteLine("Bird is running.");
    }
}

Here, the Bird class implements both IFlyable and IRunnable interfaces. Although C# doesn't support multiple inheritance of classes, you can implement multiple interfaces to achieve similar functionality.

5. Hybrid Inheritance

Hybrid inheritance is a combination of two or more types of inheritance. Since C# does not support multiple inheritance with classes, hybrid inheritance is typically achieved through a combination of classes and interfaces.

Example:

interface IWalker
{
    void Walk();
}

class Animal  // Base class
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

class Dog : Animal, IWalker  // Inherits from class and implements interface
{
    public void Walk()
    {
        Console.WriteLine("Dog is walking.");
    }

    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}


In this example, the Dog class inherits from the Animal class and also implements the IWalker interface. This is an example of hybrid inheritance combining single inheritance and multiple interface implementation.

Summary of Inhertiance Types in C#:

Single Inheritance -> A class inherits from one base class.

Multilevel Inheritance -> A class inherits from a class, which in turn inherits from another class. 

Hierarchical Inheritance - Multiple classes inherit from the same base class. 

Multiple Inheritance - A class inherits from multiple base classes (C# Supported via interfaces only)

Hybrid Inheritance - A combination of more than one type of inheritance (classes + interfaces).

*/