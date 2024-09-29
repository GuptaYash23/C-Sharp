using System;

public abstract class Shape
{
    // Abstract property, must be implemented by derived classes
    public abstract double Area { get; }

    // Method that displays the area of the shape
    public void ShowArea()
    {
        Console.WriteLine($"The area is: {Area}");
    }
}

public class Circle : Shape
{
    private double _radius;

    // Constructor to initialize radius
    public Circle(double radius)
    {
        _radius = radius;
    }

    // Overriding the abstract property to calculate the area of the circle
    public override double Area
    {
        get { return Math.PI * _radius * _radius; }
    }
}

public class Square : Shape
{
    private double _side;

    // Constructor to initialize side length
    public Square(double side)
    {
        _side = side;
    }

    // Overriding the abstract property to calculate the area of the square
    public override double Area
    {
        get { return _side * _side; }
    }
}

class Program
{
    static void Main()
    {
        // Create a circle with radius 5
        Shape circle = new Circle(5);
        circle.ShowArea(); // Output: The area is: 78.5398...

        // Create a square with side length 4
        Shape square = new Square(4);
        square.ShowArea(); // Output: The area is: 16
    }
}
