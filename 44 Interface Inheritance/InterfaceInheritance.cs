using System;

namespace MultipleInterfaceInheritanceExample
{
    // Interface IVehicle
    public interface IVehicle
    {
        void Start();
    }

    // Interface IMaintainable
    public interface IMaintainable
    {
        void Service();
    }

    // Interface ICar inherits from both IVehicle and IMaintainable
    public interface ICar : IVehicle, IMaintainable
    {
        void OpenTrunk();
    }

    // Sedan class implements ICar, hence it must implement all members from IVehicle and IMaintainable
    public class Sedan : ICar
    {
        public void Start()
        {
            Console.WriteLine("Sedan is starting.");
        }

        public void Service()
        {
            Console.WriteLine("Sedan is being serviced.");
        }

        public void OpenTrunk()
        {
            Console.WriteLine("Sedan's trunk is opening.");
        }
    }

    class Program
    {
        static void Main()
        {
            ICar myCar = new Sedan();
            myCar.Start();        // Output: Sedan is starting.
            myCar.Service();      // Output: Sedan is being serviced.
            myCar.OpenTrunk();    // Output: Sedan's trunk is opening.

             // Create an interface pointer (reference) for IVehicle
            IVehicle vehiclePointer = new Sedan();
            vehiclePointer.Start();  // Output: Sedan is starting.
            // vehiclePointer cannot call OpenTrunk or Service because they are not part of IVehicle interface

            // Create an interface pointer (reference) for IMaintainable
            IMaintainable maintainablePointer = new Sedan();
            maintainablePointer.Service();  // Output: Sedan is being serviced.
            // maintainablePointer cannot call Start or OpenTrunk because they are not part of IMaintainable interface

            // Create an interface pointer (reference) for ICar
            ICar carPointer = new Sedan();
            carPointer.Start();       // Output: Sedan is starting.
            carPointer.Service();     // Output: Sedan is being serviced.
            carPointer.OpenTrunk();   // Output: Sedan's trunk is opening.
        }
    }
}
