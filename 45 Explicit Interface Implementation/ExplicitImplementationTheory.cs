/* Explicit implementation of Interface

Refer - https://www.youtube.com/watch?v=164pwAw3e_o&list=PLX07l0qxoHFLZftsVKyj3k9kfMca2uaPR&index=56

Explicit interface implementation in C# is a technique used when a class implements multiple interfaces that have members with the same signature or when you want to restrict the visibility of an interface member to only be accessible through the interface and not through the class object.

In explicit implementation, the interface methods or properties are implemented in such a way that they can only be accessed via the interface reference, and not through the class instance directly.

Key Points:

When it's useful:

When you need to implement multiple interfaces that have methods or properties with the same name.

To hide the implementation of an interface method from the public class interface so that it can only be accessed through an interface reference.

Syntax: When implementing an interface explicitly, you need to prefix the method with the interface name:

---------------------------------------------------------------------------
return_type InterfaceName.MethodName(parameters)
{
    // Implementation
}
---------------------------------------------------------------------------

Example Scenario:

Let’s say we have two interfaces, IPrinter and IScanner, both of which have a method called Start(). If a class implements both interfaces, we can use explicit interface implementation to avoid name conflicts and make the interface methods accessible only through the interface.

Code Example:

---------------------------------------------------------------------------
using System;

interface IPrinter
{
    void Start();  // Printer Start
}

interface IScanner
{
    void Start();  // Scanner Start
}

class MultiFunctionDevice : IPrinter, IScanner
{
    // Explicit implementation of IPrinter's Start method
    void IPrinter.Start()
    {
        Console.WriteLine("Starting the Printer...");
    }

    // Explicit implementation of IScanner's Start method
    void IScanner.Start()
    {
        Console.WriteLine("Starting the Scanner...");
    }
}

class Program
{
    static void Main()
    {
        MultiFunctionDevice mfd = new MultiFunctionDevice();

        // mfd.Start(); // Error: Cannot access explicit implementation directly via class reference

        // Access IPrinter's Start method via IPrinter reference
        IPrinter printer = mfd;
        printer.Start();  // Output: Starting the Printer...

        // Access IScanner's Start method via IScanner reference
        IScanner scanner = mfd;
        scanner.Start();  // Output: Starting the Scanner...
    }
}
---------------------------------------------------------------------------

Explanation:

Two Interfaces (IPrinter and IScanner):

Both interfaces declare a method called Start().\

Class MultiFunctionDevice:

Implements both IPrinter and IScanner interfaces.

Uses explicit interface implementation for both Start() methods by prefixing each method with the corresponding interface name (IPrinter.Start() and IScanner.Start()).

Accessing the Methods:

The Start() methods cannot be called directly on the MultiFunctionDevice class instance (mfd.Start() will result in a compilation error).

To call the methods, we need to first cast the class instance (mfd) to the appropriate interface (IPrinter or IScanner), and then call the method.

When cast as IPrinter, Start() from IPrinter is invoked.

When cast as IScanner, Start() from IScanner is invoked.

Why Use Explicit Implementation?

Avoid Naming Conflicts:

When implementing multiple interfaces with members that have the same signature (same method name and parameters), explicit implementation avoids ambiguity. It ensures that each interface's method is kept distinct and can only be accessed via its respective interface.

Restrict Access:

Explicit implementation makes interface methods accessible only through the interface reference, not through the class directly. This is useful when you want to hide certain functionality from the class's public interface but still satisfy interface contracts.

Example of Restricting Access:

---------------------------------------------------------------------------
interface IVehicle
{
    void Drive();
}

class Car : IVehicle
{
    // Explicitly implement the Drive method
    void IVehicle.Drive()
    {
        Console.WriteLine("Driving the car...");
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car();
        
        // myCar.Drive(); // Error: Cannot access explicit implementation directly via class reference
        
        IVehicle vehicle = myCar;
        vehicle.Drive();  // Output: Driving the car...
    }
}
---------------------------------------------------------------------------

In this example:

The Car class implements IVehicle explicitly, so the Drive() method can only be called via an IVehicle reference, not directly on the Car instance.

Key Takeaways:

Explicit implementation is used when a class implements multiple interfaces that contain members with the same signature or when you want to control the visibility of interface members.

It allows you to differentiate between methods of different interfaces with the same name.

You can only call explicitly implemented members through the interface reference, not directly on the class instance.

*/