using System;

// Defining a simple struct
public struct Rectangle
{
    // Fields or properties of the struct (auto-implemented properties)
    public int Width { get; set; }
    public int Height { get; set; }

    // Constructor to initialize the struct
    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    // Method to calculate the area of the rectangle
    public int Area()
    {
        return Width * Height;
    }

    // Method to display dimensions of the rectangle
    public void Display()
    {
        Console.WriteLine($"Rectangle: Width = {Width}, Height = {Height}");
    }
}

class Program
{
    static void Main()
    {
        // Creating a Rectangle struct with the constructor
        Rectangle rect1 = new Rectangle(10, 20);

        // Accessing struct properties and methods
        rect1.Display();  // Output: Rectangle: Width = 10, Height = 20
        Console.WriteLine($"Area of rect1: {rect1.Area()}");  // Output: Area of rect1: 200

        // Assigning one struct to another creates a copy (value type behavior)
        Rectangle rect2 = rect1;

        // Modifying the copy (rect2), rect1 remains unchanged
        rect2.Width = 30;
        rect2.Height = 40;
        
        Console.WriteLine("\nAfter modifying rect2:");
        rect2.Display();  // Output: Rectangle: Width = 30, Height = 40
        rect1.Display();  // Output: Rectangle: Width = 10, Height = 20 (rect1 unchanged)

        // Boxing and Unboxing example (struct to object and back)
        object boxedRect = rect1;  // Boxing
        Rectangle unboxedRect = (Rectangle)boxedRect;  // Unboxing
        Console.WriteLine("\nAfter boxing and unboxing rect1:");
        unboxedRect.Display();  // Output: Rectangle: Width = 10, Height = 20

        // Nullable struct example (struct can be nullable using ?)
        Rectangle? nullableRect = null;  // Nullable version of Rectangle
        if (nullableRect.HasValue)
        {
            nullableRect.Value.Display();  // Won't be executed since nullableRect is null
        }
        else
        {
            Console.WriteLine("\nnullableRect is null.");  // Output: nullableRect is null.
        }
    }
}
