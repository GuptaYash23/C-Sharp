using System;

namespace Extension_methods
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    // Declaring a static class for Extension method
    public static class PersonExtensions
    {
        // Extension method for Person object
        public static string GetFullName(this Person person)
        {
            return $"{person.FirstName} {person.LastName}";
        }
    }

    // Using extension method for built-in datatype int(struct)

    public static class IntExtensions
    {
        // Extension method isEven for int datatype
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }
    }


    public class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person { FirstName = "Yash", LastName = "Gupta" };
            string fullName = person.GetFullName();  // Output: "John Doe"


            Console.WriteLine(fullName);      // Yash Gupta
            Console.WriteLine(23.IsEven());   // False
        }
    }
}