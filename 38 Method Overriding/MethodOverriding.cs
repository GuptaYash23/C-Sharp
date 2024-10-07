using System;

public class Animal
{
    // Virtual method in the base class
    public virtual void Speak()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}

public class Dog : Animal
{
    // Overriding the Speak method in the derived class
    public override void Speak()
    {
        Console.WriteLine("Dog barks.");
    }
}

public class Cat : Animal
{
    // Overriding the Speak method in the derived class
    public override void Speak()
    {
        Console.WriteLine("Cat meows.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();
        Animal myDog = new Dog();  // Polymorphism: a Dog treated as an Animal
        Animal myCat = new Cat();  // Polymorphism: a Cat treated as an Animal

        myAnimal.Speak();  // Calls Animal's Speak method
        myDog.Speak();     // Calls Dog's Speak method (overridden)
        myCat.Speak();     // Calls Cat's Speak method (overridden)
    }
}
