/* Interface Inheritance

In C#, interface inheritance allows one interface to inherit from another interface. This enables the creation of more complex interfaces by building on simpler ones, adding new members, and creating more specific contracts. Just like class inheritance, interface inheritance promotes code reusability and logical structuring, but there are some key differences since interfaces cannot contain any implementation (in pre-C# 8.0 versions).

Key Points of Interface Inheritance:

No Implementation: Interfaces can inherit other interfaces, but they only inherit the declarations, not any implementation (except for default implementations in C# 8.0+).

Multiple Inheritance: An interface can inherit from more than one interface. This is different from classes in C#, which can only inherit from one base class (single inheritance).

Implementing an Inherited Interface: When a class implements an interface that inherits from other interfaces, it must implement all the members declared in the entire inheritance chain.

Example of Interface Inheritance:

In this example, we'll create a simple inheritance chain where IVehicle is a base interface, and ICar inherits from IVehicle and adds its own members.

Code:

----------------------------------------------------------------------------------------------
using System;

namespace InterfaceInheritanceExample
{
    // Base interface IVehicle
    public interface IVehicle
    {
        void Start();
        void Stop();
    }

    // Interface ICar inherits from IVehicle
    public interface ICar : IVehicle
    {
        void OpenTrunk();
    }

    // Class implements ICar, which implicitly implements IVehicle too
    public class Sedan : ICar
    {
        public void Start()
        {
            Console.WriteLine("Sedan is starting.");
        }

        public void Stop()
        {
            Console.WriteLine("Sedan is stopping.");
        }

        public void OpenTrunk()
        {
            Console.WriteLine("Trunk is opening.");
        }
    }

    class Program
    {
        static void Main()
        {
            ICar myCar = new Sedan();
            myCar.Start();      // Output: Sedan is starting.
            myCar.OpenTrunk();  // Output: Trunk is opening.
            myCar.Stop();       // Output: Sedan is stopping.
        }
    }
}
----------------------------------------------------------------------------------------------

Explanation:

Base Interface (IVehicle):

This interface defines two methods: Start() and Stop(). Any class that implements IVehicle must provide implementations for these methods.

Derived Interface (ICar):

The ICar interface inherits from IVehicle and adds one more method: OpenTrunk(). Any class that implements ICar must provide implementations for Start(), Stop(), and OpenTrunk().

Class (Sedan):

The Sedan class implements the ICar interface. Since ICar inherits from IVehicle, Sedan must implement all three methods: Start(), Stop(), and OpenTrunk().

Main Program:

An instance of Sedan is created and assigned to a variable of type ICar. Since ICar includes the members from both IVehicle and ICar, we can call methods like Start(), Stop(), and OpenTrunk() on this object.

Multiple Interface Inheritance:

C# interfaces can inherit from more than one interface, which is a form of multiple inheritance. This is not possible with classes in C# (due to the "diamond problem" associated with multiple inheritance of implementation).

Example of Multiple Interface Inheritance:

----------------------------------------------------------------------------------------------
using System;

namespace MultipleInterfaceInheritanceExample
{
    // Interface IVehicle
    public interface IVehicle
    {
        void Start();
    }

    // Interface IMaintainable
    public interface IMaintainable
    {
        void Service();
    }

    // Interface ICar inherits from both IVehicle and IMaintainable
    public interface ICar : IVehicle, IMaintainable
    {
        void OpenTrunk();
    }

    // Sedan class implements ICar, hence it must implement all members from IVehicle and IMaintainable
    public class Sedan : ICar
    {
        public void Start()
        {
            Console.WriteLine("Sedan is starting.");
        }

        public void Service()
        {
            Console.WriteLine("Sedan is being serviced.");
        }

        public void OpenTrunk()
        {
            Console.WriteLine("Sedan's trunk is opening.");
        }
    }

    class Program
    {
        static void Main()
        {
            ICar myCar = new Sedan();
            myCar.Start();        // Output: Sedan is starting.
            myCar.Service();      // Output: Sedan is being serviced.
            myCar.OpenTrunk();    // Output: Sedan's trunk is opening.
        }
    }
}
----------------------------------------------------------------------------------------------

Explanation:

Multiple Inheritance of Interfaces:

ICar inherits from both IVehicle and IMaintainable.
Any class implementing ICar must implement all the methods from IVehicle, IMaintainable, and ICar.

Class Sedan:

The Sedan class implements all the methods from both inherited interfaces (Start(), Service(), and OpenTrunk()).

Key Points of Interface Inheritance:

Extending Interfaces: By inheriting from other interfaces, you can extend or refine existing interfaces to create more specific or complex contracts.

Multiple Interface Inheritance: A single interface can inherit from multiple interfaces, allowing you to combine functionality from different sources into a single contract.

Implementing Inherited Interfaces: A class that implements an interface that inherits from other interfaces must implement all the members of the entire inheritance chain.

Polymorphism: You can use interface inheritance to achieve polymorphism, where an object can be referenced by the interface type, allowing you to interact with the object through the common members of the interface.

Conclusion:

In C#, interface inheritance allows for the extension of interfaces and the combination of multiple interface contracts into one. This promotes reusability, modularity, and flexibility, especially when working with complex systems where different parts may need to adhere to multiple, common behaviors.

*/