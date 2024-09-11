using System;

class Program
{
    // A method with multiple parameters
    public void PrintDetails(string name, int age, string city = "Unknown")
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("City: " + city);
    }

    static void Main(string[] args)
    {
        Program program = new Program();

        // Calling the method with named arguments
        program.PrintDetails(age: 25, name: "Alice", city: "New York");

        // Named arguments allow skipping optional parameters
        program.PrintDetails(name: "Bob", age: 30); // 'city' defaults to "Unknown"
    }
}
