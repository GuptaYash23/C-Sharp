/* Constructor Injection

Constructor Injection is a form of Dependency Injection (DI) in which dependencies are provided to a class through its constructor. This allows for decoupling between the dependent class and the classes it relies on, making the code more modular, testable, and maintainable.

In Constructor Injection, when an object is created, the required dependencies are passed as parameters to the constructor. This approach ensures that the dependencies are available from the moment the object is instantiated, and the class can function with all its required services injected.

-> Why use Constructor Injection?

Promotes Loose Coupling: The dependent class does not create its own dependencies but relies on abstractions (usually interfaces). 

This makes it easier to replace or mock dependencies.

Easier to Test: Since dependencies are injected from the outside, it's simple to pass mock objects or stubs in unit tests.

Clear Dependency Requirements: The constructor explicitly states the dependencies of a class, making it clear which services or objects the class relies on.

Example of Constructor Injection

---------------------------------------------------------------------------------------------------------------------
using System;

// Define an interface for the service (abstraction)
public interface IMessageService
{
    void SendMessage(string message);
}

// Concrete implementation of IMessageService
public class EmailService : IMessageService
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Email sent: {message}");
    }
}

// Another concrete implementation of IMessageService
public class SmsService : IMessageService
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"SMS sent: {message}");
    }
}

// Consumer class that uses IMessageService, but does not create it internally
public class Notification
{
    private readonly IMessageService _messageService;

    // Constructor Injection: IMessageService is passed through the constructor
    public Notification(IMessageService messageService)
    {
        _messageService = messageService;
    }

    // Method to notify using the injected IMessageService
    public void Notify(string message)
    {
        _messageService.SendMessage(message);
    }
}

class Program
{
    static void Main()
    {
        // Inject EmailService as the dependency via the constructor
        IMessageService emailService = new EmailService();
        Notification notificationWithEmail = new Notification(emailService);
        notificationWithEmail.Notify("Hello via Email!");

        // Inject SmsService as the dependency via the constructor
        IMessageService smsService = new SmsService();
        Notification notificationWithSms = new Notification(smsService);
        notificationWithSms.Notify("Hello via SMS!");
    }
}
---------------------------------------------------------------------------------------------------------------------

Explanation:

IMessageService Interface:

This interface defines a contract (SendMessage) that any messaging service must implement. It's an abstraction, promoting loose coupling.

EmailService and SmsService:

These are concrete implementations of IMessageService. Each provides its specific way of sending a message (email or SMS).

Notification Class:

This class depends on IMessageService but does not create an instance of EmailService or SmsService itself.

The dependency (IMessageService) is passed via the constructor and stored in a private readonly field.
The Notify method uses the injected service to send a message.

Main Method:

Here, EmailService and SmsService objects are created, and their references are injected into the Notification class constructor.

This demonstrates how the same Notification class can work with different implementations of IMessageService, promoting flexibility and loose coupling.

Output:

---------------------------------------------------------------------------------------------------------------------
Email sent: Hello via Email!
SMS sent: Hello via SMS!
---------------------------------------------------------------------------------------------------------------------

-> Benefits of Constructor Injection:

(i) Clear Dependencies: By looking at the constructor, it's easy to see what dependencies the class requires.

(ii) Immutable Dependencies: Since dependencies are provided when the object is created and stored in readonly fields, they cannot be changed during the object’s lifetime, ensuring consistency.

(iii) Testability: Constructor injection makes it easy to pass mock objects for testing. You can inject different test services during unit testing.

(iv) Encourages Single Responsibility Principle (SRP): Each class focuses on its responsibility, without managing the lifecycle of dependencies, adhering to SOLID principles.

-> Comparison with Other Injection Types:

1. Property Injection: Dependencies are set through properties, rather than constructors. This is less common because it can lead to dependencies being optional or mutable after object creation, which can cause issues like incomplete objects or bugs.

---------------------------------------------------------------------------------------------------------------------
public IMessageService MessageService { get; set; }
---------------------------------------------------------------------------------------------------------------------

2. Method Injection: Dependencies are passed as parameters to methods instead of constructors or properties. This is useful for temporary or one-off dependencies needed only during method execution.

---------------------------------------------------------------------------------------------------------------------
public void Notify(IMessageService messageService, string message)
{
    messageService.SendMessage(message);
}
---------------------------------------------------------------------------------------------------------------------

-> Constructor Injection in ASP.NET Core:

In ASP.NET Core, Constructor Injection is the default way to inject dependencies. ASP.NET Core has a built-in dependency injection container that can automatically resolve services registered in the container and inject them into controllers or services.

Here’s a basic example using ASP.NET Core:

1. Service Registration (in Startup.cs or Program.cs):

Code:

---------------------------------------------------------------------------------------------------------------------
public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        // Register the IMessageService with its implementation
        services.AddTransient<IMessageService, EmailService>();
    }
}
---------------------------------------------------------------------------------------------------------------------

2. Service Injection in Controller:

---------------------------------------------------------------------------------------------------------------------
public class HomeController : Controller
{
    private readonly IMessageService _messageService;

    // Constructor Injection: IMessageService is injected
    public HomeController(IMessageService messageService)
    {
        _messageService = messageService;
    }

    public IActionResult Index()
    {
        _messageService.SendMessage("Hello from HomeController!");
        return View();
    }
}
---------------------------------------------------------------------------------------------------------------------

In this example:

The IMessageService is registered with the DI container (services.AddTransient<IMessageService, EmailService>()), and ASP.NET Core automatically injects it into the HomeController's constructor.

ASP.NET Core handles the lifecycle and resolution of dependencies automatically.

-> Summary:

Constructor Injection is a widely used and recommended technique to inject dependencies into a class, ensuring the class doesn't create its dependencies but instead receives them.

It promotes loose coupling by relying on abstractions (e.g., interfaces) and improves testability because you can easily mock or replace dependencies in tests.

ASP.NET Core, along with many other frameworks, relies heavily on constructor injection as the primary method of managing dependencies.

Constructor Injection is one of the fundamental principles of building scalable, testable, and maintainable applications in modern C#.

*/