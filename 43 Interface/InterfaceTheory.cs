/* Interface

In C#, an interface is a contract that defines a set of methods, properties, events, or indexers that a class or struct must implement, but without providing any implementation details. Interfaces allow you to define functionalities that multiple classes can share, ensuring that they implement specific methods or properties. We can't create an interface instance (object).

Key Features of Interfaces:

No Implementation: Interfaces only declare members like methods, properties, etc., but do not provide implementations for them.

Multiple Inheritance: C# allows a class or struct to implement multiple interfaces, which helps overcome the limitation of single inheritance in classes.

Abstract by Default: All methods and properties declared in an interface are implicitly abstract, meaning they must be implemented in the class that inherits the interface.

No Access Modifiers: Members of an interface do not have access modifiers (like public, private). They are implicitly public, and the implementing class must make them public as well.

Loose Coupling: Interfaces help in decoupling code, making it more flexible and maintainable.

Defining an Interface:

You use the interface keyword to define an interface. Here's an example:

---------------------------------------------------------------------------------------
public interface IAnimal
{
    void Speak();  // Method declaration
    string Name { get; set; }  // Property declaration
}
---------------------------------------------------------------------------------------

In this interface, the method Speak() and the property Name are declared, but not implemented.

Implementing an Interface:

A class implements an interface by providing definitions for all the members declared in the interface. Here's how you can implement the IAnimal interface:

---------------------------------------------------------------------------------------
public class Dog : IAnimal
{
    public string Name { get; set; }

    // Implementation of the Speak method
    public void Speak()
    {
        Console.WriteLine("Woof!");
    }
}

public class Cat : IAnimal
{
    public string Name { get; set; }

    // Implementation of the Speak method
    public void Speak()
    {
        Console.WriteLine("Meow!");
    }
}
---------------------------------------------------------------------------------------

Using Interfaces:

You can use interfaces as types, which allows you to refer to an object by its interface type, promoting polymorphism.

---------------------------------------------------------------------------------------
class Program
{
    static void Main()
    {
        IAnimal dog = new Dog { Name = "Buddy" };
        IAnimal cat = new Cat { Name = "Whiskers" };

        dog.Speak();  // Output: Woof!
        cat.Speak();  // Output: Meow!
    }
}
---------------------------------------------------------------------------------------

Key Points:

Interfaces Define Contracts: Interfaces define a contract that a class must follow by implementing all the members.

Multiple Interfaces: A class can implement more than one interface.

---------------------------------------------------------------------------------------
public interface IMoveable
{
    void Move();
}

public class Robot : IAnimal, IMoveable
{
    public string Name { get; set; }

    public void Speak()
    {
        Console.WriteLine("Beep Boop!");
    }

    public void Move()
    {
        Console.WriteLine("Robot is moving!");
    }
}
---------------------------------------------------------------------------------------

Loose Coupling: By programming to an interface rather than a concrete class, your code becomes more flexible and maintainable, as you can swap different implementations without changing the dependent code

Interface vs Abstract Class:

Abstract Class: Can contain implemented methods, and can have fields or constructors. It allows some shared behavior among derived classes.

Interface: Cannot contain any implementation (before C# 8.0) and provides no behavior—only the contract.

Interfaces are ideal when you want to specify a "can do" behavior for unrelated classes without enforcing how it's done

*/

/* Abstract classes vs Interface

The use of the override keyword in abstract classes and its absence in interface implementations is rooted in how inheritance and method implementation work in C#. Let’s break this down:

1. Abstract Class vs. Interface: Key Differences

Abstract Class:

Can contain both fully implemented methods (concrete methods) and abstract methods (which have no implementation).

A derived class inherits from an abstract class and can override methods from the abstract class to provide specific behavior.

Interface:

Can only declare methods (without implementation) before C# 8.0 (after which it can have default implementations in some cases).

A class implements an interface, which means it provides concrete implementations of all the methods declared by the interface.

2. Why override in Abstract Classes?

When you derive a class from an abstract class, you are inheriting functionality. If the abstract class has declared abstract methods (or virtual methods), the derived class must override those methods to provide specific implementations. This is because abstract methods have no implementation in the abstract class and must be implemented in any derived class.

The override keyword is necessary to indicate that you are providing a new implementation for a method that was already defined as abstract or virtual in the base class.

Example:

---------------------------------------------------------------------------------------
public abstract class Animal
{
    // Abstract method - must be overridden by derived classes
    public abstract void Speak();

    // Virtual method - can be overridden, but provides a default implementation
    public virtual void Eat()
    {
        Console.WriteLine("The animal is eating.");
    }
}

public class Dog : Animal
{
    // Override the abstract method Speak
    public override void Speak()
    {
        Console.WriteLine("Woof!");
    }

    // Override the virtual method Eat
    public override void Eat()
    {
        Console.WriteLine("The dog is eating.");
    }
}
---------------------------------------------------------------------------------------

Key Points:

Abstract method (Speak()): The Dog class must override this method because it was declared abstract in Animal. The override keyword is required.

Virtual method (Eat()): The Dog class can optionally override this method, which already has a default implementation in the base class. Again, override is required to signal that this method is being replaced

3. Why No override in Interfaces?

When a class implements an interface, it is not inheriting functionality but instead providing implementations for methods that are only declared in the interface. Since interfaces do not provide any implementation (in pre-C# 8.0 versions), there is nothing to override—there is no base functionality to modify.

You are implementing the methods for the first time, which is why you use the public modifier to define the methods in the class, not override. The class is simply fulfilling the contract set by the interface.

Example:

---------------------------------------------------------------------------------------
public interface IAnimal
{
    void Speak();  // No implementation, just a method signature
}

public class Dog : IAnimal
{
    // Implementing the method declared in the interface
    public void Speak()
    {
        Console.WriteLine("Woof!");
    }
}
---------------------------------------------------------------------------------------

Key Points:

There’s nothing to override in an interface because interfaces do not provide an implementation to begin with (except default implementations in C# 8.0+, which still require override if you're changing the default behavior).

A class that implements an interface provides its own implementation of the methods declared in the interface.

4. Summary:

Abstract Class:

You use override when the base class (abstract or virtual methods) provides a method that the derived class must or can modify.

The override keyword tells the compiler that you are intentionally changing the behavior of an inherited method.

Interface:

You do not use override because there is no existing implementation to override.

The class implementing the interface is providing the implementation for the first time.
Thus, override is used in abstract classes to modify inherited behavior, while in interfaces, there is no behavior to inherit, only a contract to fulfill.

*/