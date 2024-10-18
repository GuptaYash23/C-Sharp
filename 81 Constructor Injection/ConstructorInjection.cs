using System;

// Step 1: Define an interface (Abstraction)
public interface IMessageService
{
    void SendMessage(string message);
}

// Step 2: Implement concrete classes that follow the interface
// This class is a concrete implementation of IMessageService
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

// Step 3: Define the dependent class (Notification) that uses IMessageService
// This class doesn't create its own IMessageService; it receives it via constructor
public class Notification
{
    private readonly IMessageService _messageService;

    // Constructor Injection: IMessageService is passed through the constructor
    public Notification(IMessageService messageService)
    {
        _messageService = messageService; // Store the injected dependency in a private field
    }

    // Notify method uses the injected IMessageService to send a message
    public void Notify(string message)
    {
        _messageService.SendMessage(message); // Use the injected service
    }
}

class Program
{
    static void Main()
    {
        // Step 4: Inject EmailService as a dependency
        // This allows Notification to use EmailService without creating it inside the class
        IMessageService emailService = new EmailService();
        Notification notificationWithEmail = new Notification(emailService);
        notificationWithEmail.Notify("Notification via Email!");  // Output: EmailService: Notification via Email!

        // Step 5: Inject SmsService as a dependency
        // We can easily switch to a different service without modifying the Notification class
        IMessageService smsService = new SmsService();
        Notification notificationWithSms = new Notification(smsService);
        notificationWithSms.Notify("Notification via SMS!");  // Output: SmsService: Notification via SMS!
    }
}


/* Code Breakdown and Reasons:

Interface (IMessageService):

This defines a contract that both 
EmailService and SmsService implement.
 
The class Notification depends on this abstraction, not the concrete services themselves.

Reason: This promotes loose coupling because the Notification class doesn't care how the message is sent. It just knows that any IMessageService implementation can send the message.
Concrete Implementations 

(EmailService, SmsService):

These classes implement the IMessageService interface. They provide specific implementations for sending messages (email or SMS).

Reason: You can have multiple implementations, and you can easily swap them without changing the dependent Notification class.

Constructor Injection in Notification:

The Notification class accepts an IMessageService dependency through its constructor. It doesn't instantiate its own EmailService or SmsService.

Reason: This makes the Notification class flexible and allows it to use any service that implements IMessageService. It's more modular and testable because we can easily pass mock services or different implementations.

Main Method:

The Main method creates instances of EmailService and SmsService and injects them into the Notification class.

Reason: The Notification class can now work with either service without modification, demonstrating loose coupling. If a new type of service (e.g., PushNotificationService) is added, it can be injected in the same way.

Key Points of Constructor Injection:

Loose Coupling: The Notification class is not tightly coupled to any specific implementation of IMessageService. It can work with EmailService, SmsService, or any future implementation that follows the IMessageService contract.

Testability: In unit tests, you can inject mock implementations of IMessageService without modifying the Notification class.

Flexibility: Switching between different implementations is easy. For instance, if you want to switch from email notifications to SMS notifications, you just need to inject the appropriate service.

Conclusion:

Constructor Injection ensures that dependencies are provided when the object is instantiated. This makes the code more maintainable, testable, and promotes the principle of Dependency Inversion by programming to interfaces rather than concrete classes.

*/