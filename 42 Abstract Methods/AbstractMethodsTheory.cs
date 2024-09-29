/* Abstract Methods

In C#, abstract properties are properties that are declared in an abstract class but do not have any implementation. Instead, the implementation of these properties is provided by a derived class. Abstract properties are used when you want to enforce that every derived class must provide its own implementation of the property.

Key Points:

Abstract Class: A class that contains at least one abstract member (method, property, etc.) and cannot be instantiated on its own.

Abstract Property: A property that is declared without a body in the abstract class, and the derived class must override it and provide the implementation.
Enforcement: By making a property abstract, you enforce that any subclass of the abstract class must implement that property.

Syntax Example:

---------------------------------------------------------------------------------
public abstract class Shape
{
    // Abstract property
    public abstract double Area { get; }

    // A regular method that uses the abstract property
    public void ShowArea()
    {
        Console.WriteLine($"The area is: {Area}");
    }
}

public class Circle : Shape
{
    private double _radius;

    // Constructor
    public Circle(double radius)
    {
        _radius = radius;
    }

    // Providing implementation of the abstract property
    public override double Area
    {
        get { return Math.PI * _radius * _radius; }
    }
}
---------------------------------------------------------------------------------

Explanation:

Abstract Class (Shape): This class defines an abstract property Area that must be implemented by any class that derives from Shape.

Derived Class (Circle): This class overrides the abstract property Area and provides a specific implementation that calculates the area of a circle.

In this way, abstract properties allow for polymorphism, where each derived class can provide its own implementation based on its specific requirements.

*/