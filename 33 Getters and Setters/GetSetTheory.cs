/* Getters and Setters

In C#, getters and setters are used to control access to the fields of a class. They are part of properties, which allow for controlled reading (get) and writing (set) of private variables (fields) of a class from outside the class.

What Are Properties?

A property in C# is a member of a class that provides a flexible mechanism to read, write, or compute the value of a private field. Properties use the get and set accessors to control how values are accessed or modified.

Here's a simple example of a property with both a getter and setter:

Example: Basic Getter and Setter

-------------------------------------------------------
class Person
{
    // Private field
    private string name;

    // Property with getter and setter
    public string Name
    {
        get { return name; }  // Getter: returns the value of the private field
        set { name = value; } // Setter: assigns a value to the private field
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person();

        // Using the setter to assign a value
        person.Name = "Alice";

        // Using the getter to retrieve the value
        Console.WriteLine(person.Name); // Output: Alice
    }
}
-------------------------------------------------------

Key Points:

Getter (get): Retrieves the value of a private field. It is called when the property is read.

Setter (set): Sets the value of a private field. It is called when a value is assigned to the property.

Auto-Implemented Properties

C# also supports auto-implemented properties, where the compiler creates a backing field automatically. This is a simpler way to define properties if no additional logic is needed in the get or set. They are combination of variables and properties

Example: Auto-Implemented Property

-------------------------------------------------------
class Person
{
    // Auto-implemented property
    public string Name { get; set; }
}

class Program
{
    static void Main()
    {
        Person person = new Person();

        person.Name = "Bob"; // Using auto-implemented setter
        Console.WriteLine(person.Name); // Using auto-implemented getter
    }
}
-------------------------------------------------------


Read-Only and Write-Only Properties

You can create read-only or write-only properties by including only a getter or setter.

Read-Only Property Example:

-------------------------------------------------------
class Person
{
    private string name;

    // Read-only property
    public string Name
    {
        get { return name; }
    }

    public Person(string name)
    {
        this.name = name;
    }
}
-------------------------------------------------------

Write-Only Property Example:

-------------------------------------------------------
class Person
{
    private string password;

    // Write-only property
    public string Password
    {
        set { password = value; }
    }
}
-------------------------------------------------------

Custom Logic in Getters and Setters

You can add custom logic in the getter or setter to perform actions like validation or transformation before returning or setting the value.

-------------------------------------------------------
class Person
{
    private int age;

    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            if (value >= 0)
            {
                age = value;
            }
            else
            {
                Console.WriteLine("Age cannot be negative");
            }
        }
    }
}
-------------------------------------------------------

Summary

Properties are a way to control access to the fields of a class.

The get accessor returns the value, while the set accessor assigns a value.

Auto-implemented properties simplify property declaration when no additional logic is required.

Properties can be read-only or write-only by using only the get or set accessors.

*/
