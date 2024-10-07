using System;

class Person
{
    // Fields
    public string Name;
    public int Age;
    
    // Static field
    public static int Population;

    // Default Constructor
    public Person()
    {
        Name = "Unknown";
        Age = 0;
        Population++; // Increment the population count
        Console.WriteLine("Default constructor called.");
    }

    // Parameterized Constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
        Population++; // Increment the population count
        Console.WriteLine("Parameterized constructor called.");
    }

    // Copy Constructor
    public Person(Person other)
    {
        Name = other.Name;
        Age = other.Age;
        Population++; // Increment the population count
        Console.WriteLine("Copy constructor called.");
    }

    // Constructor Chaining
    public Person(string name) : this(name, 0)
    {
        Console.WriteLine("Constructor chaining with one parameter.");
    }

    // Static Constructor
    static Person()
    {
        Population = 0; // Initialize the static field
        Console.WriteLine("Static constructor called.");
    }

    // Private Constructor (for Singleton pattern demonstration)
    private Person(bool isPrivate)
    {
        Name = "Private Person";
        Age = 99;
        Population++; // Increment the population count
        Console.WriteLine("Private constructor called.");
    }

    // Singleton pattern example
    private static Person privateInstance;
    public static Person GetPrivateInstance()
    {
        if (privateInstance == null)
        {
            privateInstance = new Person(true);
        }
        return privateInstance;
    }

    // Destructor (just for demonstration; rarely needed due to garbage collection)
    ~Person()
    {
        Console.WriteLine("Destructor called.");
    }

    // Method to display the person details
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Population: {Population}");
    }
}

class Program
{
    static void Main()
    {
        // Call static constructor (automatically called when the class is accessed)
        Console.WriteLine($"Initial Population: {Person.Population}");       // Static constructor called Initial Population: 0

        // Default constructor
        Person person1 = new Person();
        person1.DisplayInfo();  // Default constructor called.Name: Unknown, Age: 0, Population: 1

        // Parameterized constructor
        Person person2 = new Person("Alice", 30);
        person2.DisplayInfo();   // Parameterized constructor called. Name: Alice, Age: 30, Population: 2

        // Copy constructor
        Person person3 = new Person(person2);
        person3.DisplayInfo();   // Copy constructor called. Name: Alice, Age: 30, Population: 3

        // Constructor chaining
        Person person4 = new Person("Bob");
        person4.DisplayInfo();   // Parameterized constructor called. Name: Bob, Age: 0, Population: 4

        // Singleton pattern with private constructor
        Person singlePerson = Person.GetPrivateInstance();
        singlePerson.DisplayInfo();  // Private constructor called. Name: Private Person, Age: 99, Population: 5

        // Show the final population count
        Console.WriteLine($"Final Population: {Person.Population}");   // Final Population: 5
    }
}
