/* Method Injection in C# 

Method Injection is a form of Dependency Injection (DI) where the dependencies are passed to an object through a method, rather than through the constructor (constructor injection) or via properties (property injection). In this approach, the dependency is passed as a parameter to a specific method that needs it.

Unlike constructor injection, where the dependencies are passed during the creation of an object, or property injection, where dependencies are set via properties, method injection injects dependencies only at the moment they are needed.


-> Why Use Method Injection?

- Fine-Grained Control: 

Method injection allows you to pass dependencies only to the methods that need them, rather than passing them at object creation or setting them as properties. This allows for better control over when and where dependencies are used.

- Encapsulates Behavior: It keeps the dependency close to where it is needed, making the purpose more explicit.

- Flexibility: You can inject different dependencies in different method calls.

However, method injection typically works best when the dependency is used only within a specific method, rather than across the entire class.

-> Example of Method Injection in C#

---------------------------------------------------------------------------------
using System;

// Step 1: Define an interface (Abstraction)
public interface IMessageService
{
    void SendMessage(string message);
}

// Step 2: Implement concrete classes that follow the interface
public class EmailService : IMessageService
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"EmailService: {message}");
    }
}

// Another concrete implementation of IMessageService
public class SmsService : IMessageService
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"SmsService: {message}");
    }
}

// Step 3: Define the dependent class (Notification) that uses method injection
public class Notification
{
    // No dependency is injected through the constructor or property

    // Step 4: Method Injection - The IMessageService is passed as an argument to the method
    public void Notify(string message, IMessageService messageService)
    {
        messageService.SendMessage(message);  // Use the injected service
    }
}

class Program
{
    static void Main()
    {
        // Step 5: Create instances of services
        IMessageService emailService = new EmailService();
        IMessageService smsService = new SmsService();

        // Create instance of Notification
        Notification notification = new Notification();

        // Inject EmailService using Method Injection
        notification.Notify("Notification via Email!", emailService); // Output: EmailService: Notification via Email!

        // Inject SmsService using Method Injection
        notification.Notify("Notification via SMS!", smsService); // Output: SmsService: Notification via SMS!
    }
}
---------------------------------------------------------------------------------

-> Explanation of the Example:

Interface (IMessageService):

This defines the contract that both EmailService and SmsService implement. The Notification class will receive an implementation of this interface at runtime, via method injection.

Concrete Classes (EmailService and SmsService):

These classes implement the IMessageService interface, providing specific implementations for sending messages via email or SMS.

Method Injection in Notification:

The Notify method accepts an IMessageService dependency as a parameter. This means that the dependency is injected when the method is called, and only that method will use it.

Reason: The dependency is passed at the time it is needed, making it clear that this method relies on IMessageService to perform its operation. There is no need for the Notification class to store the dependency for future use.

Main Method:

In the Main method, instances of EmailService and SmsService are created.
The Notify method of the Notification class is then called twice, with different dependencies injected each time (email and SMS).
This demonstrates how you can easily switch services without affecting the rest of the class.

Output:

---------------------------------------------------------------------------------
EmailService: Notification via Email!
SmsService: Notification via SMS!
---------------------------------------------------------------------------------

-> Key Points About Method Injection:

- Fine-Grained Control:

Method injection provides the flexibility to inject dependencies only when and where they are needed. In the example, the Notify method only receives its dependency (IMessageService) when it is called, not when the object is instantiated.

- No State Retention:

Unlike constructor and property injection, method injection does not require the class to retain the injected dependency as a field or property. The dependency is used immediately and not stored.

- Testability:

Method injection makes testing very straightforward, as you can easily pass in mock implementations of dependencies during test method calls. You don't need to worry about setting up dependencies at object construction.

- Looser Coupling:

Since the dependency is injected at the method level, there is even less coupling between the dependent class (Notification) and the implementation of the service (EmailService, SmsService), making the system more modular.

- Flexibility:

Different services can be injected into the same method at different times. This makes it easy to switch between different implementations of the service within a single object’s lifecycle.
When to Use Method 

- Injection:

Single Method Dependency: When a dependency is only needed by one specific method in the class, and there is no need to keep the dependency around.
Multiple Different 

- Dependencies:

When different methods require different types of services, or if the same method needs to work with different service implementations.

- Non-essential Dependencies:

When the dependency is not essential to the object's construction or state, and you want to inject it dynamically during method calls.

- When to Avoid Method Injection:

Stateful Services: If the service needs to maintain a state across multiple method calls, then method injection is not ideal, as the dependency is not stored within the object.

- Mandatory Dependencies: 

If the class cannot function without certain dependencies, constructor injection is preferred to ensure that all required dependencies are injected at the time of object creation.

-> Summary of Dependency Injection Techniques:

- Constructor Injection:

Dependencies are passed via the constructor.
Use when dependencies are mandatory and must be available throughout the object's lifecycle.

- Property Injection:

Dependencies are passed via public properties.
Use when dependencies are optional or can be changed after object construction.

- Method Injection:

Dependencies are passed as method parameters.
Use when dependencies are needed only within specific methods and not throughout the object's lifecycle.

-> Conclusion:

Method Injection is a flexible form of dependency injection that allows you to inject dependencies only where and when they are needed. It is especially useful when you need fine-grained control over your dependencies, but it’s not suitable for stateful dependencies or when the class requires the dependency across multiple methods. Method injection ensures that classes remain loosely coupled and easier to maintain and test, especially when the dependency is needed in isolated contexts.

*/