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
