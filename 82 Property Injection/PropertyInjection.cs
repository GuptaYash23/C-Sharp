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
