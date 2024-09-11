using System;

class Program
{
    // Static method (does not require an instance of the class)
    public static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the C# Methods Example!");
    }

    // Instance method (requires an instance of the class)
    public void Add(int a, int b)
    {
        int result = a + b;
        Console.WriteLine("The sum is: " + result);
    }

    // Method overloading (same method name with different parameters)
    public void PrintDetails(string name)
    {
        Console.WriteLine("Name: " + name);
    }

    public void PrintDetails(string name, int age)
    {
        Console.WriteLine("Name: " + name + ", Age: " + age);
    }

    // Method with ref parameter (passing by reference)
    public void MultiplyByTwo(ref int num)
    {
        num *= 2;
    }

    // Method with optional parameter
    public void GreetUser(string greeting = "Hello, User!")
    {
        Console.WriteLine(greeting);
    }

    static void Main(string[] args)
    {
        // Call the static method
        DisplayWelcomeMessage();

        // Create an instance of the class
        Program program = new Program();

        // Call the instance method
        program.Add(10, 20);

        // Call overloaded methods
        program.PrintDetails("John");
        program.PrintDetails("John", 25);

        // Call method with ref parameter
        int number = 5;
        program.MultiplyByTwo(ref number);
        Console.WriteLine("Number after multiplication: " + number);

        // Call method with optional parameter
        program.GreetUser(); // Uses the default value
        program.GreetUser("Good morning, Alice!"); // Uses the provided value
    }
}
