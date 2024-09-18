using System;

namespace ConsoleApp
{
    // Base class
    public class Animal
    {
        // Virtual method to be overridden
        public virtual void Speak()
        {
            Console.WriteLine("The animal makes a sound.");
        }
    }

    // Derived class with a sealed method
    public class Dog : Animal
    {
        // Overriding the base class method
        public sealed override void Speak()
        {
            Console.WriteLine("The dog barks.");
        }
    }

    // Another derived class that cannot override the sealed method
    public class Bulldog : Dog
    {
        // This will cause an error because Speak is sealed in Dog
        // public override void Speak() { } // Error: Cannot override sealed member 'Dog.Speak()'
    }

    // Sealed class - no further inheritance allowed
    public sealed class FinalDog : Bulldog
    {
        // Additional methods or properties
        public void Run()
        {
            Console.WriteLine("The dog runs fast.");
        }
    }

    // Test the program
    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            Dog myDog = new Dog();
            Bulldog myBulldog = new Bulldog();
            FinalDog myFinalDog = new FinalDog();

            myAnimal.Speak();      // Output: "The animal makes a sound."
            myDog.Speak();         // Output: "The dog barks."
            myBulldog.Speak();     // Output: "The dog barks." (inherited sealed method)
            myFinalDog.Run();      // Output: "The dog runs fast."
        }
    }

}