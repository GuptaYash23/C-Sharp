/* Dependency Injection in C# 

-> Tight Coupling vs Loose Coupling in C#

Coupling refers to the degree of dependency between two classes, objects, or modules. It determines how connected or dependent they are on each other. The terms tight coupling and loose coupling are used to describe how closely these components are interconnected.

1) Tight Coupling

Tight coupling occurs when a class is highly dependent on the internal details of another class. If one class changes, the dependent class might also need to be modified. This makes the code rigid, hard to test, and difficult to maintain or extend.

-> Key Characteristics of Tight Coupling:

(i) Classes have direct knowledge of each other’s implementations.

(ii) One class directly instantiates another class, making it difficult to replace or modify the dependent class without affecting other parts of the system.

(iii) Any change in the class being used often requires changes in the dependent class.

-> Example of Tight Coupling:

In this example, Notification is tightly coupled with EmailService, meaning if we wanted to switch to SmsService, we'd have to modify the Notification class.

Code:

---------------------------------------------------------------------------------------------------------------------
public class EmailService
{
    public void SendEmail(string message)
    {
        Console.WriteLine($"Email sent: {message}");
    }
}

public class Notification
{
    private EmailService _emailService = new EmailService(); // Tight coupling

    public void Notify(string message)
    {
        _emailService.SendEmail(message);
    }
}

class Program
{
    static void Main()
    {
        Notification notification = new Notification();
        notification.Notify("Hello!");
    }
}
---------------------------------------------------------------------------------------------------------------------

-> Issues with Tight Coupling:

(i) Low Flexibility: You cannot easily swap or replace EmailService with another service (e.g., SmsService) without modifying the Notification class.

(ii) Difficult Testing: It's harder to mock or replace dependencies during unit testing since Notification directly creates its dependencies.

(iii) Hard to Maintain: Any change in the EmailService class might break the Notification class, requiring changes across multiple areas of the code.

2) Loose Coupling

Loose coupling refers to reducing the dependencies between classes or components. A class does not need to know the details of another class’s implementation; it only needs to interact with it through an abstraction, such as an interface.

-> Key Characteristics of Loose Coupling:

(i) Classes communicate via interfaces or abstractions, not concrete implementations.

(ii) Dependencies are passed from the outside, typically through constructor or method parameters (using Dependency Injection).

(iii) Changes to one class have minimal impact on other classes that depend on it.

Loose coupling promotes flexibility, testability, and easier maintenance.

E-> xample of Loose Coupling:

In this example, Notification depends on the IMessageService interface instead of a concrete class, making it loosely coupled. We can now switch to any other service (like SmsService) without modifying the Notification class.

Code:

---------------------------------------------------------------------------------------------------------------------
// Interface that abstracts the service
public interface IMessageService
{
    void SendMessage(string message);
}

// Concrete EmailService class implementing the interface
public class EmailService : IMessageService
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Email sent: {message}");
    }
}

// Concrete SmsService class implementing the interface
public class SmsService : IMessageService
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"SMS sent: {message}");
    }
}

// Notification class is now loosely coupled with IMessageService
public class Notification
{
    private readonly IMessageService _messageService;

    // Constructor Injection: Dependency is passed from outside
    public Notification(IMessageService messageService)
    {
        _messageService = messageService;
    }

    public void Notify(string message)
    {
        _messageService.SendMessage(message);
    }
}

class Program
{
    static void Main()
    {
        // Loosely coupled: Can easily switch to a different service
        IMessageService emailService = new EmailService();
        Notification notificationWithEmail = new Notification(emailService);
        notificationWithEmail.Notify("Hello via Email!");

        IMessageService smsService = new SmsService();
        Notification notificationWithSms = new Notification(smsService);
        notificationWithSms.Notify("Hello via SMS!");
    }
}
---------------------------------------------------------------------------------------------------------------------

-> Benefits of Loose Coupling:

Flexibility: Easily swap out or modify dependencies without affecting other parts of the system.

Testability: Since dependencies are injected from the outside (using constructor or method parameters), it's easy to mock dependencies during unit testing.

Maintainability: Changes to a class have minimal impact on the rest of the system. The system is easier to extend without breaking existing functionality.

Reusability: Classes can be reused in different contexts because they rely on abstractions, not specific implementations.

-> When to Use:

Tight Coupling: May be acceptable for small, simple systems where dependencies are unlikely to change.

Loose Coupling: Preferable for larger, more complex systems where flexibility, testability, and maintainability are important. It is a best practice in enterprise-level applications and modern software architecture.

Conclusion:

Tight Coupling makes classes more dependent on each other, which can lead to a rigid and hard-to-maintain codebase.

Loose Coupling encourages flexibility, modularity, and better code maintainability by depending on abstractions instead of specific implementations. Dependency Injection is a key technique to achieve loose coupling in C#.

To avoid tight coupled state we use Dependency injection which is achieved using interfaces.

Interfaces are a powerful tool to use for decoupling.

Classes can commmunicate through interfaces rather than other concrete classes.

-> Dependency Injection in C#

Dependency Injection (DI) is a design pattern used in object-oriented programming, including C#, to achieve loose coupling between objects and their dependencies. It allows for better modularity, testability, and maintainability of code by externally providing the dependencies an object needs, instead of the object creating them itself.

In C#, the Dependency Injection pattern is widely supported and used with frameworks such as ASP.NET Core, where built-in DI containers allow you to manage object lifetimes and resolve dependencies automatically.

-> Key Concepts:

Dependency: Any object that another object needs to function correctly.

Injection: The process of passing dependencies into a class instead of the class creating them internally.

Service: A reusable component or class that provides functionality (dependencies).

Consumer: A class that depends on services to function.

-> Types of Dependency Injection:

Constructor Injection: Dependencies are provided through a class constructor.

Property Injection: Dependencies are provided through public properties.

Method Injection: Dependencies are provided as method parameters.

-> Why Use Dependency Injection?

Loose Coupling: Objects do not manage their own dependencies; they depend on abstractions (interfaces) rather than specific implementations.

Easier Testing: Since dependencies are passed externally, it is easier to swap them with mock objects during unit testing.

Improved Maintainability: It is easier to change implementations of dependencies without affecting the consuming class.

Better Separation of Concerns: The responsibility of managing dependencies is moved outside the class.

-> Constructor Injection Example

This is the most commonly used form of dependency injection. Dependencies are provided to the consumer class via the constructor.

Example:

---------------------------------------------------------------------------------------------------------------------
using System;

public interface IMessageService
{
    void SendMessage(string message);
}

// A concrete implementation of IMessageService
public class EmailService : IMessageService
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Email sent: {message}");
    }
}

// Another implementation of IMessageService
public class SmsService : IMessageService
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"SMS sent: {message}");
    }
}

// Consumer class that depends on IMessageService
public class Notification
{
    private readonly IMessageService _messageService;

    // Constructor Injection: Dependency is injected via constructor
    public Notification(IMessageService messageService)
    {
        _messageService = messageService;
    }

    public void Notify(string message)
    {
        _messageService.SendMessage(message);
    }
}

class Program
{
    static void Main()
    {
        // Injecting EmailService into Notification
        IMessageService emailService = new EmailService();
        Notification notificationWithEmail = new Notification(emailService);
        notificationWithEmail.Notify("Hello via Email!");

        // Injecting SmsService into Notification
        IMessageService smsService = new SmsService();
        Notification notificationWithSms = new Notification(smsService);
        notificationWithSms.Notify("Hello via SMS!");
    }
}
---------------------------------------------------------------------------------------------------------------------

-> Explanation:

IMessageService: An interface that abstracts the messaging functionality.

EmailService and SmsService: Two concrete implementations of the IMessageService interface.

Notification: A class that depends on IMessageService but does not know or care whether it is an email service or an SMS service. This class is dependent on the IMessageService interface, which is injected into the constructor.

Main Method: The Notification object is created, and the specific dependency (EmailService or SmsService) is injected at runtime.

-> Output

---------------------------------------------------------------------------------------------------------------------
Email sent: Hello via Email!
SMS sent: Hello via SMS!
---------------------------------------------------------------------------------------------------------------------

-> Dependency Injection in ASP.NET Core

ASP.NET Core provides built-in dependency injection through its service container, which allows you to register services and inject them automatically where needed. The DI container can manage the lifetime of the services, such as:

Singleton: One instance is created and shared.

Scoped: One instance per request is created.

Transient: A new instance is created every time it is requested.

-> Example with ASP.NET Core:

1) Service Registration in Startup.cs:

---------------------------------------------------------------------------------------------------------------------
public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        // Registering the service
        services.AddTransient<IMessageService, EmailService>(); // IMessageService will resolve to EmailService
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        // Application configuration
    }
}
---------------------------------------------------------------------------------------------------------------------

2) Service Injection in a Controller:

---------------------------------------------------------------------------------------------------------------------
public class HomeController : Controller
{
    private readonly IMessageService _messageService;

    // Constructor injection: IMessageService is automatically injected by the DI container
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

In ASP.NET Core, services are registered in the Startup class and injected automatically into the controllers or other classes by the framework.

Summary:

Dependency Injection allows the creation and passing of dependencies externally to a class, promoting loose coupling and easier testing.

Constructor Injection is the most common form, where dependencies are injected via the constructor.

DI is extensively supported in frameworks like ASP.NET Core, where services are managed and injected automatically by the built-in DI container.

*/