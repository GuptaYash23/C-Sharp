/* Classes and Objects

Classes and Objects in C#

In C#, a class is a blueprint or template that defines the structure and behavior (properties and methods) of objects. An object is an instance of a class that holds specific values for the class's properties and can perform actions using the class's methods.

1. Classes

A class in C# defines:

Fields: Variables to store data.

Properties: Methods that provide a flexible mechanism to read, write, or compute the values of private fields.

Methods: Functions that define the behaviors or actions of the class.

Constructors: Special methods to initialize new objects.

Events and Delegates: Used for signaling state changes and implementing event-driven programming.

Syntax of Class:

--------------------------------------------------------------------------------------------
class Car
{
    // Fields (variables)
    private string model;
    private int year;

    // Property to access private field 'model'
    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    // Property to access private field 'year'
    public int Year
    {
        get { return year; }
        set { year = value; }
    }

    // Constructor
    public Car(string model, int year)
    {
        this.model = model;
        this.year = year;
    }

    // Method
    public void Drive()
    {
        Console.WriteLine($"{model} is driving.");
    }
}
--------------------------------------------------------------------------------------------

2. Objects

An object is an instance of a class. When you create an object, memory is allocated, and the fields and methods defined in the class are made accessible. Each object can have its own unique values for the properties defined in the class.

Creating an object:

--------------------------------------------------------------------------------------------
class Program
{
    static void Main()
    {
        // Creating an object of the Car class
        Car myCar = new Car("Tesla", 2023);

        // Accessing properties and methods of the object
        Console.WriteLine($"Car Model: {myCar.Model}");
        Console.WriteLine($"Car Year: {myCar.Year}");
        
        myCar.Drive();  // Calling a method on the object
    }
}
--------------------------------------------------------------------------------------------

Key Concepts:

Class:

A class defines the structure and behavior that its objects will have.
It is like a template for creating objects.

Object:

An object is an instance of a class.
Objects can store data (in fields/properties) and perform operations (through methods).
Example: In the code above, myCar is an object of the class Car.

Instantiation:

To create an object, you use the new keyword, which calls a constructor to initialize the object.

Example: Car myCar = new Car("Tesla", 2023); creates an instance of the Car class.

Fields and Properties:

Fields are variables declared in a class to store data.

Properties are accessors for fields, allowing controlled access to private fields via get and set methods.

Example: The Model and Year properties provide access to the model and year fields in the Car class.

Methods:

Methods define behaviors or actions that objects of the class can perform.

Example: The Drive method allows the Car object to perform the action of driving.

Real-World Example:

Think of a class as a blueprint for a house. The blueprint outlines the structure, layout, and design of a house, but it's not a physical house itself. An object is like an actual house built using that blueprint. While many houses can be built from the same blueprint, each house can have its own specific details (color, interior design, etc.).

Example with Multiple Objects:

--------------------------------------------------------------------------------------------
class Program
{
    static void Main()
    {
        // Creating objects of the Car class
        Car car1 = new Car("Toyota", 2020);
        Car car2 = new Car("Ford", 2018);

        // Accessing properties
        Console.WriteLine($"Car1 Model: {car1.Model}, Year: {car1.Year}");
        Console.WriteLine($"Car2 Model: {car2.Model}, Year: {car2.Year}");

        // Calling methods
        car1.Drive();
        car2.Drive();
    }
}
--------------------------------------------------------------------------------------------

Output:

--------------------------------------------------------------------------------------------
Car1 Model: Toyota, Year: 2020
Car2 Model: Ford, Year: 2018
Toyota is driving.
Ford is driving.
--------------------------------------------------------------------------------------------

Key Points:

Classes are used to define the structure and behavior of objects.

Objects are instances of classes, and they represent real-world entities with state (fields/properties) and behavior (methods).
You can create multiple objects from a class, and each object can have its own unique data, but all objects will share the same structure defined by the class.

In C#, object-oriented programming revolves around defining and manipulating objects based on classes, making it easier to model real-world systems and improve code modularity and reusability.
*/