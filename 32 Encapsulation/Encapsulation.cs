using System;

namespace EncapsulationExample
{
    public class Person
    {
        // Private field (Encapsulated)
        private string name;

        // Public property to access the private field
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                // You can add validation or additional logic here
                if (!string.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("Name cannot be empty or null.");
                }
            }
        }

        // Public method to interact with private fields
        public void Display()
        {
            Console.WriteLine($"Name: {name}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            
            // Setting a value through the public property
            person.Name = "Yash";

            // Trying to set an invalid value (this would throw an exception)
            // person.Name = ""; // Uncommenting this will cause an exception

            // Accessing the encapsulated field through a public method
            person.Display();  // Output: Name: Alice
        }
    }
}
