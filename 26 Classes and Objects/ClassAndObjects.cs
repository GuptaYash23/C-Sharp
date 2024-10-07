using System;

class Car
{
    // Fields (private variables)
    private string model;
    private int year;

    // Property to access and modify 'model' field
    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    // Property to access and modify 'year' field
    public int Year
    {
        get { return year; }
        set { year = value; }
    }

    // Constructor to initialize a new Car object
    public Car(string model, int year)
    {
        this.model = model;
        this.year = year;
    }

    // Method to simulate the car driving
    public void Drive()
    {
        Console.WriteLine($"{model} is driving.");
    }
}

class Program
{
    static void Main()
    {
        // Creating an object of the Car class using the constructor
        Car car1 = new Car("Tesla Model S", 2023);
        
        // Accessing object properties and calling methods
        Console.WriteLine($"Car 1 Model: {car1.Model}");
        Console.WriteLine($"Car 1 Year: {car1.Year}");
        car1.Drive();

        Console.WriteLine();

        // Creating another object of the Car class
        Car car2 = new Car("Ford Mustang", 2021);

        // Accessing object properties and calling methods
        Console.WriteLine($"Car 2 Model: {car2.Model}");
        Console.WriteLine($"Car 2 Year: {car2.Year}");
        car2.Drive();
    }
}
