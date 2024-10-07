/* C# Inheritance

Inheritance in C#

Inheritance is one of the key concepts of object-oriented programming (OOP) in C#. It allows a class (called the derived class or child class) to inherit properties and behaviors (fields and methods) from another class (called the base class or parent class). This promotes code reusability, as common functionality can be written in the base class and shared by derived classes.

Basic Syntax of Inheritance

In C#, inheritance is implemented using a colon (:) to indicate that a class derives from a base class:

--------------------------------------------------------
class BaseClass
{
    // Fields, properties, and methods of the base class
}

class DerivedClass : BaseClass
{
    // Fields, properties, and methods of the derived class
}
--------------------------------------------------------

Key Points:

The derived class inherits all accessible members (methods, fields, properties) of the base class except constructors and destructors.

The derived class can override or extend the functionality of the base class.

C# supports single inheritance only, meaning a class can inherit from only one base class. However, it can implement multiple interfaces.

Example of inheritance:

--------------------------------------------------------
using System;

class Animal
{
    public string Name { get; set; }

    // Base class method
    public void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
    }
}

class Dog : Animal
{
    // Derived class method
    public void Bark()
    {
        Console.WriteLine($"{Name} is barking.");
    }
}

class Program
{
    static void Main()
    {
        // Creating an instance of the derived class
        Dog dog = new Dog();
        dog.Name = "Buddy";

        // Accessing base class method
        dog.Eat();

        // Accessing derived class method
        dog.Bark();
    }
}
--------------------------------------------------------

Output:

--------------------------------------------------------
Buddy is eating.
Buddy is barking.
--------------------------------------------------------

Explanation:

The Dog class inherits from the Animal class. This means the Dog class can use the Eat() method from Animal as well as its own Bark() method.

Dog also inherits the Name property from Animal.

Access Modifiers and Inheritance

The visibility of members (fields, methods, properties) in a base class is controlled by access modifiers:

public: Accessible in both the base and derived classes.

protected: Accessible within the base class and derived classes but not outside.

private: Accessible only within the base class (not inherited by derived classes).

internal: Accessible within the same assembly, but not necessarily in the derived class if it's in a different assembly.

protected internal: Accessible within the same assembly and from derived classes.

Example of Access Modifiers:

--------------------------------------------------------
class Animal
{
    private string privateProperty = "Private";
    protected string protectedProperty = "Protected";
    public string publicProperty = "Public";
}

class Dog : Animal
{
    public void ShowProperties()
    {
        // Console.WriteLine(privateProperty); // Not accessible
        Console.WriteLine(protectedProperty);  // Accessible
        Console.WriteLine(publicProperty);     // Accessible
    }
}
--------------------------------------------------------

Method Overriding

Derived classes can override methods from the base class to provide specific implementations. To override a method, the base class method must be marked as virtual, and the derived class method must be marked as override.

--------------------------------------------------------
class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal is making a sound.");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog is barking.");
    }
}

class Program
{
    static void Main()
    {
        Animal animal = new Animal();
        animal.Speak(); // Output: Animal is making a sound.

        Dog dog = new Dog();
        dog.Speak(); // Output: Dog is barking.

        Animal animalDog = new Dog(); // Polymorphism
        animalDog.Speak(); // Output: Dog is barking.
    }
}
--------------------------------------------------------

Inheritance in C#

Inheritance is one of the key concepts of object-oriented programming (OOP) in C#. It allows a class (called the derived class or child class) to inherit properties and behaviors (fields and methods) from another class (called the base class or parent class). This promotes code reusability, as common functionality can be written in the base class and shared by derived classes.

Basic Syntax of Inheritance

In C#, inheritance is implemented using a colon (:) to indicate that a class derives from a base class:

--------------------------------------------------------
class BaseClass
{
    // Fields, properties, and methods of the base class
}

class DerivedClass : BaseClass
{
    // Fields, properties, and methods of the derived class
}
--------------------------------------------------------

Key Points:

The derived class inherits all accessible members (methods, fields, properties) of the base class except constructors and destructors.

The derived class can override or extend the functionality of the base class.

C# supports single inheritance only, meaning a class can inherit from only one base class. However, it can implement multiple interfaces.

Example of Inheritance:

--------------------------------------------------------
using System;

class Animal
{
    public string Name { get; set; }

    // Base class method
    public void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
    }
}

class Dog : Animal
{
    // Derived class method
    public void Bark()
    {
        Console.WriteLine($"{Name} is barking.");
    }
}

class Program
{
    static void Main()
    {
        // Creating an instance of the derived class
        Dog dog = new Dog();
        dog.Name = "Buddy";

        // Accessing base class method
        dog.Eat();

        // Accessing derived class method
        dog.Bark();
    }
}
--------------------------------------------------------

Output:

--------------------------------------------------------
Buddy is eating.
Buddy is barking.
--------------------------------------------------------

Explanation:

The Dog class inherits from the Animal class. This means the Dog class can use the Eat() method from Animal as well as its own Bark() method.

Dog also inherits the Name property from Animal.

Access Modifiers and Inheritance

The visibility of members (fields, methods, properties) in a base class is controlled by access modifiers:

public: Accessible in both the base and derived classes.
protected: Accessible within the base class and derived classes but not outside.

private: Accessible only within the base class (not inherited by derived classes).

internal: Accessible within the same assembly, but not necessarily in the derived class if it's in a different assembly.

protected internal: Accessible within the same assembly and from derived classes.

Example of Access Modifiers:

--------------------------------------------------------
class Animal
{
    private string privateProperty = "Private";
    protected string protectedProperty = "Protected";
    public string publicProperty = "Public";
}

class Dog : Animal
{
    public void ShowProperties()
    {
        // Console.WriteLine(privateProperty); // Not accessible
        Console.WriteLine(protectedProperty);  // Accessible
        Console.WriteLine(publicProperty);     // Accessible
    }
}
--------------------------------------------------------

Output:

--------------------------------------------------------
Protected
Public
--------------------------------------------------------

Method Overriding

Derived classes can override methods from the base class to provide specific implementations. To override a method, the base class method must be marked as virtual, and the derived class method must be marked as override.

Example:

--------------------------------------------------------
class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal is making a sound.");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog is barking.");
    }
}

class Program
{
    static void Main()
    {
        Animal animal = new Animal();
        animal.Speak(); // Output: Animal is making a sound.

        Dog dog = new Dog();
        dog.Speak(); // Output: Dog is barking.

        Animal animalDog = new Dog(); // Polymorphism
        animalDog.Speak(); // Output: Dog is barking.
    }
}
--------------------------------------------------------

Key Points:

virtual: Indicates that the method can be overridden in derived classes.

override: Used in the derived class to override the base class method.

Polymorphism: When an object of the base class type can refer to an object of the derived class, and the overridden method is called.

base Keyword

The base keyword is used in a derived class to refer to members of the base class. It can be used to call the base class constructor or methods.

Example of base Keyword:

--------------------------------------------------------
class Animal
{
    public string Name { get; set; } // defined get set properties

    public Animal(string name)
    {
        Name = name;
    }

    public virtual void Speak()
    {
        Console.WriteLine($"{Name} is making a sound.");
    }
}

class Dog : Animal
{
    public Dog(string name) : base(name) // Calling the base class constructor
    {
    }

    public override void Speak()
    {
        base.Speak();  // Calling the base class method
        Console.WriteLine($"{Name} is barking.");
    }
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog("Buddy");
        dog.Speak();
    }
}
--------------------------------------------------------

In this example, the base keyword is used to call the base class constructor and method.

Conclusion:

Inheritance allows you to create a new class based on an existing class, reusing code and promoting maintainability.

The derived class inherits the base class's methods, properties, and fields, and can extend or override them as needed.

Polymorphism enables using base class references to call overridden methods in derived classes.

Using access modifiers like protected, public, and private helps control visibility of members across inheritance.

*/


