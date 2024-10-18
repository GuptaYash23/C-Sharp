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
