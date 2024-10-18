/* Property Injection

Property Injection is a form of Dependency Injection (DI) in which dependencies are provided through a class's public property rather than through its constructor. In this method, an external component (such as an IoC container or manually set code) sets the dependencies after the object is created.

Unlike Constructor Injection, where the dependencies are mandatory and provided at the time of object creation, property injection makes the dependencies optional. This provides flexibility but may also introduce risks if the required dependencies are not set before the object is used.

-> Why Use Property Injection?

Flexibility: You can change or inject dependencies after the object has been constructed, which can be useful in certain scenarios where the dependencies might not be known at the time of instantiation.

Optional Dependencies: Property injection allows for optional dependencies, making the class more flexible in certain use cases where not all services are needed.

Less Strict Than Constructor Injection: It allows for more flexible object initialization, unlike constructor injection which mandates that all dependencies are provided upfront.

However, property injection also has drawbacks:

Risk of Uninitialized Dependencies: If the dependency is not set before the object is used, it could lead to runtime exceptions or unexpected behavior.

Less Explicit: It’s harder to determine from the constructor what dependencies are required, which can lead to less readable and maintainable code.

Example of Property Injection

---------------------------------------------------------------------------------------------------------------------
using System;

// Step 1: Define an interface for the service
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

// Step 3: Define the dependent class (Notification) that uses property injection
public class Notification
{
    // Property Injection: IMessageService dependency is set via this property
    public IMessageService MessageService { get; set; }

    // Notify method uses the injected IMessageService to send a message
    public void Notify(string message)
    {
        if (MessageService != null)
        {
            MessageService.SendMessage(message); // Use the injected service
        }
        else
        {
            Console.WriteLine("MessageService is not set.");
        }
    }
}

class Program
{
    static void Main()
    {
        // Step 4: Create a Notification object without passing any dependency in the constructor
        Notification notification = new Notification();

        // Inject EmailService as the dependency via the property
        notification.MessageService = new EmailService();
        notification.Notify("Notification via Email!");  // Output: EmailService: Notification via Email!

        // Inject SmsService as the dependency via the property
        notification.MessageService = new SmsService();
        notification.Notify("Notification via SMS!");  // Output: SmsService: Notification via SMS!

        // Not setting the MessageService property
        Notification notificationWithoutService = new Notification();
        notificationWithoutService.Notify("No service available."); // Output: MessageService is not set.
    }
}
---------------------------------------------------------------------------------------------------------------------

-> Explanation of the Example:

1. Interface (IMessageService):

This interface defines the contract that both EmailService and SmsService must implement. It promotes loose coupling by ensuring the dependent class (Notification) is unaware of the concrete service types.

2. Concrete Classes (EmailService and SmsService):

These classes implement the IMessageService interface, providing specific implementations for sending messages via email or SMS.

3. Property Injection in Notification:

The Notification class uses property injection to receive its dependency (MessageService).

The MessageService property is publicly settable, meaning it can be injected or changed after the object is created.

The Notify method checks whether the MessageService has been set and uses it to send a message. If MessageService is null (i.e., not injected), it outputs a message saying "MessageService is not set."

4. Main Method:

The Notification object is created without passing any dependencies in the constructor.

The MessageService is set via the public property, demonstrating property injection by setting different implementations (EmailService and SmsService).

One case shows that if the dependency is not set, the method can handle it gracefully.

Output:

---------------------------------------------------------------------------------------------------------------------
EmailService: Notification via Email!
SmsService: Notification via SMS!
MessageService is not set.
---------------------------------------------------------------------------------------------------------------------

-> Key Points About Property Injection:

1. Optional Dependencies: In this example, the MessageService can be set (injected) after the Notification object has been created. It is not required to be set when the object is instantiated.

2. Flexibility: You can change the service at any point in the object's lifecycle. For instance, you can start by sending messages via email and later switch to SMS by setting a new dependency.

3. Risk of Null Dependency: The Notify method checks whether the MessageService property is set. If not, it handles the case where no service is available (i.e., the property is null). Without this check, there could be a null reference exception.

4. Less Explicit: With property injection, it’s not immediately clear what dependencies the class needs by looking at the constructor. You have to inspect the properties, which can make the code less explicit compared to constructor injection.

-> When to Use Property Injection:

- Optional Dependencies: When some dependencies are optional and the object should be able to function without them.

- Legacy Systems: Property injection might be useful in scenarios where the object’s dependencies can’t be known at the time of instantiation or must be changed dynamically.

- Multiple Dependency Configurations: If you need the flexibility to switch out services or resources at runtime.

-> When to Avoid Property Injection:

- Dependencies: If the dependency is required for the object to function, constructor injection is a better option. Property injection is not ideal if the class cannot function without the dependency.

- Testability: It’s harder to guarantee the injection of dependencies at the correct time with property injection. Constructor injection is better for ensuring that the object is fully constructed with all its dependencies.

-> Conclusion:

Property Injection is a useful form of dependency injection that provides flexibility, allowing dependencies to be set or changed after an object is created. However, it can introduce risks, such as null dependencies, and should be used when optional dependencies are needed or when flexibility is a priority. For required dependencies, constructor injection is often the better and more explicit choice.

*/