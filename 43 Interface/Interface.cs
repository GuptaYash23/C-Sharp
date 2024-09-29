using System;

namespace VehicleApp
{
    // Define the interface
    public interface IVehicle
    {
        // Declaration of properties and methods
        string Brand { get; set; }
        void Start();
        void Stop();
    }

    // Implement the interface in the Car class
    public class Car : IVehicle
    {
        public string Brand { get; set; }

        public Car(string brand)
        {
            Brand = brand;
        }

        // Implement the Start method
        public void Start()
        {
            Console.WriteLine($"{Brand} car is starting.");
        }

        // Implement the Stop method
        public void Stop()
        {
            Console.WriteLine($"{Brand} car is stopping.");
        }
    }

    // Implement the interface in the Bicycle class
    public class Bicycle : IVehicle
    {
        public string Brand { get; set; }

        public Bicycle(string brand)
        {
            Brand = brand;
        }

        // Implement the Start method
        public void Start()
        {
            Console.WriteLine($"{Brand} bicycle is starting.");
        }

        // Implement the Stop method
        public void Stop()
        {
            Console.WriteLine($"{Brand} bicycle is stopping.");
        }
    }

    // Main Program
    class Program
    {
        static void Main()
        {
            // Using the Car class
            IVehicle myCar = new Car("Toyota");
            myCar.Start();  // Output: Toyota car is starting.
            myCar.Stop();   // Output: Toyota car is stopping.

            // Using the Bicycle class
            IVehicle myBicycle = new Bicycle("Giant");
            myBicycle.Start();  // Output: Giant bicycle is starting.
            myBicycle.Stop();   // Output: Giant bicycle is stopping.
        }
    }
}