/* get; set; properties

In C#, the get; set; syntax is used to define automatic properties. These properties provide a shorthand way to define a property without explicitly declaring a private field (also known as a backing field) and the corresponding get and set methods.

Breakdown of public string Name { get; set; }

This line defines a public property named Name of type string with both a getter and a setter:

public: The property is accessible from outside the class.

string: The type of the property is a string.

{ get; set; }: These are accessors:

get: This accessor allows you to retrieve the value of the property.

set: This accessor allows you to assign a value to the property.

C# automatically creates a private field to store the value of Name (behind the scenes) and manages the get and set access to that field.

Example Usage:

--------------------------------------------------------
class Person
{
    public string Name { get; set; }  // Auto-implemented property
}

class Program
{
    static void Main()
    {
        Person person = new Person();
        
        // Using the setter to assign a value
        person.Name = "John";

        // Using the getter to retrieve the value
        Console.WriteLine(person.Name);  // Output: John
    }
}
--------------------------------------------------------

Equivalent (Without get; set; Shorthand)

Without the shorthand syntax, you would manually create a private backing field and the corresponding get and set methods:

--------------------------------------------------------
class Person
{
    private string _name;  // Backing field

    public string Name     // Property
    {
        get { return _name; }
        set { _name = value; }
    }
}
--------------------------------------------------------

The shorthand get; set; is much more concise and serves the same purpose as the above explicit implementation.

get; set; in More Detail

get accessor: When you access the property, the get accessor is called, which returns the value stored in the backing field.

set accessor: When you assign a value to the property, the set accessor is called, which stores the value in the backing field. The set accessor also has an implicit parameter called value, which represents the value being assigned.

Read-only and Write-only Properties

Read-only property: If you only want a property to be readable, you can omit the set accessor

--------------------------------------------------------
public string Name { get; }
--------------------------------------------------------

Write-only property: If you only want a property to be writable, you can omit the get accessor:

--------------------------------------------------------
public string Name { set; }
--------------------------------------------------------

Custom get and set

You can also customize the behavior of get and set if you need to add logic when getting or setting the property value:

--------------------------------------------------------
class Person
{
    private string _name;

    public string Name
    {
        get
        {
            return _name.ToUpper();  // Custom logic in getter
        }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                _name = value;  // Custom logic in setter
            }
        }
    }
}
--------------------------------------------------------

Conclusion

The get; set; syntax in C# defines an auto-implemented property that automatically handles the storage and retrieval of the property's value, simplifying code and eliminating the need to manually define backing fields.

*/