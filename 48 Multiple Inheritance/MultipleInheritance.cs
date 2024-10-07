using System;

namespace Multiple_Inheritance
{
    // Base class representing a Person
    class Person
    {
        // Method of the Person class
        public void show()
        {
            Console.WriteLine("\nThis is a method of the Person class");
        }

        // Method specific to the Person class
        public void print1()
        {
            Console.WriteLine("\nThis is the print method of class Person");
        }
    }

    // Employee interface with method declarations
    interface Employee
    {
        void show();   // Interface method to be implemented by classes
        void print2(); // Another interface method for print functionality
    }

    // Mentor interface with a show method declaration
    interface Mentor
    {
        void show();   // Interface method to be implemented by classes
    }

    // Teacher class inherits from Person and implements Employee and Mentor interfaces
    class Teacher : Person, Employee, Mentor
    {
        // Explicit implementation of Employee's show method
        void Employee.show()
        {
            Console.WriteLine("\nThis is the overridden method of the Employee interface");
        }

        // Explicit implementation of Mentor's show method
        void Mentor.show()
        {
            Console.WriteLine("\nThis is the overridden method of the Mentor interface");
        }

        // Implementation of Employee's print2 method
        public void print2()
        {
            Console.WriteLine("\nThis is the overridden print method of the Employee interface");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Instantiate Teacher class as a Person
            Teacher obj = new Teacher();

            // Calls the Person class method (not the interface method)
            obj.show();  // Output: This is a method of the Person class

            // Create an object of Teacher as Employee type
            Employee obj1 = new Teacher();

            // Calls the Employee interface's overridden show method
            obj1.show();  // Output: This is the overridden method of the Employee interface

            // Create an object of Teacher as Mentor type
            Mentor obj2 = new Teacher();

            // Calls the Mentor interface's overridden show method
            obj2.show();  // Output: This is the overridden method of the Mentor interface

            // Create another instance of Teacher
            Teacher obj3 = new Teacher();

            // Calls the Person class method print1
            obj3.print1();  // Output: This is the print method of class Person

            // Calls the Employee interface's overridden print2 method
            obj3.print2();  // Output: This is the overridden print method of the Employee interface
        }
    }
}
