/* Constructors

In C#, a constructor is a special method that is automatically called when an instance of a class or struct is created. It is used to initialize objects, set default values, or execute code that must run at the start of an object's lifecycle. Constructors have the same name as the class and do not have a return type (not even void).

Types of Constructors in C#

1. Default Constructor:

If no constructor is defined in a class, the C# compiler automatically provides a default constructor.

The default constructor initializes the class fields to their default values (e.g., null for objects, 0 for integers).

----------------------------------------------------------------------------------------------
class Example
{
    // Default constructor will be provided by the compiler
}
----------------------------------------------------------------------------------------------

2. Parameterized Constructor:

A constructor that accepts parameters, allowing the user to pass values during object creation to initialize object properties or fields.

----------------------------------------------------------------------------------------------
class Person
{
    public string Name;
    public int Age;

    // Parameterized constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

// Usage
Person person = new Person("Alice", 30);
----------------------------------------------------------------------------------------------

3. Static Constructor:

Used to initialize static members of the class. It is called once, only when the class is first accessed.

It does not take parameters and is declared using the static keyword.

----------------------------------------------------------------------------------------------
class Logger
{
    public static string DefaultLogPath;

    // Static constructor
    static Logger()
    {
        DefaultLogPath = "logs/default.log";
    }
}

// Usage
string logPath = Logger.DefaultLogPath;
----------------------------------------------------------------------------------------------

4. Copy Constructor (Manual):

This is a user-defined constructor that creates a new object by copying the values of another object of the same type.

----------------------------------------------------------------------------------------------
class Rectangle
{
    public int Width, Height;

    // Parameterized constructor
    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    // Copy constructor
    public Rectangle(Rectangle other)
    {
        Width = other.Width;
        Height = other.Height;
    }
}

// Usage
Rectangle rect1 = new Rectangle(10, 20);
Rectangle rect2 = new Rectangle(rect1); // Copy constructor
----------------------------------------------------------------------------------------------

5. Private Constructor:

A constructor declared as private restricts the creation of instances of a class from outside the class. It is often used in singleton patterns.

----------------------------------------------------------------------------------------------
class Singleton
{
    private static Singleton instance;

    // Private constructor
    private Singleton() {}

    public static Singleton GetInstance()
    {
        if (instance == null)
        {
            instance = new Singleton();
        }
        return instance;
    }
}

// Usage
Singleton single = Singleton.GetInstance();
----------------------------------------------------------------------------------------------

Key Points:

Constructor Overloading: Multiple constructors can be defined with different sets of parameters, allowing flexibility in object creation.

Chaining Constructors: One constructor can call another constructor of the same class using the this keyword, which helps in avoiding code duplication.

----------------------------------------------------------------------------------------------
class Employee
{
    public string Name;
    public int Id;

    // Constructor with one parameter
    public Employee(string name) : this(name, 0) {}

    // Constructor with two parameters
    public Employee(string name, int id)
    {
        Name = name;
        Id = id;
    }
}
----------------------------------------------------------------------------------------------

Destructors: In C#, there is also a destructor (which looks like a constructor prefixed with a tilde ~). It is used to clean up resources before an object is destroyed, though it is rarely needed because of automatic memory management via garbage collection.

*/

/* Constructors in Inheritance

In C# inheritance, constructors play a crucial role in ensuring that the base class (parent class) and the derived class (child class) are properly initialized. When a derived class object is created, the constructors for both the derived and base classes are called, starting with the base class constructor.

Key Points about Constructors in Inheritance:

Base Class Constructor Call:

When a derived class constructor is called, the base class constructor is invoked first. This ensures that the base class part of the object is initialized before the derived class can add its own initializations.

Constructor Chaining:

You can explicitly call a base class constructor from a derived class constructor using the base keyword. If no base call is specified, the default constructor of the base class is called automatically.

Inheritance of Constructors:

Constructors are not inherited. A derived class does not inherit the constructor of its base class, but it can call it.

Order of Constructor Execution:

Base class constructors are always executed first, followed by derived class constructors, regardless of whether the base class constructor is explicitly called or implicitly invoked.

Example: Constructors in Inheritance

----------------------------------------------------------------------------------------------
using System;

class Animal
{
    public string Name;

    // Base class constructor
    public Animal()
    {
        Console.WriteLine("Base class (Animal) default constructor called.");
    }

    // Base class parameterized constructor
    public Animal(string name)
    {
        Name = name;
        Console.WriteLine($"Base class (Animal) parameterized constructor called. Name: {Name}");
    }
}

class Dog : Animal
{
    public string Breed;

    // Derived class constructor
    public Dog() : base() // Explicitly calling the base class default constructor
    {
        Breed = "Unknown";
        Console.WriteLine("Derived class (Dog) default constructor called.");
    }

    // Derived class parameterized constructor
    public Dog(string name, string breed) : base(name) // Calling base class parameterized constructor
    {
        Breed = breed;
        Console.WriteLine($"Derived class (Dog) parameterized constructor called. Breed: {Breed}");
    }
}

class Program
{
    static void Main()
    {
        // Create object using derived class default constructor
        Dog dog1 = new Dog();
        Console.WriteLine();

        // Create object using derived class parameterized constructor
        Dog dog2 = new Dog("Max", "Golden Retriever");
    }
}
----------------------------------------------------------------------------------------------

Explanation:

Base Class (Animal):

The Animal class has a default constructor and a parameterized constructor.

Derived Class (Dog):

The Dog class inherits from Animal and has its own default constructor and parameterized constructor.

The derived class constructors use the base() keyword to explicitly call the base class constructors.

Constructor Chaining:

In the default constructor of Dog, the base() keyword explicitly calls the base class (Animal) default constructor.

In the parameterized constructor of Dog, base(name) calls the parameterized constructor of the Animal class, passing the name value.

Output:

----------------------------------------------------------------------------------------------
Base class (Animal) default constructor called.
Derived class (Dog) default constructor called.

Base class (Animal) parameterized constructor called. Name: Max
Derived class (Dog) parameterized constructor called. Breed: Golden Retriever
----------------------------------------------------------------------------------------------

Key Takeaways:

Base Constructor Execution: The base class constructor is always executed before the derived class constructor, ensuring that the base part of the object is fully initialized before adding the derived class-specific behavior.

Constructor Chaining with base: You can use base() in the derived class constructor to explicitly call a specific constructor of the base class, either the default or a parameterized one. If you don’t use base(), the compiler automatically calls the default constructor of the base class.

Order of Initialization: In the example, the Animal constructor (base class) is executed before the Dog constructor (derived class), showing the proper order of initialization in inheritance.

This ensures that the entire object, including both its base and derived parts, is correctly initialized.

*/