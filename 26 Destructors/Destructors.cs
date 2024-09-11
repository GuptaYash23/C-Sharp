using System;

namespace ConsoleApp
{
    public class Person
    {
        public string Name;
        public int Age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string GetName()
        {
            return this.Name;
        }

        public int GetAge() // Changed return type to int
        {
            return this.Age;
        }

        ~Person()
        {
            Console.WriteLine("Destructor has been invoked");
        }
    }

    class Program // Added a Program class to contain the Main method
    {
        public static void Main(string[] args)
        {
            Person yash = new Person("Yash", 22);

            Console.WriteLine(yash.GetName());
            Console.WriteLine(yash.GetAge());

            Person karan = new Person("Karan", 22);

            Console.WriteLine(karan.GetName());
            Console.WriteLine(karan.GetAge());

        }
    }
}
