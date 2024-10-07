using System;

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    // Constructor to initialize X and Y coordinates
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    // Overloading the + operator to add two points
    public static Point operator +(Point p1, Point p2)
    {
        return new Point(p1.X + p2.X, p1.Y + p2.Y);
    }

    // Overloading the - operator to subtract two points
    public static Point operator -(Point p1, Point p2)
    {
        return new Point(p1.X - p2.X, p1.Y - p2.Y);
    }

    // Overloading the == operator to compare two points
    public static bool operator ==(Point p1, Point p2)
    {
        return p1.X == p2.X && p1.Y == p2.Y;
    }

    // Overloading the != operator to compare two points
    public static bool operator !=(Point p1, Point p2)
    {
        return !(p1 == p2);
    }

    // Overriding the Equals method to complement == operator
    public override bool Equals(object obj)
    {
        if (obj == null || !(obj is Point))
            return false;

        Point p = (Point)obj;
        return X == p.X && Y == p.Y;
    }

    // Overriding the GetHashCode method (best practice when overriding Equals)
    public override int GetHashCode()
    {
        return (X, Y).GetHashCode();
    }

    // Method to display point coordinates
    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point(3, 4);
        Point p2 = new Point(2, 5);

        // Adding two points using overloaded + operator
        Point resultAdd = p1 + p2;
        Console.WriteLine($"p1 + p2 = {resultAdd}");  // Output: (5, 9)

        // Subtracting two points using overloaded - operator
        Point resultSub = p1 - p2;
        Console.WriteLine($"p1 - p2 = {resultSub}");  // Output: (1, -1)

        // Comparing two points using overloaded == operator
        bool areEqual = p1 == p2;
        Console.WriteLine($"p1 == p2: {areEqual}");  // Output: False

        // Comparing two points using overloaded != operator
        bool areNotEqual = p1 != p2;
        Console.WriteLine($"p1 != p2: {areNotEqual}");  // Output: True
    }
}
