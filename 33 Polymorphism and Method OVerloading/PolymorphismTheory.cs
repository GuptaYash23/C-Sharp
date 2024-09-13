/* Polymorphism

Polymorphism is a key concept in object-oriented programming (OOP) that allows objects of different types to be treated as objects of a common base type. 

In C#, polymorphism enables methods to behave differently based on the object that calls them. There are two main types of polymorphism in C#: compile-time (or static) polymorphism and run-time (or dynamic) polymorphism.

1. Compile-time Polymorphism (Method Overloading and Operator Overloading)

In compile-time polymorphism, the method to be invoked is determined at compile time. This is achieved using method overloading or operator overloading.

2. Run-time Polymorphism (Method Overriding)

Run-time polymorphism occurs when the method to be invoked is determined at run-time. This is achieved through method overriding and the use of virtual and override keywords in C#. It requires inheritance.

Method Overloading

Method overloading is a feature in C# that allows you to define multiple methods with the same name but different signatures (i.e., different parameter types or different number of parameters). The correct method is chosen based on the number and type of arguments passed at compile time.

Key Points:

Methods must have the same name.

The number or types of parameters must differ.

The return type alone cannot be used to overload a method.

Example of Method Overloading:

-------------------------------------------------------
using System;

public class Calculator
{
    // Method with two integer parameters
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Overloaded method with three integer parameters
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    // Overloaded method with two double parameters
    public double Add(double a, double b)
    {
        return a + b;
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        // Calling different overloads of the Add method
        Console.WriteLine(calc.Add(3, 4));           // Calls Add(int, int) -> Output: 7
        Console.WriteLine(calc.Add(3, 4, 5));        // Calls Add(int, int, int) -> Output: 12
        Console.WriteLine(calc.Add(3.5, 4.5));       // Calls Add(double, double) -> Output: 8.0
    }
}
-------------------------------------------------------

Run-time Polymorphism (Method Overriding)

Method overriding is a type of polymorphism in which a derived class provides a specific implementation of a method that is already defined in its base class. The base class method is marked with the virtual keyword, and the derived class overrides it using the override keyword. This enables run-time polymorphism because the decision about which method to call is made at runtime.

Example of Method Overriding:

-------------------------------------------------------
using System;

// Base class
public class Animal
{
    // Virtual method in base class
    public virtual void Speak()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

// Derived class
public class Dog : Animal
{
    // Override method in derived class
    public override void Speak()
    {
        Console.WriteLine("The dog barks.");
    }
}

// Derived class
public class Cat : Animal
{
    // Override method in derived class
    public override void Speak()
    {
        Console.WriteLine("The cat meows.");
    }
}

class Program
{
    static void Main()
    {
        // Create instances of the derived classes
        Animal myDog = new Dog();
        Animal myCat = new Cat();

        // Call the Speak method on the objects
        myDog.Speak();  // Output: The dog barks.
        myCat.Speak();  // Output: The cat meows.
    }
}
-------------------------------------------------------

Explanation:

Method Overloading occurs when multiple methods have the same name but different parameter lists (e.g., Add(int, int) and Add(double, double) in the example). The appropriate method is chosen at compile-time based on the arguments passed.

Method Overriding allows a derived class to provide its specific implementation of a base class method (e.g., Dog and Cat override the Speak() method of the Animal class). The correct method is called based on the actual object type at runtime.

Summary:

Method Overloading is an example of compile-time polymorphism (method is selected based on parameters at compile-time).

Method Overriding is an example of run-time polymorphism (method is selected based on the actual object at runtime).

*/