/* Method Overriding

Method overriding in C# is a core feature of object-oriented programming (OOP), enabling run-time polymorphism. It occurs when a subclass (or derived class) provides a specific implementation for a method that is already defined in its superclass (or base class).

Key Points of Method Overriding:

Inheritance: The method that is being overridden must be defined in a parent class, and the subclass inherits from this class.

Virtual and Override Keywords:

The method in the base class must be marked with the virtual keyword.

The method in the derived class that overrides the base class method must use the override keyword (mandatory for overriding base class function).

Run-Time Polymorphism: This allows the program to decide which method implementation to invoke at runtime (the one from the base class or the one from the derived class). This decision depends on the type of the object, not the reference type.

Example:

-------------------------------------------------------------------------
// Base Class
public class Animal
{
    // Virtual method to be overridden
    public virtual void Speak()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

// Derived Class
public class Dog : Animal
{
    // Overriding the Speak method
    public override void Speak()
    {
        Console.WriteLine("The dog barks.");
    }
}

// Main method
class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();
        Animal myDog = new Dog();

        // Calls the method of the base class
        myAnimal.Speak(); // Output: "The animal makes a sound."

        // Calls the overridden method in the Dog class
        myDog.Speak(); // Output: "The dog barks."
    }
}
-------------------------------------------------------------------------

Explanation:

Base class (Animal): It contains a virtual method Speak(), which can be overridden.

Derived class (Dog): It provides its own implementation of the Speak() method, marked with the override keyword.

At runtime, when myDog.Speak() is called, it dynamically selects the Dog class implementation of Speak(), achieving runtime polymorphism.
This allows developers to define methods in a parent class and have specific implementations in child classes, offering flexibility and scalability in code design.

*/