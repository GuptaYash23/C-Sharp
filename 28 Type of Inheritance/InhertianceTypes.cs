using System;

// Single Inheritance: Animal -> Mammal
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

// Multilevel Inheritance: Animal -> Mammal -> Dog
class Mammal : Animal  // Mammal inherits from Animal
{
    public void Breathe()
    {
        Console.WriteLine("Mammal is breathing.");
    }
}

// Hierarchical Inheritance: Dog and Cat both inherit from Mammal
class Dog : Mammal  // Dog inherits from Mammal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}

class Cat : Mammal  // Cat also inherits from Mammal
{
    public void Meow()
    {
        Console.WriteLine("Cat is meowing.");
    }
}

// Multiple Inheritance (via Interfaces)
interface IWalker
{
    void Walk();
}

interface IRunnable
{
    void Run();
}

// Hybrid Inheritance: Dog inherits from Mammal (class) and implements multiple interfaces
class WorkingDog : Dog, IWalker, IRunnable  // WorkingDog inherits from Dog and implements IWalker and IRunnable
{
    public void Walk()
    {
        Console.WriteLine("WorkingDog is walking.");
    }

    public void Run()
    {
        Console.WriteLine("WorkingDog is running.");
    }
}

class Program
{
    static void Main()
    {
        // Demonstrating Single Inheritance
        Animal animal = new Animal();
        animal.Eat();
        Console.WriteLine();

        // Demonstrating Multilevel Inheritance
        Dog dog = new Dog();
        dog.Eat();       // Inherited from Animal
        dog.Breathe();   // Inherited from Mammal
        dog.Bark();      // Defined in Dog
        Console.WriteLine();

        // Demonstrating Hierarchical Inheritance
        Cat cat = new Cat();
        cat.Eat();       // Inherited from Animal
        cat.Breathe();   // Inherited from Mammal
        cat.Meow();      // Defined in Cat
        Console.WriteLine();

        // Demonstrating Multiple Inheritance via Interfaces and Hybrid Inheritance
        WorkingDog workingDog = new WorkingDog();
        workingDog.Eat();      // Inherited from Animal
        workingDog.Breathe();  // Inherited from Mammal
        workingDog.Bark();     // Inherited from Dog
        workingDog.Walk();     // From IWalker
        workingDog.Run();      // From IRunnable
    }
}
